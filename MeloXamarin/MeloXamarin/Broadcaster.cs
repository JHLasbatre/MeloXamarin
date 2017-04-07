using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_Melo
{
    class Broadcaster
    {
        //Attributs
        private ClientRC clientData;
        private string pseudo;

        //Constructeurs
        public Broadcaster(ClientRC clientData, string pseudo)
        {
            this.pseudo = pseudo;
            this.clientData = clientData;
        }

        //Méthodes
        public ClientRC ClientData
        {
            get
            {
                return clientData;
            }

            set
            {
                clientData = value;
            }
        }

        public string Pseudo
        {
            get
            {
                return pseudo;
            }

            set
            {
                pseudo = value;
            }
        }
    }
}
