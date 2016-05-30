using AvalonDock.MVVMTestApp;
using RakunWin32.Logic.Model;
using RakunWin32.TabCommander;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RakunWin32.Logic
{
    class RakunNodeManager : ViewModelBase
    {
        public ObservableCollection<RakunNodeBase> ReaderList_ = new ObservableCollection<RakunNodeBase>();

        public ObservableCollection<RakunNodeBase> ReaderList
        {
            get
            {
                return ReaderList_;
            }
            set
            {
                ReaderList_ = value;
            }
        }

        RakunNodeStarting _startingNode = new RakunNodeStarting();

        public RakunNodeInput inputNode;

        public RakunNodeStarting startingNode
        {
            get
            {
                return _startingNode;
            }
        }


        public void Initialization()
        {

            ReaderList.Clear();

            string filePath = (AppDomain.CurrentDomain.BaseDirectory) + @"\obj";

            ReaderList.Add(new RakunNodeFor());

            ReaderList.Add(new RakunNodeValue() { ModuleName = "HIGH" });
            ReaderList.Add(new RakunNodeValue() { ModuleName = "LOW" });
            
                if (System.IO.Directory.Exists(filePath) == false)
                {
                    System.IO.Directory.CreateDirectory(filePath);
                }

                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(filePath);

                foreach (System.IO.FileInfo f in di.GetFiles())
                {
                    if (System.IO.Path.GetExtension(f.FullName) == ".rkn")
                    {
                        AddRakunReader(f.FullName);
                    }
                }
                RaisePropertyChanged("ReaderList");
          

            //TestApplacation();
           
        }

        public void AddRakunReader(string path)
        {
            if (System.IO.Path.GetFileNameWithoutExtension(path) == "IF Equal")
            {
                System.IO.StreamReader file = new System.IO.StreamReader(path);

                RakunNodeIf reader = new RakunNodeIf();
                reader.ModuleName = System.IO.Path.GetFileNameWithoutExtension(path);
                reader.readXML(file.ReadToEnd());
                ReaderList.Add(reader);

                file.Close();
            }
            else if (System.IO.Path.GetFileNameWithoutExtension(path) == "IF Smaller")
            {
                System.IO.StreamReader file = new System.IO.StreamReader(path);

                RakunNodeIf reader = new RakunNodeIf();
                reader.ModuleName = System.IO.Path.GetFileNameWithoutExtension(path);
                reader.readXML(file.ReadToEnd());
                ReaderList.Add(reader);

                file.Close();
            }
            else if (System.IO.Path.GetFileNameWithoutExtension(path) == "IF Bigger")
            {
                System.IO.StreamReader file = new System.IO.StreamReader(path);

                RakunNodeIf reader = new RakunNodeIf();
                reader.ModuleName = System.IO.Path.GetFileNameWithoutExtension(path);
                reader.readXML(file.ReadToEnd());
                ReaderList.Add(reader);

                file.Close();
            }
            else if (System.IO.Path.GetFileNameWithoutExtension(path) == "IF Diffrent")
            {
                System.IO.StreamReader file = new System.IO.StreamReader(path);

                RakunNodeIf reader = new RakunNodeIf();
                reader.ModuleName = System.IO.Path.GetFileNameWithoutExtension(path);
                reader.readXML(file.ReadToEnd());
                ReaderList.Add(reader);

                file.Close();
            }
            else if (System.IO.Path.GetFileNameWithoutExtension(path) == "IF Diffrent")
            {
                System.IO.StreamReader file = new System.IO.StreamReader(path);

                RakunNodeIf reader = new RakunNodeIf();
                reader.ModuleName = System.IO.Path.GetFileNameWithoutExtension(path);
                reader.readXML(file.ReadToEnd());
                ReaderList.Add(reader);

                file.Close();
            }
            else if (System.IO.Path.GetFileNameWithoutExtension(path) == "Value")
            {
                System.IO.StreamReader file = new System.IO.StreamReader(path);

                RakunNodeInput reader = new RakunNodeInput();
                reader.ModuleName = System.IO.Path.GetFileNameWithoutExtension(path);
                reader.readXML(file.ReadToEnd());
                ReaderList.Add(reader);
                inputNode = reader;

                file.Close();
            }
            else
            {
                System.IO.StreamReader file = new System.IO.StreamReader(path);

                RakunWin32.Logic.RakunNodeModule reader = new Logic.RakunNodeModule();
                reader.ModuleName = System.IO.Path.GetFileNameWithoutExtension(path);
                reader.readXML(file.ReadToEnd());
                ReaderList.Add(reader);

                file.Close();
            }

            
        }

        public void TestApplacation()
        {
            RakunNodeBase rakun1 = new RakunNodeBase();
            RakunNodeBase rakun2 = new RakunNodeBase();
            foreach (RakunNodeBase node in ReaderList)
            {
                if(node.ModuleName == "JoystickX")
                {
                    rakun1 = node;
                }
                if (node.ModuleName == "JoystickY")
                {
                    rakun2 = node;
                }
            }

            RakunNodeBase rakun = rakun1 + rakun2;

            string ccodewriten = AppDomain.CurrentDomain.BaseDirectory
             + @"\obj\"
             + "testapp"
             + ".c";

            string ccode = rakun.Gen_C_Code();
            System.IO.StreamWriter ccodeWrittingfile = new System.IO.StreamWriter(ccodewriten);
            ccodeWrittingfile.WriteLine(ccode);
            ccodeWrittingfile.Close();            
        }
    }
}
