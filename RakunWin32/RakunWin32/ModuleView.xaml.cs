using RakunWin32.TabCommander;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RakunWin32
{
	/// <summary>
	/// Interaction logic for ModuleView.xaml
	/// </summary>
	public partial class ModuleView : UserControl
	{
		public ModuleView()
		{
			this.InitializeComponent();
		}

		private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
		{
            RakunModuleViewModel context = this.DataContext as RakunModuleViewModel;
            context.input = tbinput.Text;
		}
	}
}