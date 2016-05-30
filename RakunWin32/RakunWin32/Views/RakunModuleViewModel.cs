using AvalonDock.MVVMTestApp;
using RakunWin32.Logic;
using RakunWin32.Logic.Model;
using RakunWin32.ViewModel;
using RakunWin32.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;

namespace RakunWin32.TabCommander
{
    public class RakunModuleViewModel : AvalonDock.MVVMTestApp.ViewModelBase
    {
        public string name;

        public RakunNodeBase _ModuleInfo;
        public RakunNodeBase ModuleInfo
        {
            get
            {
                return _ModuleInfo.Clone() as RakunNodeBase;
            }
            set
            {
                _ModuleInfo = value;
            }
        }

        public string input
        {
            get;
            set;
        }

        public void SetMother(RakunModuleViewModel vm)
        {
            _ModuleInfo.MotherVM = vm;
        }

        private ObservableCollection<RakunValueNodeViewModel> _ModuleValues = new ObservableCollection<RakunValueNodeViewModel>();
        public ObservableCollection<RakunValueNodeViewModel> ModuleValues
        {
            get
            {
                return _ModuleValues;
            }
            set
            {
                _ModuleValues = value;
            }
        }


        private RakunViewerUserControl Parent;
        public ModuleView Root;


        public RakunModuleViewModel Before;
        public RakunModuleViewModel Next;

        public RakunModuleViewModel TrueNode;
        public RakunModuleViewModel FalseNode;

        public RakunModuleViewModel(RakunNodeBase Module, RakunViewerUserControl _View, ModuleView _Root)
        {
            ModuleInfo = Module.Clone() as RakunNodeBase;
            Parent = _View;
            Root = _Root;
            if (Module.NodeType == RakunNodeBase.RakunNodeType.For)
            {
                _ModuleValues.Add(new RakunValueNodeViewModel(new RakunNode() { NodeName = "index" , type = RakunType.ValueName }, Root, _View, this));
            }

            if (Module.NodeType == RakunNodeBase.RakunNodeType.If)
            {
                //_ModuleValues.Add(new RakunValueNodeViewModel(new RakunNode() { NodeName = "Condition", type = RakunType.ValueName }, Root, _View, this));
            }

            if (ModuleInfo.rootNode != null)
            {
                foreach (RakunNode node in ModuleInfo.rootNode.Rakunlist)
                {
                    _ModuleValues.Add(new RakunValueNodeViewModel(node, Root, _View, this));
                }
            }

            
        }

        public string ModuleName 
        { 
            get
            {
                if(ModuleInfo is RakunNodeModule)
                    return (ModuleInfo as RakunNodeModule).ModuleName;
                else
                    return "";
            }
        }

        public static RakunNodeBase SumbNode(RakunNodeBase c1original,RakunModuleViewModel c2mother)
        {
           

            if (c2mother == null)
                return c1original.Clone() as RakunNodeBase;

            RakunNodeBase c1 = c1original.Clone() as RakunNodeBase ;

            RakunNodeBase c2 = c2mother.ModuleInfo.Clone() as RakunNodeBase;
            //값 대입하기
            addbefore(ref c2mother, ref c1);

            //합성하기
            //근데 IF노드일경우 조금 다름
            if (c2mother.ModuleInfo.NodeType == RakunNodeBase.RakunNodeType.If)
            {
                RakunNodeBase TResualt = new RakunNodeBase();
                {
                    //True일경우
                    RakunModuleViewModel itorNode = c2mother.TrueNode;
                

                    //연결된  시퀀스가 있으면
                    while (itorNode != null)
                    {
                        addbefore(ref itorNode, ref TResualt);
                        //다더함
                        TResualt = (TResualt + itorNode.ModuleInfo).Clone() as RakunNodeBase;
                        addAfter(ref itorNode, ref TResualt);
                        itorNode = itorNode.Next;
                        
                    }
                }

                RakunNodeBase FResualt = new RakunNodeBase();
                {
                    RakunModuleViewModel itorNode = c2mother.FalseNode;
                
                    //연결된  시퀀스가 있으면
                    while (itorNode != null)
                    {
                        addbefore(ref itorNode, ref FResualt);
                        //다더함
                        FResualt = (FResualt + itorNode.ModuleInfo).Clone() as RakunNodeBase;
                        addAfter(ref itorNode, ref FResualt);
                        itorNode = itorNode.Next;
                        
                    }
                }

                RakunNodeIf ifnode = c2 as RakunNodeIf;
                ifnode.AddIfTrue(TResualt, FResualt);
            }

            //값 대입하기
            addAfter(ref c2mother, ref c2);
            
            return c1 + c2;
        }

        public static void addbefore(ref RakunModuleViewModel c2mother, ref RakunNodeBase c1)
        {
            foreach (RakunValueNodeViewModel node in c2mother.ModuleValues)
            {
                if (node.Input == null)
                    continue;

                if (node.Input.BeforePoint == null)
                    continue;

                RakunValueNodeViewModel ParentNode = node.Input.BeforePoint.ParentVM;

                if (ParentNode == null)
                {
                    if (node.Input.BeforePoint != null)
                    {
                        RakunModuleViewModel ParentNodeVM = node.Input.BeforePoint.ModuleVM;

                        RakunNodeInput inputf = Workspace.This.RakunManager.inputNode.Clone() as RakunNodeInput;
                        inputf.rootNode.replace(inputf.rootNode.loopfunction, "NUMBER", ParentNodeVM.input);
                        inputf.rootNode.replace(inputf.rootNode.loopfunction, "INPUTVALUE", node.ChangedName);
                        c1 = c1 + inputf;

                        //node.Input.BeforePoint.
                    }
                    continue;
                }


                RakunNodeInput input = Workspace.This.RakunManager.inputNode.Clone() as RakunNodeInput;
                input.rootNode.replace(input.rootNode.loopfunction, "NUMBER", ParentNode.ChangedName);
                input.rootNode.replace(input.rootNode.loopfunction, "INPUTVALUE", node.ChangedName);
                c1 = c1 + input;
            }
            
        }

        public static void addAfter(ref RakunModuleViewModel c2mother, ref RakunNodeBase c2)
        {
            //값 대입하기
            foreach (RakunValueNodeViewModel node in c2mother.ModuleValues)
            {
                if (node.Input == null)
                    continue;
                if (node.Input.NextPoint == null)
                    continue;

                RakunValueNodeViewModel ParentNode = node.Input.NextPoint.ParentVM;
                if (ParentNode == null)
                {
                    if (node.Input.BeforePoint != null)
                    {
                        RakunModuleViewModel ParentNodeVM = node.Input.BeforePoint.ModuleVM;

                        RakunNodeInput inputf = Workspace.This.RakunManager.inputNode.Clone() as RakunNodeInput;
                        inputf.rootNode.replace(inputf.rootNode.loopfunction, "NUMBER", ParentNodeVM.input);
                        inputf.rootNode.replace(inputf.rootNode.loopfunction, "INPUTVALUE", node.ChangedName);
                        c2 = c2 + inputf;

                        //node.Input.BeforePoint.
                    }
                    continue;
                }
                RakunNodeInput input = Workspace.This.RakunManager.inputNode.Clone() as RakunNodeInput;
                input.rootNode.replace(input.rootNode.loopfunction, "NUMBER", node.ChangedName);
                input.rootNode.replace(input.rootNode.loopfunction, "INPUTVALUE", ParentNode.ChangedName);
                c2 = c2 + input;
            }

        }

        #region PathPointSelectCommand

        RelayCommand _PathPointSelectCommand = null;
      

        public ICommand PathPointSelectCommand
        {
            get
            {
                if (_PathPointSelectCommand == null)
                {
                    _PathPointSelectCommand = new RelayCommand((p) => OnAdd(p), (p) => CanAdd(p));
                }

                return _PathPointSelectCommand;
            }
        }

        private bool CanAdd(object parameter)
        {
            if (Parent == null)
                return false;
            PathPointNode node = parameter as PathPointNode;
            if (node != null)
            {
                if (node.DirectionType == PathPointNode.TypeDirection.IN)
                    return false;
            }
            return true;
        }

       

        private void OnAdd(object parameter)
        {
            PathPointNode node = parameter as PathPointNode;

            if(node != null)
            {
                if (node.MyPath == null)
                    node.MyPath = Parent.CreatePath();
                Parent.StartPath(this, ref node);
            }
        }
        #endregion

        #region PathPointEnterCommand
        RelayCommand _PathPointEnterCommand = null;
        public ICommand PathPointEnterCommand
        {
            get
            {
                if (_PathPointEnterCommand == null)
                {
                    _PathPointEnterCommand = new RelayCommand((p) => OnEnter(p), (p) => CanEnter(p));
                }

                return _PathPointEnterCommand;
            }
        }

        private bool CanEnter(object parameter)
        {
            if (Parent == null)
                return false;
            return true;
        }

        private void OnEnter(object parameter)
        {
            PathPointNode node = parameter as PathPointNode;

            if (node != null)
            {
                Parent.EnterSequence(this,node);
            }
        }
        #endregion

        #region PathPointLeaveCommand
        RelayCommand _PathPointLeaveCommand = null;
        public ICommand PathPointLeaveCommand
        {
            get
            {
                if (_PathPointLeaveCommand == null)
                {
                    _PathPointLeaveCommand = new RelayCommand((p) => OnLeave(p), (p) => CanLeave(p));
                }

                return _PathPointLeaveCommand;
            }
        }

        private bool CanLeave(object parameter)
        {
            if (Parent == null)
                return false;
            return true;
        }

        private void OnLeave(object parameter)
        {
            PathPointNode node = parameter as PathPointNode;

            if (node != null)
            {
                Parent.LeaveSequence(node);
            }
        }
        #endregion




        internal void reset()
        {
            foreach (RakunValueNodeViewModel values in ModuleValues)
            {
                values.resetValueName();
            }
        }
    }
}
