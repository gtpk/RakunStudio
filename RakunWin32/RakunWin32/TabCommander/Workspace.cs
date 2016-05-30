/************************************************************************

   AvalonDock

   Copyright (C) 2007-2013 Xceed Software Inc.

   This program is provided to you under the terms of the New BSD
   License (BSD) as published at http://avalondock.codeplex.com/license 

   For more features, controls, and fast professional support,
   pick up AvalonDock in Extended WPF Toolkit Plus at http://xceed.com/wpf_toolkit

   Stay informed: follow @datagrid on Twitter or Like facebook.com/datagrids

  **********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Win32;
using System.IO;
using System.Windows;
using Xceed.Wpf.AvalonDock.Layout;
using RakunWin32.ViewModel;
using RakunWin32.Logic;
using CppRipper;
using System.Windows.Media;
using System.Diagnostics;

namespace AvalonDock.MVVMTestApp
{
    class Workspace : ViewModelBase
    {
        //접근 막기
        public Workspace()
        {
            if (_this == null)
                _this = this;

            RM = new RakunNodeManager();
            RM.Initialization();
        }


        static Workspace _this = null;

        public static Workspace This
        {
            get
            { 
                if(_this == null)
                {
                    _this = new Workspace();
                }
                return _this; 
            }
        }
        private RakunNodeManager RM;

        private Color _Statusbar = (Color)ColorConverter.ConvertFromString("#FF3399FF");
        public Color Statusbar
        {
            get
            {
                return _Statusbar;
            }

            set
            {
                _Statusbar = value;
                RaisePropertyChanged("Statusbar");
            }
        }

        private string _StatusString = "Ready";
        public string StatusString
        {
            get
            {
                Workspace.This.Statusbar = (Color)ColorConverter.ConvertFromString("#FF3399FF");
                return _StatusString;
            }

            set
            {
                _StatusString = value;
                RaisePropertyChanged("StatusString");
            }
        }

        public RakunNodeManager RakunManager
        {
            get
            {
                return RM;
            }
        }

        ObservableCollection<RakunFileViewModel> _files = new ObservableCollection<RakunFileViewModel>();
        ReadOnlyObservableCollection<RakunFileViewModel> _readonyFiles = null;
        public ReadOnlyObservableCollection<RakunFileViewModel> Files
        {
            get
            {
                if (_readonyFiles == null)
                    _readonyFiles = new ReadOnlyObservableCollection<RakunFileViewModel>(_files);

                return _readonyFiles;
            }
        }

        ToolViewModel[] _tools = null;

        public IEnumerable<ToolViewModel> Tools
        {
            get
            {
                if (_tools == null)
                    _tools = new ToolViewModel[] { FileStats };
                return _tools;
            }
        }

        FileStatsViewModel _fileStats = null;
        public FileStatsViewModel FileStats
        {
            get
            {
                if (_fileStats == null)
                    _fileStats = new FileStatsViewModel();

                return _fileStats;
            }
        }

        #region OpenCommand
        RelayCommand _openCommand = null;
        public ICommand OpenCommand
        {
            get
            {
                if (_openCommand == null)
                {
                    _openCommand = new RelayCommand((p) => OnOpen(p), (p) => CanOpen(p));
                }

                return _openCommand;
            }
        }

        private bool CanOpen(object parameter)
        {
            return true;
        }

        private void OnOpen(object parameter)
        {
            var dlg = new OpenFileDialog();
            if (dlg.ShowDialog().GetValueOrDefault())
            {
                var RakunFileViewModel = Open(dlg.FileName);
                ActiveDocument = RakunFileViewModel;
            }

            StatusString = "File Open Successfuly";
        }

        public RakunFileViewModel Open(string filepath)
        {
            var RakunFileViewModel = _files.FirstOrDefault(fm => fm.FilePath == filepath);
            if (RakunFileViewModel != null)
                return RakunFileViewModel;

            RakunFileViewModel = new RakunFileViewModel(filepath);
            _files.Add(RakunFileViewModel);
            return RakunFileViewModel;
        }

        #endregion 

        #region AddModuleCommand
        RelayCommand _AddModuleCommand = null;
        public ICommand AddModuleCommand
        {
            get
            {
                if (_AddModuleCommand == null)
                {
                    _AddModuleCommand = new RelayCommand((p) => OnAddModuleOpen(p), (p) => CanAddModuleOpen(p));
                }

                return _AddModuleCommand;
            }
        }
        private bool CanAddModuleOpen(object parameter)
        {
            return true;
        }

        private void OnAddModuleOpen(object parameter)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Arduino Files|*.ino";
            openFileDialog1.Title = "Select a Arduino File";
            if (openFileDialog1.ShowDialog().GetValueOrDefault())
            {
                System.IO.StreamReader sr = new
                  System.IO.StreamReader(openFileDialog1.FileName);

                ParseFile(openFileDialog1);

                StatusString = openFileDialog1.FileName + " Module Added";
            }
            else
            {
                StatusString = "File Open Canceled";
            }
        }

        public void ParseFile(OpenFileDialog openFileDialog1)
        {
            CppStructuralOutput output = new CppStructuralOutput();
            CppFileParser parser = new CppFileParser(output, openFileDialog1.FileName);

            //Folder Create
            string filePath = (AppDomain.CurrentDomain.BaseDirectory) + @"\obj";

            if (System.IO.Directory.Exists(filePath) == false)
            {
                System.IO.Directory.CreateDirectory(filePath);
            }

            //Gen rankun file
            string writen = AppDomain.CurrentDomain.BaseDirectory
                + @"\obj\"
                + System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName)
                + ".rkn";

            System.IO.StreamWriter writtingfile = new System.IO.StreamWriter(writen);
            string input = "";
            foreach (string line in output.GetStrings())
            {
                writtingfile.WriteLine(line);
                input += line + "\n";
            }
            writtingfile.Close();

            RM.Initialization();

        }

        #endregion

        #region NewCommand
        RelayCommand _newCommand = null;
        public ICommand NewCommand
        {
            get
            {
                if (_newCommand == null)
                {
                    _newCommand = new RelayCommand((p) => OnNew(p), (p) => CanNew(p));
                }

                return _newCommand;
            }
        }

        private bool CanNew(object parameter)
        {
            return true;
        }

        private int countingfiledefalt = 1;

        private void OnNew(object parameter)
        {
            RakunFileViewModel _newDocument = new RakunFileViewModel();
            _newDocument.Title = "rakun" + countingfiledefalt.ToString();
            countingfiledefalt++;
            _files.Add(_newDocument);
            ActiveDocument = _files.Last();
            //ActiveDocument = _newDocument;

            StatusString = "File Create Successfuly";
        }

        #endregion 

       

        #region ActiveDocument

        private RakunFileViewModel _activeDocument = null;
        public RakunFileViewModel ActiveDocument
        {
            get { return _activeDocument; }
            set
            {
                if (_activeDocument != value)
                {
                    _activeDocument = value;
                    RaisePropertyChanged("ActiveDocument");
                    if (ActiveDocumentChanged != null)
                        ActiveDocumentChanged(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler ActiveDocumentChanged;

        #endregion


        internal void Close(RakunFileViewModel fileToClose)
        {
            if (fileToClose.IsDirty)
            {
                var res = MessageBox.Show(string.Format("Save changes for file '{0}'?", fileToClose.FileName), "AvalonDock Test App", MessageBoxButton.YesNoCancel);
                if (res == MessageBoxResult.Cancel)
                    return;
                if (res == MessageBoxResult.Yes)
                {
                    Save(fileToClose);
                }
            }

            _files.Remove(fileToClose);

            StatusString = fileToClose.FileName + " Closed";
        }

        internal void Save(RakunFileViewModel fileToSave, bool saveAsFlag = false)
        {
            if (fileToSave.FilePath == null || saveAsFlag)
            {
                var dlg = new SaveFileDialog();
                dlg.Filter = "Arduino Files|*.ino";
                dlg.Title = "Save Arduino File";
                if (dlg.ShowDialog().GetValueOrDefault())
                    fileToSave.FilePath = dlg.FileName;
            }

            File.WriteAllText(fileToSave.FilePath, fileToSave.TextContent);
            ActiveDocument.IsDirty = false;


            StatusString = fileToSave.FileName + " Saved";
        }




        internal void Save(FileViewModel fileViewModel, bool p)
        {
            throw new NotImplementedException();
        }
    }
}
