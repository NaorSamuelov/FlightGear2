using FlightSimulator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FlightSimulator.ViewModels
{
    class ViewModelManual : BaseNotify
    {
        Client client;
        public ViewModelManual()
        {
            client = ClientSingleton.InstanceClient;
        }

        /**
        double valRudder = 0;
        private ICommand _changeRudder;
        public ICommand ChangeRudder
        {
            get
            {
                return _changeRudder ?? (_changeRudder =
                new CommandHandler(() => UpdateRudder()));
            }
        }
        private void UpdateRudder()
        {
            client.setInfo("dssdsds", valRudder);
        }
    */

        private double _changeRudder;
        public double ChangeRudder
        {
            get
            {
                return _changeRudder;
            }
            set
            {
                _changeRudder = value;
                client.setInfo("dssdsds", _changeRudder);
                NotifyPropertyChanged("ChangeRudder");
            }
        }

        private double _changeTorttel;
        public double ChangeTorttel
        {
            get
            {
                return _changeTorttel;
            }
            set
            {
                _changeTorttel = value;
                client.setInfo("dssdsds", _changeTorttel);
                NotifyPropertyChanged("ChangeTortte");
            }
        }
    }
}