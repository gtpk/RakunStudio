using AvalonDock.MVVMTestApp;
using RakunWin32.TabCommander;
using RakunWin32.ViewModels.Model;
using RakunWin32.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RakunWin32
{
	/// <summary>
	/// Interaction logic for PathPointNode.xaml
	/// </summary>
	public partial class PathPointNode : UserControl
	{
        public enum TypeOfPathPoint { Sequence,Value }
        public enum TypeDirection { IN, OUT }
        public enum PathIFDirection { None, TrueSequence,FalseSequence }
        TypeOfPathPoint _Type = TypeOfPathPoint.Sequence;
        public PathIFDirection _MySequence = PathIFDirection.None;
        public PathIFDirection MySequence
        {
            get
            {
                return _MySequence;
            }
            set
            {
                _MySequence = value;
            }
        }
        //Current My Path

        private RakunPathObject _MyPath;
        public RakunPathObject MyPath
        {
            get
            {
                return _MyPath;
            }
            set
            {
                _MyPath = value;

                if (value != null)
                {
                    Storyboard s = (Storyboard)TryFindResource("OnConnect");
                    s.Begin();
                }
                else
                {
                    Storyboard s = (Storyboard)TryFindResource("OnDisConnect");
                    s.Begin();
                    
                }
            }
        }

        public RakunModuleViewModel ModuleVM
        {
            get
            {
                return this.DataContext as RakunModuleViewModel;
            }
        }

    
        public RakunValueNodeViewModel ParentVM
        {
            get
            {
                return this.DataContext as RakunValueNodeViewModel;
                
            }
        }
        

        //Came On Path;
        private RakunPathObject _ComePath;
        public RakunPathObject ComePath
        {
            get
            {
                return _ComePath;
            }
            set
            {
                if(value != null)
                {
                    Storyboard s = (Storyboard)TryFindResource("OnConnect");
                    s.Begin();
                }
                else
                {
                    Storyboard s = (Storyboard)TryFindResource("OnDisConnect");
                    s.Begin();
                }
                _ComePath = value;
            }
        }

        public PathPointNode NextPoint;
        public PathPointNode _BeforePoint;
        public PathPointNode BeforePoint
        {
            get
            {
                return _BeforePoint;
            }
            set
            {
                if (value.ParentVM == null)
                    if (value.ModuleVM == null)
                        throw new System.InvalidOperationException("Dosen't exsist");
                _BeforePoint = value;
                
                if (PathType != TypeOfPathPoint.Value)
                {
                    
                    _BeforePoint = value;
                }
            }
        }

        public TypeOfPathPoint PathType 
        {
            get
            {
                return _Type;
            }
            set
            {
                _Type = value;
            }
        }

        TypeDirection _DirctionType = TypeDirection.IN;

        public TypeDirection DirectionType
        {
            get
            {
                return _DirctionType;
            }
            set
            {
                _DirctionType = value;
            }
        }

        public void Disconnect()
        {
            Storyboard s = (Storyboard)TryFindResource("OnDisConnect");
            s.Begin();
        }
        public void OnConnect()
        {
            Storyboard s = (Storyboard)TryFindResource("OnConnect");
            s.Begin();
        }

        public PathPointNode()
        {
            this.InitializeComponent();

            this.MouseLeftButtonDown += PathPointNode_MouseLeftButtonDown;


            this.PreviewMouseMove += PathPointNode_PreviewMouseMove;
            this.MouseLeave += PathPointNode_MouseLeave;

            
                
        }

        void PathPointNode_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (DirectionType == TypeDirection.OUT)
            {
                Workspace.This.StatusString = "Invaild Action : Path Point Type is Out";
                Workspace.This.Statusbar = Colors.Red;
                e.Handled = true;
                return;
            }
                

            if (EnterCommand != null)
                EnterCommand.Execute(this);

            e.Handled = true;
        }

        void PathPointNode_MouseLeave(object sender, MouseEventArgs e)
        {
            if (LeaveCommand != null)
                LeaveCommand.Execute(this);
            e.Handled = true;
        }


        void PathPointNode_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (DirectionType == TypeDirection.IN)
            {
                e.Handled = true;
                return;
            }

            Workspace.This.StatusString = "Connect Sequen Point";

            if (DraggingCommand != null)
                DraggingCommand.Execute(this);
            e.Handled = true;
        }

        #region DraggingCommand

        public ICommand DraggingCommand
        {
            get { return (ICommand)GetValue(DraggingCommandProperty); }
            set { SetValue(DraggingCommandProperty, value); }
        }
        public static DependencyProperty DraggingCommandProperty = DependencyProperty.Register(
           "DraggingCommand",
           typeof(ICommand),
           typeof(PathPointNode));

        #endregion

        #region EnterCommand

        public ICommand EnterCommand
        {
            get { return (ICommand)GetValue(EnterCommandProperty); }
            set { SetValue(EnterCommandProperty, value); }
        }

        public static DependencyProperty EnterCommandProperty = DependencyProperty.Register(
           "EnterCommand",
           typeof(ICommand),
           typeof(PathPointNode));

        #endregion

        #region LeaveCommand

        public ICommand LeaveCommand
        {
            get { return (ICommand)GetValue(LeaveCommandProperty); }
            set { SetValue(LeaveCommandProperty, value); }
        }

        public static DependencyProperty LeaveCommandProperty = DependencyProperty.Register(
           "LeaveCommand",
           typeof(ICommand),
           typeof(PathPointNode));

        #endregion

    }
}