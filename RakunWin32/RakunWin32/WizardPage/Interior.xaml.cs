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
	/// Interaction logic for Interior.xaml
	/// </summary>
	public partial class Interior : UserControl
	{
		public Interior()
		{
			this.InitializeComponent();
		}

        private string CustomPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

		private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
		{
            TBProjectName.Text = "RakunProject1";
            TBProjectFolder.Text = CustomPath + "\\" + TBProjectName.Text;
            
		}

		private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
            System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = fbd.ShowDialog();
            if (fbd.SelectedPath == "")
                return;
            CustomPath = fbd.SelectedPath;
            TBProjectFolder.Text = CustomPath + "\\" + TBProjectName.Text;
		}

		private void TBProjectName_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
		{
            TBProjectFolder.Text = CustomPath + "\\" + TBProjectName.Text;
		}
	}
}