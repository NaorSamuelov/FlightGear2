﻿using FlightSimulator.Model;
using FlightSimulator.ViewModels;
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

namespace FlightSimulator.Views
{
    /// <summary>
    /// Interaction logic for Mapside.xaml
    /// </summary>
    public partial class Mapside : UserControl
    {
        public Mapside()
        {
            Client client = new Client();
            InitializeComponent();
            this.DataContext = new ViewModelMap(client);
        }
    }
}