using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RakunWin32.PopupManager
{
    class PopupManager
    {
        private PopupManager()
        {
            //do nothing
        }

        private static PopupManager _instacne = null;

        public static PopupManager GetInstance()
        {
            if (_instacne == null)
            {
                _instacne = new PopupManager();
            }
            return _instacne;
        }

        public void CommandGen( String Command )
        {
            if(Command == "New Project...")
            {
                RakunWizard wizard = new RakunWizard();
                wizard.ShowDialog();
            }
        }


    }
}
