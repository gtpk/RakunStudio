using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Shapes;

namespace RakunWin32.ViewModels.Model
{
    public class RakunPathObject
    {
        public Point StartPosition;
        public Point EndPathPosition;
        private Path _Path;
        public Path Path
        {
            get
            {
                return _Path;
            }
            set
            {
                _Path = value;
            }
        }

        public System.Windows.Visibility Visibility
        {
            get
            {
                return Path.Visibility;
            }
            set
            {
                Path.Visibility = value;
            }
        }

    }
}
