using AvalonDock.MVVMTestApp;
using RakunWin32.Logic;
using RakunWin32.TabCommander;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace RakunWin32.Views
{
    public class RakunValueNodeViewModel : AvalonDock.MVVMTestApp.ViewModelBase
    {

        private RakunViewerUserControl Parent;
        public RakunNode Module;
        public ModuleView Root;

        private RakunModuleViewModel ModuleViewModle;

        public RakunValueNodeViewModel(RakunNode _Module, ModuleView _Root, RakunViewerUserControl _Parent, RakunModuleViewModel _ModuleViewModle)
        {
            Parent = _Parent;
            Module = _Module;
            Root = _Root;
            ModuleViewModle = _ModuleViewModle;
            ChangedName = ValueName;
        }

        public string ValueName
        {
            get
            {
                return Module.NodeName;
            }
        }
        public string ChangedName = "";

        public int Value
        {
            get;
            set;
        }

        private PathPointNode _Input;
        public PathPointNode Input
        {
            get
            {
                return _Input;
            }
            set
            {
                if(value == null)
                {
                    //_Input.Parent = null;
                    _Input = null;
                }
                else
                {
                    _Input = value;
                    //_Input.Parent = this;
                    
                }
            }
        }
        private PathPointNode _Output;
        public PathPointNode Output
        {
            get
            {
                return _Output;
            }
            set
            {
                if (value == null)
                {
                    
                    //_Output.Parent = null;
                    _Output = null;
                }
                else
                {
                    _Output = value;
                    //_Output.Parent = this;
                }
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
            PathPointNode node = parameter as PathPointNode;
            if (node != null)
            {
                if (node.DirectionType == PathPointNode.TypeDirection.IN)
                {
                    Input = node;
                    return false;
                }
                    

                if (node.DirectionType == PathPointNode.TypeDirection.OUT)
                {
                    Output = node;
                }
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

                Parent.StartPath(ModuleViewModle, ref node);
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
                if (node.DirectionType == PathPointNode.TypeDirection.IN)
                {
                    Input = node;
                }
                else if (node.DirectionType == PathPointNode.TypeDirection.OUT)
                {
                    Output = node;
                }

                Parent.EnterSequence(ModuleViewModle, node);
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


        internal void resetValueName()
        {
            ChangedName = ValueName;
        }
    }
}
