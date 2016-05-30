using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;

namespace RakunWin32.ViewModel
{
    class WizardViewModel : ViewModelBase
    {

        public WizardViewModel()
        {
            
        }
        private object m_content;
       

        /// <summary>
        /// Gets the content that is to be displayed in the view
        /// </summary>
        public object Content
        {
            get { return m_content; }
            set
            {
                if (m_content != value)
                {
                    m_content = value;
                    RaisePropertyChanged("Content");
                }
            }
        }

    }
}
