using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RakunWin32.Logic.Model
{
    class RakunNodeInput: RakunNodeBase
    {
        public RakunNodeInput()
        {
            ModuleName = "Input";
            NodeType = RakunNodeType.Input;
        }
    }
}
