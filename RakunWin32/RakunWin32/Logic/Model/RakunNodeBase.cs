using AvalonDock.MVVMTestApp;
using RakunWin32.TabCommander;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Xml;

namespace RakunWin32.Logic
{
    public class RakunNodeBase : ViewModelBase, ICloneable
    {
        private RakunNode _rootNode;

        public RakunNode rootNode
        {
            get
            {
                return _rootNode;
                /*
                if (_rootNode == null)
                    return null;

                return _rootNode.Clone() as RakunNode;
                */
            }
            set
            {
                _rootNode = value;
            }
        }

        public enum RakunNodeType { Starting, Module,If ,For, Value, Input};

        public RakunNodeType NodeType = RakunNodeType.Module;
        public string ModuleName { get; set; }

        public object Clone()
        {
            RakunNodeBase obj = this.MemberwiseClone() as RakunNodeBase;
            if (xml == null)
                return obj;

            obj.readXML(this.xml.InnerXml);

            return obj;
        }

        public XmlDocument xml;
        public XmlNode xnList;



        public virtual RakunNode readXML(string fileinput)
        {
            _rootNode = new RakunNode();

            xml = new XmlDocument(); // XmlDocument 생성
            xml.LoadXml(fileinput);
            xnList = xml.FirstChild; //접근할 노드

            foreach (XmlNode xn in xnList)
            {
                _rootNode.readXML(xn);
            }

            foreach (XmlNode xn in xml.FirstChild)
            {

                if (_rootNode.setupfunction == null)
                    _rootNode.setupfunction = _rootNode.GetfindFunctionNode("setup", xn);

                if (_rootNode.loopfunction == null)
                    _rootNode.loopfunction = _rootNode.GetfindFunctionNode("loop", xn);

                if (_rootNode.IFTrueDeclear == null)
                    _rootNode.IFTrueDeclear = _rootNode.GetfindFunctionNode("if", xn);

                if (_rootNode.IFFalseDeclear == null)
                    _rootNode.IFFalseDeclear = _rootNode.GetfindFunctionNode("else", xn);
            }

            //ModuleName = System.IO.Path.GetFileNameWithoutExtension(fileinput);

            //GenRakunValue();

            return _rootNode;
        }


        /*
        public static RakunNodeModule operator +(RakunNodeModule c1, RakunNodeModule c2)
        {
            

            
        }*/

        public string Gen_C_Code()
        {
            string outputstring = string.Empty;
            if (xnList == null)
                return "";
            foreach (XmlNode xn in xnList)
            {
                outputstring += Gen_C_Code(xn,0);
            }
            return outputstring;
        }

        public string Gen_C_Code(XmlNode node,int level)
        {
            
            string outputstring = string.Empty;

           

            foreach (XmlNode xn in node)
            {
                if (xn.Attributes == null)
                {

                    string temp = node.InnerText.Trim();
                    outputstring += temp;
                    if (temp == "int"
                        || temp == "char"
                        || temp == "void"
                        || temp == "short"
                        || temp == "float"
                        || temp == "double"
                        || temp == "unsigend")
                        outputstring += " ";

                    continue;
                }
                //
                if (xn.Attributes["name"].Value == "semicolon")
                {
                    outputstring += Gen_C_Code(xn, level) + "\n";
                    for(int i = 0 ; i < level ; i ++)
                        outputstring += "    ";
                }
                else if (xn.Attributes["name"].Value == "paran_group")
                {
                    outputstring += "(";
                    outputstring += Gen_C_Code(xn, level);
                    outputstring += ")";
                }
                else if (xn.Attributes["name"].Value == "brace_group")
                {
                    outputstring += "\n";

                    for (int i = 0; i < level; i++)
                        outputstring += "    ";

                    outputstring += "{\n";
                    for (int i = 0; i < level+ 1; i++)
                        outputstring += "    ";

                    outputstring += Gen_C_Code(xn, level+1) + "\n";

                    for (int i = 0; i < level; i++)
                        outputstring += "    ";

                    outputstring += "}\n";

                    for (int i = 0; i < level; i++)
                        outputstring += "    ";

                }
                else if (xn.Attributes["name"].Value == "octal_literal")
                {
                    outputstring += "0";
                }
                else
                {
                    outputstring += Gen_C_Code(xn, level);
                }
            }
            //if( node.ChildNodes.Count == 0)

            return outputstring;
        }

        #region AddCommand
        RelayCommand _AddModuleCommand = null;
        public ICommand AddModuleCommand
        {
            get
            {
                if (_AddModuleCommand == null)
                {
                    _AddModuleCommand = new RelayCommand((p) => OnAdd(p), (p) => CanAdd(p));
                }

                return _AddModuleCommand;
            }
        }

        private bool CanAdd(object parameter)
        {
            if (Workspace.This.ActiveDocument == null)
                return false;

            return true;
        }

        public RakunModuleViewModel MotherVM;

        public void OnAdd(object parameter)
        {

            MotherVM = Workspace.This.ActiveDocument.AddModule(this);
            Workspace.This.StatusString = ModuleName + " Module Added";
            MotherVM._ModuleInfo.MotherVM = MotherVM;
            MotherVM._ModuleInfo.GenRakunValue(MotherVM.name.Replace(" ", ""), 0);
        }

        public virtual RakunNodeBase Append(RakunNodeBase c1original, RakunNodeBase c2original)
        {
            RakunNodeBase c2 = c2original.Clone() as RakunNodeBase;
            
            RakunNodeBase c1 = (RakunNodeBase)c1original.Clone();

            if (c1._rootNode == null)
                return c2.Clone() as RakunNodeBase;
            if (c2._rootNode == null) 
                return c2.Clone() as RakunNodeBase;


            if (c1._rootNode.setupfunction == c2._rootNode.setupfunction)
                return c2.Clone() as RakunNodeBase;

            int value = c1.GenRakunValue(0);
            c2.GenRakunValue(value);

            foreach(RakunNode RNode in c2._rootNode.Rakunlist)
            {
                RakunNode.addFunctionDcelear(ref c1._rootNode.declaration_list, RNode.ValueDeclear, true,true);
                //break;
            }

            RakunNode.addFunctionDcelear(ref c1._rootNode.setupfunction, c2._rootNode.setupfunction);
            RakunNode.addFunctionDcelear(ref c1._rootNode.loopfunction, c2._rootNode.loopfunction);

            
            return c1;
        }

        public static RakunNodeBase operator +(RakunNodeBase c1, RakunNodeBase c2)
        {
            return (c1.Clone() as RakunNodeBase).Append(c1, c2);
        }

        #endregion

        public virtual int GenRakunValue(string _name,int value)
        {
            if (_rootNode == null)
                return value;

            string name = _name;
            int counting = value;
            foreach (RakunNode xn in _rootNode.Rakunlist)
            {
                if (xn.type == RakunType.ValueName)
                {
                    _rootNode.replace(xnList, xn.Changedname, name + counting);
                    Workspace.This.ActiveDocument.FindNameAndChangedValue(MotherVM.name, xn.NodeName, name + counting);
                    xn.Changedname = name + counting;
                    counting++;
                }

            }
            return counting;

        }
        public virtual int GenRakunValue(int value)
        {         
            //disable
            return 0;
            /*
            if (_rootNode == null)
                return value;

            const string name = "localvalue";
            int counting = value;
            foreach (RakunNode xn in _rootNode.Rakunlist)
            {
                if (xn.type == RakunType.ValueName)
                {
                    _rootNode.replace(xnList, xn.Changedname, name + counting);
                    Workspace.This.ActiveDocument.FindNameAndChangedValue(MotherVM.name, xn.NodeName, name + counting);
                    //xn.Changedname = name + counting;
                    counting++;
                }

            }
            return counting;
            */
        }
    }
}
