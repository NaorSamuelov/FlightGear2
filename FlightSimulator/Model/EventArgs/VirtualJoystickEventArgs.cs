using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator.Model.EventArgs
{
    public class VirtualJoystickEventArgs
    {
        private double alieron;

        public VirtualJoystickEventArgs()
        {
            alieron = 180;
        }



        public double Aileron
        {
            get
            {
                return alieron;
            }
            set
            {
                alieron = value;
                ClientSingleton.InstanceClient.toSimo("dfsfsfdfsfsd");
            }
        }
        public double Elevator { get; set; }
    }
}
