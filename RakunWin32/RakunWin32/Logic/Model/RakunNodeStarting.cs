using RakunWin32.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RakunWin32.TabCommander
{
    class RakunNodeStarting : RakunNodeBase
    {
        public RakunNodeStarting()
        {
            ModuleName = "Starting";
            NodeType = RakunNodeType.Starting;
        }

        public override RakunNodeBase Append(RakunNodeBase c1, RakunNodeBase c2)
        {
            RakunNodeBase output = (RakunNodeBase)c2.Clone();
            return output;
        }

    }
}
