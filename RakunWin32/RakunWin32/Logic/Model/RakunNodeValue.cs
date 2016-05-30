using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RakunWin32.Logic.Model
{
    class RakunNodeValue: RakunNodeBase
    {
        public RakunNodeValue()
        {
            ModuleName = "Value";
            NodeType = RakunNodeType.Value;
        }
    }
}
