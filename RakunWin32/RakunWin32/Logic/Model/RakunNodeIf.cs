using RakunWin32.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace RakunWin32.TabCommander
{
    public class RakunNodeIf: RakunNodeBase
    {
        public RakunNodeIf()
        {
            ModuleName = "IF";
            NodeType = RakunNodeType.If;
        }

        public RakunNodeBase AddIfTrue(RakunNodeBase truenode, RakunNodeBase falsenode)
        {
            RakunNodeBase output = this as RakunNodeBase;

            if (truenode.rootNode != null)
            {
                //foreach (RakunNode RNode in truenode._rootNode.Rakunlist)
                //{
                //    RakunNode.addFunctionDcelear(ref c1._rootNode.declaration_list, RNode.ValueDeclear, true, true);
                //    //break
                //}

                foreach (RakunNode RNode in truenode.rootNode.Rakunlist)
                {
                    RakunNode.addFunctionDcelear(ref output.rootNode.declaration_list, RNode.ValueDeclear,true,true);
                }
            }
            
            if (falsenode.rootNode != null)
            {
                foreach (RakunNode RNode in falsenode.rootNode.Rakunlist)
                {
                    RakunNode.addFunctionDcelear(ref output.rootNode.declaration_list, RNode.ValueDeclear, true, true);
                }
            }

            if (truenode.rootNode != null)
            {
                RakunNode.addForceFunctionDcelear(ref output.rootNode.setupfunction, truenode.rootNode.setupfunction);
                RakunNode.addForceFunctionDcelear(ref output.rootNode.IFTrueDeclear, truenode.rootNode.loopfunction);
            }

            if (falsenode.rootNode != null)
            {
                RakunNode.addForceFunctionDcelear(ref output.rootNode.setupfunction, falsenode.rootNode.setupfunction);
                RakunNode.addForceFunctionDcelear(ref output.rootNode.IFFalseDeclear, falsenode.rootNode.loopfunction);
            }

            return output;//this.Append(this, output);
        }

    }
}
