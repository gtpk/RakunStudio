using RakunWin32.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RakunWin32.TabCommander
{
    class RakunNodeFor : RakunNodeBase
    {
        public RakunNodeFor()
        {
            ModuleName = "FOR";
            NodeType = RakunNodeType.For;
        }
    }
}
