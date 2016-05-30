using AvalonDock.MVVMTestApp;
using RakunWin32.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RakunWin32.WizardPage.VieModel
{
    class WizardPage : AvalonDock.MVVMTestApp.ViewModelBase
    {
        private object m_content;
        private int m_contentCount;

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

        public ICommand ChangeContentCommand
        {
            get
            {
                return new RelayCommand((p) => Content = new MyContentViewModel(++m_contentCount),null);
            }
        }
    }
}
