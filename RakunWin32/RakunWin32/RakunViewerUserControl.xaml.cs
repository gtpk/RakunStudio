using AvalonDock.MVVMTestApp;
using Microsoft.Expression.Interactivity.Layout;
using RakunWin32.Logic;
using RakunWin32.TabCommander;
using RakunWin32.ViewModels.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Xceed.Wpf.AvalonDock.Controls;

namespace RakunWin32
{
	/// <summary>
	/// Interaction logic for RakunViewerUserControl.xaml
	/// </summary>
	public partial class RakunViewerUserControl : UserControl
	{

        double FirstXPos, FirstYPos, FirstArrowXPos, FirstArrowYPos;
        object MovingObject;
        
        Line Path1, Path2, Path3, Path4;
        Rectangle FirstPosition, CurrentPosition;
        ModuleView CurrentSelect;
        Rectangle CurrentSelectPosition;
        // DrawingPath
        PathPointNode MovingPath;
        RakunModuleViewModel BeginnerPoint;
        // 
        // isConnected?
        bool isConnected = false;
        // if Connected, What is it?
        PathPointNode DestinationPoint;
        RakunModuleViewModel FinisherPoint;


        RakunModuleViewModel startingNode = null;

        public DispatcherTimer Timer = new DispatcherTimer();


		public RakunViewerUserControl()
		{
			this.InitializeComponent();

            PreviewMouseLeftButtonUp += ObjectPreviewMouseLeftButtonUp;
            PreviewKeyDown += RakunViewerUserControl_PreviewKeyDown;
            
            foreach (Control control in LayoutRoot.Children)
            {
                control.PreviewMouseLeftButtonUp += ObjectPreviewMouseLeftButtonUp;
                control.PreviewKeyDown += RakunViewerUserControl_PreviewKeyDown;
                control.Cursor = Cursors.Hand;
            }

            // Setting the MouseMove event for our parent control(In this case it is LayoutRoot).
            this.PreviewMouseMove += this.ObjectMouseMove;

            // Setting up the Lines that we want to show the path of movement
            List<Double> Dots = new List<double>();
            Dots.Add(1);
            Dots.Add(2);
            Path1 = new Line();
            Path1.Width = LayoutRoot.Width;
            Path1.Height = LayoutRoot.Height;
            Path1.Stroke = Brushes.DarkGray;
            Path1.StrokeDashArray = new DoubleCollection(Dots);

            Path2 = new Line();
            Path2.Width = LayoutRoot.Width;
            Path2.Height = LayoutRoot.Height;
            Path2.Stroke = Brushes.DarkGray;
            Path2.StrokeDashArray = new DoubleCollection(Dots);

            Path3 = new Line();
            Path3.Width = LayoutRoot.Width;
            Path3.Height = LayoutRoot.Height;
            Path3.Stroke = Brushes.DarkGray;
            Path3.StrokeDashArray = new DoubleCollection(Dots);

            Path4 = new Line();
            Path4.Width = LayoutRoot.Width;
            Path4.Height = LayoutRoot.Height;
            Path4.Stroke = Brushes.DarkGray;
            Path4.StrokeDashArray = new DoubleCollection(Dots);

            FirstPosition = new Rectangle();
            FirstPosition.Stroke = Brushes.DarkGray;
            FirstPosition.StrokeDashArray = new DoubleCollection(Dots);

            CurrentPosition = new Rectangle();
            CurrentPosition.Stroke = Brushes.DarkGray;
            CurrentPosition.StrokeDashArray = new DoubleCollection(Dots);

            CurrentSelectPosition = new Rectangle();
            CurrentSelectPosition.Stroke = Brushes.Green;
            CurrentSelectPosition.StrokeThickness = 3;
            CurrentSelectPosition.StrokeDashArray = new DoubleCollection(Dots);


            // Adding Lines to main designing panel(Canvas)
            LayoutRoot.Children.Add(Path1);
            LayoutRoot.Children.Add(Path2);
            LayoutRoot.Children.Add(Path3);
            LayoutRoot.Children.Add(Path4);
            LayoutRoot.Children.Add(FirstPosition);
            LayoutRoot.Children.Add(CurrentPosition);
            LayoutRoot.Children.Add(CurrentSelectPosition);


            
            
		}

        RakunNodeBase clip;

        void RakunViewerUserControl_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.Modifiers == ModifierKeys.Control)
            {
                if (e.Key == Key.C)
                {
                    if (CurrentSelect is ModuleView && CurrentSelect != null)
                    {
                        clip = (CurrentSelect.DataContext as RakunModuleViewModel)._ModuleInfo.Clone() as RakunNodeBase;
                    }
                }
                if (e.Key == Key.X)
                {
                    if (CurrentSelect is ModuleView && CurrentSelect != null)
                    {
                        clip = (CurrentSelect.DataContext as RakunModuleViewModel)._ModuleInfo.Clone() as RakunNodeBase;
                    }

                    if (CurrentSelect is ModuleView && CurrentSelect != null)
                    {
                        LayoutRoot.Children.Remove(CurrentSelect);
                        CurrentSelect = null;
                        CurrentSelectPosition.Visibility = System.Windows.Visibility.Hidden;
                    }
                }
                if (e.Key == Key.V)
                {
                    if(clip != null)
                    {
                        clip.OnAdd(null);
                    }
                }
                if (e.Key == Key.S)
                {
                    Workspace.This.ActiveDocument.OnSave(null);
                }
            }
            
            if(e.Key == Key.Delete)
            {
                if (CurrentSelect is ModuleView && CurrentSelect != null)
                {
                    LayoutRoot.Children.Remove(CurrentSelect);
                    CurrentSelect = null;
                    CurrentSelectPosition.Visibility = System.Windows.Visibility.Hidden;
                }
            }
        }



        void ObjectPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (MovingObject is ModuleView && MovingObject != null)
            {
                CurrentSelectPosition.Visibility = System.Windows.Visibility.Visible;

                CurrentSelectPosition.Width = (CurrentSelect as FrameworkElement).ActualWidth + 10;
                CurrentSelectPosition.Height = (CurrentSelect as FrameworkElement).ActualHeight + 10;
                Point po1 = new Point();
                po1.X = e.GetPosition((MovingObject as FrameworkElement).Parent as FrameworkElement).X - FirstXPos -5 ;
                po1.Y = e.GetPosition((MovingObject as FrameworkElement).Parent as FrameworkElement).Y - FirstYPos -5;
                CurrentSelectPosition.SetValue(Canvas.LeftProperty, po1.X);
                CurrentSelectPosition.SetValue(Canvas.TopProperty, po1.Y);
            }
            else
            {
                //CurrentSelect = null;
                //CurrentSelectPosition.Visibility = System.Windows.Visibility.Hidden;
            }

            if (isConnected == false)
            {
                if (MovingPath != null)
                {
                    //선은 있는데 연결이 끊긴경우


                    MovingPath.MyPath.Visibility = System.Windows.Visibility.Collapsed;
                    //MovingPath.Disconnect();
                    

                    if (MovingPath.NextPoint != null)
                    {
                        if (MovingPath.NextPoint.BeforePoint != null)
                        {
                            MovingPath.NextPoint.BeforePoint.Disconnect();
                            MovingPath.NextPoint.BeforePoint = null;
                        }

                        MovingPath.NextPoint.Disconnect();
                        MovingPath.NextPoint = null;
                    }
                        
                }
            }
            else if (DestinationPoint != null)
            {
                if (BeginnerPoint.Next != null)
                {
                    BeginnerPoint.Next.Before = null;
                    
                }
                if (MovingPath.NextPoint != null)
                {
                    MovingPath.NextPoint.BeforePoint = null;
                }
                
                //앞뒤로 연결하기
                MovingPath.NextPoint = DestinationPoint;
                DestinationPoint.BeforePoint = MovingPath;
                DestinationPoint.ComePath = MovingPath.MyPath;

                //IF문의 경우 True에 
                if (MovingPath.MySequence == PathPointNode.PathIFDirection.TrueSequence)
                {
                    BeginnerPoint.TrueNode = FinisherPoint;
                }
                else if (MovingPath.MySequence == PathPointNode.PathIFDirection.FalseSequence)
                {//false에 값을 넣는다.
                    BeginnerPoint.FalseNode = FinisherPoint;
                }
                else
                {
                    BeginnerPoint.Next = FinisherPoint;
                }

                FinisherPoint.Before = BeginnerPoint;

                MovingPath.OnConnect();
                MovingPath.NextPoint.OnConnect();
            }

            DestinationPoint = null;
            MovingPath = null;
            BeginnerPoint = null;
            FinisherPoint = null;

            // In this event, we should set the lines visibility to Hidden
            MovingObject = null;
            Path1.Visibility = System.Windows.Visibility.Hidden;
            Path2.Visibility = System.Windows.Visibility.Hidden;
            Path3.Visibility = System.Windows.Visibility.Hidden;
            Path4.Visibility = System.Windows.Visibility.Hidden;
            FirstPosition.Visibility = System.Windows.Visibility.Hidden;
            CurrentPosition.Visibility = System.Windows.Visibility.Hidden;
            
        }

        private void ObjectMouseMove(object sender, MouseEventArgs e)
        {
            /*
             * In this event, at first we check the mouse left button state. If it is pressed and 
             * event sender object is similar with our moving object, we can move our control with
             * some effects.
             */
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (MovingObject == null)
                {
                    if (MovingPath != null)
                    {
                        Point NowActualPostion = e.GetPosition((MovingPath.MyPath.Path as FrameworkElement).Parent as FrameworkElement);

                        if (isConnected)
                        {
                            if(DestinationPoint != null)
                            {
                                Point relativeLocation = DestinationPoint.TranslatePoint(new Point(5, 5), LayoutRoot);

                                if (relativeLocation.X < NowActualPostion.X + 15
                                    && relativeLocation.X > NowActualPostion.X - 15
                                    && relativeLocation.Y < NowActualPostion.Y + 15
                                    && relativeLocation.Y > NowActualPostion.Y - 15)
                                {
                                    //MyPathStartPosition
                                    PathReDrawing(MovingPath.MyPath.StartPosition,relativeLocation,MovingPath.MyPath);
                                    MovingPath.MyPath.EndPathPosition = relativeLocation;
                                    return;
                                }
                            }
                            
                            isConnected = false;
                            DestinationPoint = null;
                        }
                        PathReDrawing(MovingPath.MyPath.StartPosition, NowActualPostion, MovingPath.MyPath);
                        MovingPath.MyPath.EndPathPosition = NowActualPostion;
                    }
                    return;
                }
                    
                // We start to moving objects with setting the lines positions.
                Path1.X1 = FirstArrowXPos;
                Path1.Y1 = FirstArrowYPos;
                Path1.X2 = e.GetPosition((MovingObject as FrameworkElement).Parent as FrameworkElement).X - FirstXPos;
                Path1.Y2 = e.GetPosition((MovingObject as FrameworkElement).Parent as FrameworkElement).Y - FirstYPos;

                Path2.X1 = Path1.X1 + (MovingObject as FrameworkElement).ActualWidth;
                Path2.Y1 = Path1.Y1;
                Path2.X2 = Path1.X2 + (MovingObject as FrameworkElement).ActualWidth;
                Path2.Y2 = Path1.Y2;

                Path3.X1 = Path1.X1;
                Path3.Y1 = Path1.Y1 + (MovingObject as FrameworkElement).ActualHeight;
                Path3.X2 = Path1.X2;
                Path3.Y2 = Path1.Y2 + (MovingObject as FrameworkElement).ActualHeight;

                Path4.X1 = Path1.X1 + (MovingObject as FrameworkElement).ActualWidth;
                Path4.Y1 = Path1.Y1 + (MovingObject as FrameworkElement).ActualHeight;
                Path4.X2 = Path1.X2 + (MovingObject as FrameworkElement).ActualWidth;
                Path4.Y2 = Path1.Y2 + (MovingObject as FrameworkElement).ActualHeight;

                FirstPosition.Width = (MovingObject as FrameworkElement).ActualWidth;
                FirstPosition.Height = (MovingObject as FrameworkElement).ActualHeight;
                FirstPosition.SetValue(Canvas.LeftProperty, FirstArrowXPos);
                FirstPosition.SetValue(Canvas.TopProperty, FirstArrowYPos);

                CurrentPosition.Width = (MovingObject as FrameworkElement).ActualWidth;
                CurrentPosition.Height = (MovingObject as FrameworkElement).ActualHeight;
                CurrentPosition.SetValue(Canvas.LeftProperty, Path1.X2);
                CurrentPosition.SetValue(Canvas.TopProperty, Path1.Y2);

                Path1.Visibility = System.Windows.Visibility.Visible;
                Path2.Visibility = System.Windows.Visibility.Visible;
                Path3.Visibility = System.Windows.Visibility.Visible;
                Path4.Visibility = System.Windows.Visibility.Visible;
                FirstPosition.Visibility = System.Windows.Visibility.Visible;
                CurrentPosition.Visibility = System.Windows.Visibility.Visible;

                /*
                 * For changing the position of a control, we should use the SetValue method to setting
                 * the Canvas.LeftProperty and Canvas.TopProperty dependencies.
                 * 
                 * For calculating the currect position of the control, we should do :
                 *      Current position of the mouse cursor on the object parent - 
                 *      Mouse position on the control at the start of moving -
                 *      position of the control's parent.
                 */
                (MovingObject as FrameworkElement).SetValue(Canvas.LeftProperty,
                    e.GetPosition((MovingObject as FrameworkElement).Parent as FrameworkElement).X - FirstXPos);

                (MovingObject as FrameworkElement).SetValue(Canvas.TopProperty,
                    e.GetPosition((MovingObject as FrameworkElement).Parent as FrameworkElement).Y - FirstYPos);

                if(MovingObject is ModuleView)
                {
                    GenAllPathPosition((MovingObject as ModuleView).LayoutRoot.Children);
                }
            }
        }

        private IEnumerable<T> FindVisualChildren<T>(DependencyObject obj) where T : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child != null && child is T)
                {
                    yield return (T)child;
                }
                else
                {
                    var childOfChild = FindVisualChildren<T>(child);
                    if (childOfChild != null)
                    {
                        foreach (var subchild in childOfChild)
                        {
                            yield return subchild;
                        }
                    }
                }
            }
        }

        private void GenAllPathPosition(System.Collections.IEnumerable enumerable)
        {
            System.Collections.IEnumerator e = enumerable.GetEnumerator();
            while (e.MoveNext())
            {
                if (e.Current is PathPointNode)
                {
                    PathPointNode node = e.Current as PathPointNode;
                    if (node.MyPath != null)
                    {
                        Point relativeLocation = node.TranslatePoint(new Point(5, 5), LayoutRoot);
                        PathReDrawing(relativeLocation, node.MyPath.EndPathPosition, node.MyPath);
                        node.MyPath.StartPosition = relativeLocation;

                    }
                    if (node.ComePath != null)
                    {
                        Point relativeLocation = node.TranslatePoint(new Point(5, 5), LayoutRoot);
                        PathReDrawing(node.ComePath.StartPosition, relativeLocation, node.ComePath);
                        node.ComePath.EndPathPosition = relativeLocation;
                    }
                }
            }
        }

        public void GenAllPathPosition(UIElementCollection children)
        {

            IEnumerable<PathPointNode> PathPointNodes = FindVisualChildren<PathPointNode>(this);

            foreach (FrameworkElement control in children)
            {
                if (control is Panel)
                    GenAllPathPosition((control as Panel).Children);

                if (control is ListBox)
                {
                    GenAllPathPosition(FindVisualChildren<PathPointNode>(control));
                }

                if(control is PathPointNode)
                {
                    PathPointNode node = control as PathPointNode;
                    if (node.MyPath != null)
                    {
                        Point relativeLocation = node.TranslatePoint(new Point(5, 5), LayoutRoot);
                        PathReDrawing(relativeLocation, node.MyPath.EndPathPosition, node.MyPath);
                        node.MyPath.StartPosition = relativeLocation;
                          
                    }
                    if (node.ComePath != null)
                    {
                        Point relativeLocation = node.TranslatePoint(new Point(5, 5), LayoutRoot);
                        PathReDrawing(node.ComePath.StartPosition, relativeLocation, node.ComePath);
                        node.ComePath.EndPathPosition = relativeLocation;
                    }
                }

            }
        }


        private void PathReDrawing(Point StartPosition, Point EndPosision, RakunPathObject obj)
        {
            Path arcPath = obj.Path;
            PathFigure pthFigure = new PathFigure();
            pthFigure.StartPoint = StartPosition;
            double position = ((EndPosision.X - StartPosition.X) / 2);

            PathSegmentCollection myPathSegmentCollection = new PathSegmentCollection();
            if(position > 25 )
            {
                BezierSegment bzSeg = new BezierSegment();
                System.Windows.Point Point1 = new Point(StartPosition.X + position, StartPosition.Y);
                System.Windows.Point Point2 = new Point(EndPosision.X - position, EndPosision.Y);
                System.Windows.Point Point3 = EndPosision;


                bzSeg.Point1 = Point1;
                bzSeg.Point2 = Point2;
                bzSeg.Point3 = Point3;
                myPathSegmentCollection.Add(bzSeg);
                //      O---OB
                //      |
                // AO---O
            }
            else
            {
                //      AO--O
                //          |
                //   O--O---O
                //   |       
                //   O--OB   

                //   O---OB
                //   |
                //   O--O---O
                //          |
                //      AO--O

                double DefualtWidth = 50;
                
                double height = (EndPosision.Y - StartPosition.Y)/2;

                {
                    BezierSegment bzSeg = new BezierSegment();
                    bzSeg.Point1 = new Point(StartPosition.X + DefualtWidth, StartPosition.Y);
                    bzSeg.Point2 = new Point(StartPosition.X + DefualtWidth, StartPosition.Y + height);
                    bzSeg.Point3 = new Point(StartPosition.X + (position), StartPosition.Y + height);
                    myPathSegmentCollection.Add(bzSeg);
                }
                {
                    BezierSegment bzSeg = new BezierSegment();
                    bzSeg.Point1 = new Point(EndPosision.X - DefualtWidth, EndPosision.Y - height);
                    bzSeg.Point2 = new Point(EndPosision.X - DefualtWidth, EndPosision.Y);
                    bzSeg.Point3 = new Point(EndPosision.X, EndPosision.Y);
                    myPathSegmentCollection.Add(bzSeg);
                }
                
            }
            


            
            

            pthFigure.Segments = myPathSegmentCollection;

            PathFigureCollection pthFigureCollection = new PathFigureCollection();
            pthFigureCollection.Add(pthFigure);

            PathGeometry pthGeometry = new PathGeometry();
            pthGeometry.Figures = pthFigureCollection;

            arcPath.Data = pthGeometry;
        }

        private void ObjectMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //var focusedControl = Keyboard.FocusedElement;
            //MessageBox.Show(focusedControl.ToString());
            if (sender is PathPointNode)
                return;

            //In this event, we get current mouse position on the control to use it in the MouseMove event.
            FirstXPos = e.GetPosition(sender as FrameworkElement).X;
            FirstYPos = e.GetPosition(sender as FrameworkElement).Y;
            FirstArrowXPos = e.GetPosition((sender as FrameworkElement).Parent as FrameworkElement).X - FirstXPos;
            FirstArrowYPos = e.GetPosition((sender as FrameworkElement).Parent as FrameworkElement).Y - FirstYPos;
            MovingObject = sender;

            if(MovingObject is ModuleView)
            {
                CurrentSelect = sender as ModuleView;
                CurrentSelect.Focus();
                CurrentSelectPosition.Visibility = System.Windows.Visibility.Visible;

                CurrentSelectPosition.Width = (CurrentSelect as FrameworkElement).ActualWidth + 5;
                CurrentSelectPosition.Height = (CurrentSelect as FrameworkElement).ActualHeight + 5;
                Point po1 = new Point();
                po1.X = e.GetPosition((MovingObject as FrameworkElement).Parent as FrameworkElement).X - FirstXPos;
                po1.Y = e.GetPosition((MovingObject as FrameworkElement).Parent as FrameworkElement).Y - FirstYPos;
                CurrentSelectPosition.SetValue(Canvas.LeftProperty, po1.X);
                CurrentSelectPosition.SetValue(Canvas.TopProperty, po1.Y);



            }
            else
            {
                CurrentSelect = null;
                CurrentSelectPosition.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        public void AddRakunNode(RakunModuleViewModel node)
        {

            if (node.ModuleInfo.NodeType == RakunNodeBase.RakunNodeType.Starting)
                startingNode = node;

            node.Root.DataContext = node;
            //node.Root.TBTitle.Text = node.ModuleInfo.ModuleName;

            node.Root.ModuleNode.Visibility = System.Windows.Visibility.Collapsed;
            node.Root.StartingNode.Visibility = System.Windows.Visibility.Collapsed;
            node.Root.ForNode.Visibility = System.Windows.Visibility.Collapsed;
            node.Root.IFNode.Visibility = System.Windows.Visibility.Collapsed;
            node.Root.ValueNode.Visibility = System.Windows.Visibility.Collapsed;
            node.Root.InputNode.Visibility = System.Windows.Visibility.Collapsed;

            if (node.ModuleInfo.NodeType == RakunNodeBase.RakunNodeType.Starting)
                node.Root.StartingNode.Visibility = System.Windows.Visibility.Visible;
            else if (node.ModuleInfo.NodeType == RakunNodeBase.RakunNodeType.Module)
                node.Root.ModuleNode.Visibility = System.Windows.Visibility.Visible;
            else if (node.ModuleInfo.NodeType == RakunNodeBase.RakunNodeType.For)
                node.Root.ForNode.Visibility = System.Windows.Visibility.Visible;
            else if (node.ModuleInfo.NodeType == RakunNodeBase.RakunNodeType.If)
                node.Root.IFNode.Visibility = System.Windows.Visibility.Visible;
            else if (node.ModuleInfo.NodeType == RakunNodeBase.RakunNodeType.Value)
                node.Root.ValueNode.Visibility = System.Windows.Visibility.Visible;
            else if (node.ModuleInfo.NodeType == RakunNodeBase.RakunNodeType.Input)
                node.Root.InputNode.Visibility = System.Windows.Visibility.Visible;

            //MouseDragElementBehavior be = new MouseDragElementBehavior();
            //be.Attach(myButton);
            node.Root.MouseLeftButtonDown += ObjectMouseLeftButtonDown;
            node.Root.PreviewMouseLeftButtonUp += ObjectPreviewMouseLeftButtonUp;
            node.Root.PreviewKeyDown += RakunViewerUserControl_PreviewKeyDown;
            node.Root.Focusable = true;
            
            LayoutRoot.Children.Add(node.Root);
        }

        public void StartPath(RakunModuleViewModel Start, ref PathPointNode node)
        {

            //UIElement container = VisualTreeHelper.GetParent(control) as UIElement;
            Point relativeLocation = node.TranslatePoint(new Point(5, 5), LayoutRoot);
            node.MyPath.StartPosition = relativeLocation;
            node.MyPath.EndPathPosition = relativeLocation;


            node.MyPath.Path.Stroke = node.Foreground;

            isConnected = false;
            MovingPath = node;
            BeginnerPoint = Start;

            MovingPath.MyPath.Visibility = System.Windows.Visibility.Visible;
            if (node.NextPoint != null)
            {
                node.NextPoint.ComePath = null;
                if (MovingPath.NextPoint != null)
                    MovingPath.NextPoint.Disconnect();
                node.NextPoint = null;
            }
            
        }

        public void StartLine(RakunModuleViewModel Start, PathPointNode node)
        {
            /*
            Line sequence = node.MyPath;
            sequence.Width = LayoutRoot.Width;
            sequence.Height = LayoutRoot.Height;
            Point CurrentPos = Mouse.GetPosition(this);

            //UIElement container = VisualTreeHelper.GetParent(control) as UIElement;
            Point relativeLocation = node.TranslatePoint(new Point(5, 5), LayoutRoot);

            sequence.X1 = relativeLocation.X;
            sequence.Y1 = relativeLocation.Y;
            sequence.X2 = relativeLocation.X;
            sequence.Y2 = relativeLocation.Y;

            isConnected = false;
            MovingPath = node;
            BeginnerPoint = Start;

            MovingPath.MyPath.Visibility = System.Windows.Visibility.Visible;
            if (node.NextPoint != null)
            {
                node.NextPoint._ComePath = null;
                node.NextPoint = null;
            }
            */
        }


        public Line CreateLine()
        {
            List<Double> Dots = new List<double>();
            Dots.Add(1);
            Dots.Add(2);
            Line sequence = new Line();
            sequence.Width = LayoutRoot.Width;
            sequence.Height = LayoutRoot.Height;
            sequence.Stroke = Brushes.White;
            //sequence.StrokeDashArray = new DoubleCollection(Dots);
            sequence.StrokeThickness = 3;
            Canvas.SetZIndex(sequence, -1);
            LayoutRoot.Children.Add(sequence);

            return sequence;
        }

        public RakunPathObject CreatePath()
        {
            /*
            PathFigure pthFigure = new PathFigure();
            pthFigure.StartPoint = new Point(10, 100);

            System.Windows.Point Point1 = new System.Windows.Point(100, 0);
            System.Windows.Point Point2 = new System.Windows.Point(200, 200);
            System.Windows.Point Point3 = new System.Windows.Point(300, 100);

            BezierSegment bzSeg = new BezierSegment();
            bzSeg.Point1 = Point1;
            bzSeg.Point2 = Point2;
            bzSeg.Point3 = Point3;


            PathSegmentCollection myPathSegmentCollection = new PathSegmentCollection();
            myPathSegmentCollection.Add(bzSeg);

            pthFigure.Segments = myPathSegmentCollection;

            PathFigureCollection pthFigureCollection = new PathFigureCollection();
            pthFigureCollection.Add(pthFigure);

            PathGeometry pthGeometry = new PathGeometry();
            pthGeometry.Figures = pthFigureCollection;
            */
            Path arcPath = new Path();
            arcPath.Stroke = new SolidColorBrush(Colors.White);
            arcPath.StrokeThickness = 1;
            //arcPath.Data = pthGeometry;
            arcPath.Fill = new SolidColorBrush(Colors.Transparent);
            Canvas.SetZIndex(arcPath, -1);
            LayoutRoot.Children.Add(arcPath);
            RakunPathObject obj = new RakunPathObject();
            obj.Path = arcPath;
            return obj;
        }

        public void EnterSequence(RakunModuleViewModel Finish,PathPointNode node)
        {
            if (MovingPath == null)
                return;
            if (MovingPath == node)
                return;

            if(MovingPath.PathType == node.PathType)
            {
                isConnected = true;
                DestinationPoint = node;
                FinisherPoint = Finish;
            }
        }

        public void LeaveSequence(PathPointNode node)
        {
            
        }

        public string BuildArduino()
        {
            RakunModuleViewModel itorNode = startingNode;
            RakunNodeBase Resualt = new RakunNodeBase();
            while (itorNode != null)
            {
                Resualt = RakunModuleViewModel.SumbNode(Resualt, itorNode).Clone() as RakunNodeBase;
                itorNode = itorNode.Next;
            }

            return Resualt.Gen_C_Code();
        }
	}
}