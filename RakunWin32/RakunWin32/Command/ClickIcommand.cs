using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RakunWin32.Command
{
    class ClickIcommand : ICommand
    {
        public Action Excuting;

        public ClickIcommand(Action _action)
        {
            Excuting = _action;
        }

        event EventHandler ICommand.CanExecuteChanged
        {
            add
            {
               // throw new NotImplementedException();
            }

            remove
            {
               // throw new NotImplementedException();
            }
        }

        bool ICommand.CanExecute(object parameter)
        {
            // throw new NotImplementedException();
            return true;
        }

        void ICommand.Execute(object parameter)
        {
            if (Excuting != null)
                Excuting();
        }
    }
}
