using FlightSimulator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace FlightSimulator.ViewModels
{
    class AutoViewModle : BaseNotify
    {
        int counter;
        private AutoViewModle()
        {
            counter = 0;
        }
        public Client client;
        public AutoViewModle(Client clientGet)
        {
            client = clientGet;
        }

        private String commantFromUser;
        public String CommentFromUser
        {
            get
            {
                return commantFromUser;
            }
            set
            {
                commantFromUser = value;
                //color = "Red";
                NotifyPropertyChanged("CommentFromUser");
                NotifyPropertyChanged("ColorCange");
               
            }
        }

        /**
        private Color color;
        public Color ColorCange
        {
            get
            {
                if (commantFromUser == "")
                {
                    color = Colors.White;
                }
                else
                {
                    color = Colors.Red;
                }
                return color;
            }
        }
    */
        private String color;
        public String ColorCange
        {
            get
            {
                if (commantFromUser == "" || counter == 0)
                {
                    counter++;
                    color = "White";
                }
                else
                {
                    color = "Red";
                }
                return color;
            }
        }


        private ICommand _clearCommand;
        public ICommand ClearCommand
        {
            get
            {
                return _clearCommand ?? (_clearCommand =
                new CommandHandler(() => ClickClear()));
            }
        }
        private void ClickClear()
        {

            CommentFromUser = "";
            //color = "White";
            //NotifyPropertyChanged("ColorCange");
        }





        private ICommand _sendCommand;
        public ICommand SendCommand
        {
            get
            {
                return _sendCommand ?? (_sendCommand =
                new CommandHandler(() => ClickSend()));
            }
        }
        private void ClickSend()
        {
            client.toSimo(commantFromUser);
            CommentFromUser = "";
            //color = "White";
            //NotifyPropertyChanged("ColorCange");
        }





        public ICommand WriteCommand
        {
            get
            {
                return _clearCommand ?? (_clearCommand =
                new CommandHandler(() => UserWrite()));
            }
        }
        private void UserWrite()
        {

        }
    }


}