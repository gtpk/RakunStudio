using AvalonDock.MVVMTestApp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RakunWin32.Logic
{
    public enum RakunType
    {
        ValueName,
        FunctionName,
        FunctionUse,
        IFDeclear,
        ElseDeclear,
    };
    public class RakunNode : ViewModelBase, ICloneable
    {

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        private ObservableCollection<RakunNode> _Rakunlist = new ObservableCollection<RakunNode>();

        public ObservableCollection<RakunNode> Rakunlist
        {
            get
            {
                return _Rakunlist;
            }
            set
            {
                _Rakunlist = value;
            }
        }

        public string NodeName
        {
            get;
            set;
        }

        private string _Changedname;
        public string Changedname
        {
            get
            {
                if (_Changedname == null)
                {
                    return NodeName;
                }
                return _Changedname;
            }

            set
            {
                _Changedname = value;
            }
        }

        public RakunType type
        {
            get;
            set;
        }
        public XmlNode ValueDeclear;
        public XmlNode declaration_list;

        public XmlNode setupfunction;
        public XmlNode loopfunction;

        public XmlNode IFTrueDeclear;
        public XmlNode IFFalseDeclear;

        public RakunNode readXML(XmlNode node)
        {
            if (node.Attributes != null)
                if (node.Attributes["name"].Value == "declaration_list" && declaration_list == null)
                    declaration_list = node;

            foreach (XmlNode xn in node)
            {
                if (xn.Attributes != null)
                {
                    if (xn.Attributes["name"].Value == "declaration_content")
                    {
                        string identifier = xn.InnerText;
      
                        //라쿤 노드 만들기
                        CreateRNode(xn, node);
                    }

                    
                }

               

                readXML(xn);
            }
            return this;
        }

        public void CreateRNode(XmlNode node,XmlNode Upper)
        {
            int count = 0;
            string savedName = string.Empty;
            foreach (XmlNode xn in node)
            {
                if (xn.Attributes != null)
                {
                    if (xn.Attributes["name"].Value == "node")
                    {
                        if (count < 2)
                        {
                            if (GetnodeName(xn) == "identifier")
                            {
                                count++;
                                if (count == 2)
                                    savedName = xn.InnerText;
                            }
                            else if (GetnodeName(xn) == "symbol")
                            {
                                //Serial.begin() <-- 요러건거가 id 두개로 인식됨
                                count = 0;
                            }
                        }
                        else if (GetnodeName(xn) == "paran_group")
                        {
                            count++;
                        }
                        else if (GetnodeName(xn) == "brace_group")
                        {
                            
                            RakunNode _rnode = new RakunNode();
                            _rnode.NodeName = savedName.Trim();
                            _rnode.type = RakunType.FunctionName;
                            //Rakunlist.Add(_rnode);
                            
                            count = 0;
                            savedName = "";

                            
                        }
                        else if (xn.Attributes["name"].Value == "semicolon")
                        {
                            count = 0;
                            savedName = "";
                        }
                        else
                        {
                            RakunNode _rnode = new RakunNode();
                            _rnode.NodeName = savedName.Trim();
                            _rnode.type = RakunType.ValueName;
                            _rnode.ValueDeclear = Upper;
                            Rakunlist.Add(_rnode);
                            count = 0;
                            savedName = "";
                        }
                    }
                }
            }

            if(count == 2)
            {
                RakunNode _rnode = new RakunNode();
                _rnode.NodeName = savedName.Trim();
                _rnode.type = RakunType.ValueName;
                Rakunlist.Add(_rnode);
                count = 0;
                savedName = "";
            }
        }

        ////if(savedName == "setup")
        public XmlNode GetfindFunctionNode(string fname , XmlNode node)
        {
            int count = 0;
            string savedName = string.Empty;
            foreach (XmlNode xn in node)
            {
                if (xn.Attributes != null)
                {
                    if (xn.Attributes["name"].Value == "node")
                    {
                        if (count < 2)
                        {
                            if (GetnodeName(xn) == "identifier")
                            {
                                
                                if (xn.InnerText.Trim() == fname)
                                {
                                    if (fname == "if" || fname == "else")
                                    {
                                        count++;
                                        savedName = xn.InnerText.Trim();
                                    }
                                }
                               
                                count++;
                                if (count == 2)
                                    savedName = xn.InnerText.Trim();
                            }
                            else if (GetnodeName(xn) == "symbol")
                            {
                                count = 0;
                            }
                        }
                        else if (GetnodeName(xn) == "paran_group")
                        {
                            count++;
                        }
                        else if (GetnodeName(xn) == "brace_group")
                        {
                            if (savedName == fname)
                            {
                                if( GetFunctionDcelear(xn) != null)
                                {
                                    return GetFunctionDcelear(xn);
                                }
                            }
                            count = 0;
                        }
                        else if (xn.Attributes["name"].Value == "semicolon")
                        {
                            count = 0;
                            savedName = "";
                        }
                    }
                }
                XmlNode re = GetfindFunctionNode(fname, xn);
                if (re != null)
                    return re;
            }
            return null;
        }
        public XmlNode GetFunctionDcelear(XmlNode node)
        {
            foreach (XmlNode xn in node)
            {
                if (xn.Attributes["name"].Value == "declaration_list")
                {
                    return xn;
                }
                else
                {
                    XmlNode re = GetFunctionDcelear(xn);
                    if (re != null)
                        return re;
                }
            }
            return null;
        }

        static public XmlNode addFunctionDcelear( ref XmlNode innode, XmlNode node,bool isFront = false,bool Declearuse = false)
        {
            if (node == null)
                return null;
            XmlNode re = null;

            if (innode.ChildNodes.Count == 0)
            {
                if (node.ChildNodes.Count != 0)
                {
                    if (Declearuse == false)
                    {
                        foreach (XmlNode ixn in node.ChildNodes)
                        {
                            //necessary for crossing XmlDocument contexts
                            XmlNode importNode = innode.OwnerDocument.ImportNode(ixn.CloneNode(true), true);
                            if (isFront == false)
                                innode.AppendChild(importNode);
                            else
                                innode.InsertBefore(importNode, innode);
                        }
                        return innode;
                        
                    }
                    else
                    {

                       
                        XmlNode importNode = innode.OwnerDocument.ImportNode(node.CloneNode(true), true);
                        if (isFront == false)
                            innode.AppendChild(importNode);
                        else
                            innode.InsertBefore(importNode, innode);
                        return innode;
                        
                    }
                
                }
            }

            for (int i = 0; i < innode.ChildNodes.Count; i++)
            //foreach (XmlNode xn in innode)
            {
                XmlNode xn = innode.ChildNodes[i];
                if (xn == null)
                {
                    continue;
                }
                else if (xn.Attributes == null)
                {
                    continue;
                }
                if (Declearuse == false)
                {

                    if (xn.Attributes["name"].Value == "declaration_content")
                    {
                        foreach (XmlNode ixn in node.ChildNodes)
                        {
                            //necessary for crossing XmlDocument contexts
                            XmlNode importNode = innode.OwnerDocument.ImportNode(ixn.CloneNode(true), true);
                            if (isFront == false)
                                innode.AppendChild(importNode);
                            else
                                innode.InsertBefore(importNode, xn);
                        }
                        return xn;
                    }
                }
                else 
                {

                    if (xn.Attributes["name"].Value == "declaration")
                    {
                        XmlNode importNode = innode.OwnerDocument.ImportNode(node.CloneNode(true), true);
                        if (isFront == false)
                            innode.AppendChild(importNode);
                        else
                            innode.InsertBefore(importNode, xn);
                        return xn;
                    }
                }
                
                if (re == null)
                {
                    re = addFunctionDcelear(ref xn, node, isFront);
                }
                else
                {
                    return re;
                }
            }
            return null;
        }

        static public XmlNode addForceFunctionDcelear(ref XmlNode innode, XmlNode node)
        {
            if (node == null)
                return null;
            XmlNode re = null;
            for (int i = 0; i < node.ChildNodes.Count; i++)
            //foreach (XmlNode xn in innode)
            {
                XmlNode xn = innode.ChildNodes[i];
                if (xn == null)
                {
                    if(i == 0)
                    {
                        foreach (XmlNode ixn in node.ChildNodes)
                        {
                            //necessary for crossing XmlDocument contexts
                            XmlNode importNode = innode.OwnerDocument.ImportNode(ixn.CloneNode(true), true);
                            innode.AppendChild(importNode);
                        }
                        return xn;
                    }
                    continue;
                }
                else if (xn.Attributes == null)
                {
                    continue;
                }
                if (xn.Attributes["name"].Value == "declaration")
                {
                    foreach (XmlNode ixn in node.ChildNodes)
                    {
                        //necessary for crossing XmlDocument contexts
                        XmlNode importNode = xn.OwnerDocument.ImportNode(ixn.CloneNode(true), true);
                        innode.AppendChild(importNode);
                    }
                    return xn;
                }

                if (re == null)
                {
                    re = addFunctionDcelear(ref xn, node);
                }
                else
                {
                    return re;
                }
            }

            return null;
        }

        public string GetnodeName(XmlNode node)
        {
            foreach (XmlNode xn in node)
            {
                return xn.Attributes["name"].Value;
            }
            return "";
        }

        private void Stringfactory(XmlNode node)
        {
            foreach (XmlNode xn in node)
            {
                if (xn.Attributes["name"].Value == "declaration_content")
                {

                }

            }
        }


        public void replace(XmlNode node,string oldname, string newname)
        {
            foreach (XmlNode xn in node)
            {
                if (xn.Attributes != null)
                {
                    if (xn.Attributes["name"].Value == "identifier")
                    {
                        if (xn.InnerText.Trim() == oldname)
                        {
                            xn.InnerText = newname;
                        }
                            
                    }
                }
                replace(xn,oldname,newname);
            }
        }


       
    }
}
