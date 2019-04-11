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
using FlightSimulator.ViewModels;
using FlightSimulator.Model;

namespace FlightSimulator.Views
{
    /// <summary>
    /// Interaction logic for Manual.xaml
    /// </summary>
    public partial class Manual : UserControl
    {
        Client client;
        public Manual()
        {
            /*********לא יוצרים פה client*****/
            client = new Client();
            /********************לא צריך להיות אינקלוד של מודל*****************/
            InitializeComponent();
            this.DataContext = new ViewModelManual();
        }
    }
}