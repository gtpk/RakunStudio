using CppRipper;
using MenuItemWithRadioButtonExample;
using RakunWin32.Logic;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RakunWin32
{
	/// <summary>
	/// Interaction logic for RakunStudio.xaml
	/// </summary>
	public partial class RakunStudio
	{

        public SerialPort SP;
        
		public RakunStudio()
		{
			this.InitializeComponent();

            SP = new SerialPort();
            string[] ports = SerialPort.GetPortNames();
            string[] data = { "7", "8" };
            string[] baud = { "9600", "19200", "38400", "57600", "115200" };


            foreach (string port in ports)
            {
                MenuItemWithRadioButton menu = new MenuItemWithRadioButton();
                menu.Header = port;
                MIPort.Items.Add(menu);
                menu.Click += MenuItemWithRadioButtons_Click;
            }

            foreach (string port in data)
            {
                MenuItemWithRadioButton menu = new MenuItemWithRadioButton();
                menu.Header = port;
                MIDatabit.Items.Add(menu);
                menu.Click += MenuItemWithRadioButtons_Click;
            }

            foreach (string port in baud)
            {
                MenuItemWithRadioButton menu = new MenuItemWithRadioButton();
                menu.Header = port;
                MIBoundrate.Items.Add(menu);
                menu.Click += MenuItemWithRadioButtons_Click;
            }

            setup();

			// Insert code required on object creation below this point.
		}

        string arr = "COM3", arr2 = "8", arr3 = "9600";

        private void MenuItemWithRadioButtons_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            System.Windows.Controls.MenuItem mi = sender as System.Windows.Controls.MenuItem;
            if (mi != null)
            {
                System.Windows.Controls.RadioButton rb = mi.Icon as System.Windows.Controls.RadioButton;
                if (rb != null)
                {
                    rb.IsChecked = true;
                    setup();
                }
            }
        }


        private void setup()
        {
            foreach (MenuItemWithRadioButton port in MIPort.Items)
            {
                if(port.IsChecked)
                {
                    arr = port.Header.ToString();
                    break;
                }
            }
            
            foreach (MenuItemWithRadioButton port in MIDatabit.Items)
            {
                if (port.IsChecked)
                {
                    arr2 = port.Header.ToString();
                    break;
                }
            }
            
            foreach (MenuItemWithRadioButton port in MIBoundrate.Items)
            {
                if (port.IsChecked)
                {
                    arr3 = port.Header.ToString();
                    break;
                }
            }

            setSerialPort(SP, (string)arr, int.Parse(arr3), int.Parse(arr2));
            SP.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SP_DataReceived);

        }

        delegate void UpdateUI();
        public void setSerialPort(SerialPort SP, string port, int baudrate, int data)
        {
           if(SP.IsOpen)
           {
                SP.PortName = port;
                SP.BaudRate = baudrate;
                SP.DataBits = data;
                SP.Parity = Parity.None;
                SP.StopBits = StopBits.One;
                SP.Handshake = Handshake.None;

                SP.Open();
            }
        }

        private void SP_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            this.Dispatcher.Invoke(new Action(new UpdateUI(methodd)));

        }

        public void methodd()
        {
            string str = SP.ReadLine();

            Monitor.Items.Insert(0,str);
        }

    }
}