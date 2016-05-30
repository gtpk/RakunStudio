using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;

namespace RakunWin32
{
	/// <summary>
	/// Interaction logic for RakunWizard.xaml
	/// </summary>
	public partial class RakunWizard
	{
        private int m_nowpage = 0;
        List<UserControl> PageList;


		public RakunWizard()
		{
			this.InitializeComponent();
            
		}

        private void MetroWindow_Initialized(object sender, EventArgs e)
        {
            PageList = new List<UserControl>();
            /*
            StringBuilder output = new StringBuilder();

            string xmlString = System.IO.File.ReadAllText(@"ProjectWizard.xml");


            // Create an XmlReader
            using (XmlReader reader = XmlReader.Create(new StringReader(xmlString)))
            {
                reader.ReadToFollowing("RakunWizard");
                reader.MoveToFirstAttribute();
                string genre = reader.Value;
                output.AppendLine("The genre value: " + genre);

                reader.ReadToFollowing("title");
                output.AppendLine("Content of the title element: " + reader.ReadElementContentAsString());
            }
            */
            PageList.Add(new Welcom());
            PageList.Add(new Interior());

            WizardContents.Content = PageList[m_nowpage];
            FinishButton.IsEnabled = false;
            BackButton.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (m_nowpage < PageList.Count - 1)
            {
                BackButton.IsEnabled = false;
                WizardContents.Content = PageList[++m_nowpage];
            }

            if (m_nowpage >= PageList.Count - 1)
            {
                NextButton.IsEnabled = false;
                FinishButton.IsEnabled = true;
            }
                
            BackButton.IsEnabled = true;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (m_nowpage > 0)
                WizardContents.Content = PageList[--m_nowpage];
            else
            {
                BackButton.IsEnabled = false;
            }
            NextButton.IsEnabled = true;
            FinishButton.IsEnabled = false;
        }

        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
	}
}