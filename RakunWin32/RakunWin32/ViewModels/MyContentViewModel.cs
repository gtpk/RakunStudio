using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace RakunWin32.ViewModel
{
    /// <summary>
	/// Represents the rendered content with a number and a random background
	/// </summary>
	public class MyContentViewModel : ViewModelBase
    {
        public MyContentViewModel(int number)
        {
            MyCount = number;
        }

        public Brush Fill
        {
            get
            {
                Random r = new Random();
                return new SolidColorBrush(Color.FromRgb((byte)r.Next(100, 255), (byte)r.Next(100, 255), (byte)r.Next(100, 255)));
            }
        }

        public int MyCount { get; private set; }
    }
}
