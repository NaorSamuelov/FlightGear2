using FlightSimulator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator
{
    class ClientSingleton
    {
        private static Client m_client = null;
        public static Client InstanceClient
        {
            get
            {
                if (m_client == null)
                {
                    m_client = new Client();
                }
                return m_client;
            }
        }
    }

}

