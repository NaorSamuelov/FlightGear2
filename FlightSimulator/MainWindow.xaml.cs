using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Net;
using System.Net.Sockets;
using FlightSimulator.Model;
using FlightSimulator.ViewModels.Windows;
using server.FlightSimulator.Model;

namespace FlightSimulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Client client;
        public MainWindow()
        {
            InitializeComponent();
            //Console.Write("Waiting for a connection... ");
            //InitializeComponent();
            //client = new Client();
            // this.DataContext = new SettingsWindowViewModel(ApplicationSettingsModel.Instance);
            // Client client1 = new Client();
            //client1.connectClient();
            //Server server1 = new Server();
            //server1.connectServer();
        }

        public Client ClientOfProg
        {
            get
            {
                return client;
            }
            set
            {
                client = value;
            }
        }

    }
}