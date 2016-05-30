using RakunWin32;
using RakunWin32.Logic;
using RakunWin32.TabCommander;
using RakunWin32.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using Xceed.Wpf.AvalonDock.Controls;

namespace AvalonDock.MVVMTestApp
{
    class RakunFileViewModel : PaneViewModel
    {
        ObservableCollection<RakunModuleViewModel> _Modules = new ObservableCollection<RakunModuleViewModel>();
        ReadOnlyObservableCollection<RakunModuleViewModel> _readonyModules = null;
        public ReadOnlyObservableCollection<RakunModuleViewModel> Modules
        {
            get
            {
                if (_readonyModules == null)
                    _readonyModules = new ReadOnlyObservableCollection<RakunModuleViewModel>(_Modules);

                return _readonyModules;
            }
        }


       
        

        static ImageSourceConverter ISC = new ImageSourceConverter();
        public RakunFileViewModel(string filePath)
        {
            FilePath = filePath;
            Title = FileName;

            //Set the icon only for open documents (just a test)
            IconSource = ISC.ConvertFromInvariantString(@"pack://application:,,/Images/property-blue.png") as ImageSource;
        }

        public RakunFileViewModel()
        {
            IsDirty = true;
            Title = FileName;
        }

        #region FilePath
        private string _filePath = null;
        public string FilePath
        {
            get { return _filePath; }
            set
            {
                if (_filePath != value)
                {
                    _filePath = value;
                    RaisePropertyChanged("FilePath");
                    RaisePropertyChanged("FileName");
                    RaisePropertyChanged("Title");

                    if (File.Exists(_filePath))
                    {
                        _textContent = File.ReadAllText(_filePath);
                        ContentId = _filePath;
                    }
                }
            }
        }
        #endregion


        public RakunModuleViewModel AddModule(RakunNodeBase Module)
        {

            ModuleView myButton = new ModuleView();
            RakunModuleViewModel NewVM = new RakunModuleViewModel(Module, View, myButton);
            NewVM.SetMother(NewVM);
            _Modules.Add(NewVM);
            View.AddRakunNode(NewVM);
            NewVM.name = NewVM.ModuleInfo.ModuleName + "_" + _Modules.Count + "_";
            return NewVM;
            //Workspace.This.StatusString = ModuleName + " Module Added";
        }

        public void FindNameAndChangedValue(string targetViewModel,string targetname,string chagedName)
        {
            foreach (RakunModuleViewModel model in _Modules)
            {
                if (model.name == targetViewModel)
                {
                    foreach (RakunValueNodeViewModel values in model.ModuleValues)
                    {
                        if (values.ValueName == targetname)
                        {
                            values.ChangedName = chagedName;
                            return;
                        }
                    }
                }
            }
        }

        public void ResetValues()
        {
            foreach (RakunModuleViewModel model in _Modules)
            {
                model.reset();
            }
        }

        public string FileName
        {
            get
            {
                if (FilePath == null)
                {
                    if (Title != null)
                        return Title + (IsDirty ? ".rkn" : "");
                    else
                        return "Noname" + (IsDirty ? "*" : "");
                }
                return System.IO.Path.GetFileName(FilePath) + (IsDirty ? "*" : "");
            }
        }



        #region TextContent

        private string _textContent = string.Empty;
        public string TextContent
        {
            get 
            { 
                return View.BuildArduino();
            }
            set
            {
                if (_textContent != value)
                {
                    _textContent = value;
                    RaisePropertyChanged("TextContent");
                    IsDirty = true;
                }
            }
        }

        #endregion

        #region IsDirty

        private bool _isDirty = false;
        public bool IsDirty
        {
            get { return _isDirty; }
            set
            {
                if (_isDirty != value)
                {
                    _isDirty = value;
                    RaisePropertyChanged("IsDirty");
                    RaisePropertyChanged("FileName");
                }
            }
        }

        #endregion

        #region SaveCommand
        RelayCommand _saveCommand = null;
        public ICommand SaveCommand
        {
            get
            {
                if (_saveCommand == null)
                {
                    _saveCommand = new RelayCommand((p) => OnSave(p), (p) => CanSave(p));
                }

                return _saveCommand;
            }
        }

        private bool CanSave(object parameter)
        {
            return IsDirty;
        }

        public void OnSave(object parameter)
        {
            Workspace.This.Save(this, false);
        }

        #endregion

        #region SaveAsCommand
        RelayCommand _saveAsCommand = null;
        public ICommand SaveAsCommand
        {
            get
            {
                if (_saveAsCommand == null)
                {
                    _saveAsCommand = new RelayCommand((p) => OnSaveAs(p), (p) => CanSaveAs(p));
                }

                return _saveAsCommand;
            }
        }

        private bool CanSaveAs(object parameter)
        {
            return IsDirty;
        }

        private void OnSaveAs(object parameter)
        {
            Workspace.This.Save(this, true);
        }

        #endregion

        #region CloseCommand
        RelayCommand _closeCommand = null;
        public ICommand CloseCommand
        {
            get
            {
                if (_closeCommand == null)
                {
                    _closeCommand = new RelayCommand((p) => OnClose(), (p) => CanClose());
                }

                return _closeCommand;
            }
        }

        private bool CanClose()
        {
            return true;
        }

        private void OnClose()
        {
            Workspace.This.Close(this);
        }
        #endregion

        #region BuildCommand
        RelayCommand _BuildCommand = null;
        public ICommand BuildCommand
        {
            get
            {
                if (_BuildCommand == null)
                {
                    _BuildCommand = new RelayCommand((p) => OnBuild(), (p) => CanBuild());
                }

                return _BuildCommand;
            }
        }

        private bool CanBuild()
        {
            return true;
        }

        private void OnBuild()
        {
            string Resualt_C_Code = View.BuildArduino();

            string filePath = (AppDomain.CurrentDomain.BaseDirectory) + @"\build\build";
            if (System.IO.Directory.Exists(filePath) == false)
            {
                System.IO.Directory.CreateDirectory(filePath);
            }


            string ccodewriten = AppDomain.CurrentDomain.BaseDirectory
             + @"\build\build\"
             + "build"
             + ".ino";

            string ccode = Resualt_C_Code;
            System.IO.StreamWriter ccodeWrittingfile = new System.IO.StreamWriter(ccodewriten);
            ccodeWrittingfile.WriteLine(ccode);
            ccodeWrittingfile.Close();
            //ResetValues();
        }
        #endregion

        #region UploadCommand
        RelayCommand _UploadCommand = null;
        public ICommand UploadCommand
        {
            get
            {
                if (_UploadCommand == null)
                {
                    _UploadCommand = new RelayCommand((p) => OnUpload(), (p) => CanUpload());
                }

                return _UploadCommand;
            }
        }

        private bool CanUpload()
        {
            return true;
        }

        private void OnUpload()
        {
            OnBuild();

            string ccodewriten = AppDomain.CurrentDomain.BaseDirectory
             + @"\build\build\"
             + "build"
             + ".ino";

            FileInfo fileinfo = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + @"\build\build\" + "build.ino");

            if (fileinfo.Exists)
            {
                // 복사
                // true 미설정시 파일이 존재하면 에러 발생
                fileinfo.CopyTo(@"C:\Arduino\_2zo\_2zo.ino", true);
            }
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "CMD.exe";
            startInfo.Arguments = "/C/Arduino" + "/arduino --upload --port COM3 /_2zo/_2zo.ino"; // 절대경로를 포함한 BAT 파일명      
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardInput = true;

            Process ftp = new Process();
            ftp.StartInfo = startInfo;
            ftp.Start();
        }
        #endregion


        public RakunViewerUserControl View = null;
    }
}
