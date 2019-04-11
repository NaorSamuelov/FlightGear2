using FlightSimulator.Model;
using FlightSimulator.Views;
using FlightSimulator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FlightSimulator.ViewModels
{
    class ViewModelMap
    {
        private Client client;
        SettingsWindow setting;
        public ViewModelMap(Client clientGet)
        {
            

            client = clientGet;
        }

        private ICommand _connectCommand;
        public ICommand ConnectCommand
        {
            get
            {
                return _connectCommand ?? (_connectCommand =
                new CommandHandler(() => ConnectFunc()));
            }
        }
        private void ConnectFunc()
        {

            client.connectClient();
        }


        private ICommand _openWindow;
        public ICommand OpenWindow
        {
            get
            {
                return _openWindow ?? (_openWindow =
                new CommandHandler(() => WindowShow()));
            }
        }
        private void WindowShow()
        {
            setting = new SettingsWindow();
            setting.Show();
        }



        private ICommand _paintCommand;
        public ICommand PaintComman
        {
            get
            {
                return _paintCommand ?? (_paintCommand =
                new CommandHandler(() => PaintctFunc()));
            }
        }
        private void PaintctFunc()
        {

        }


    }
}