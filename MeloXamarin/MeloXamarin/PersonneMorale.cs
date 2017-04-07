using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_Melo
{
    class PersonneMorale:Broadcaster
    {
        //Attributs 
        private string adresse;
        private ClientRC clientData;
        private string lienMaps;
        private string pseudo;

        



        //Constructeur
        public PersonneMorale(string adresse, string lienMaps, ClientRC clientData, string pseudo):base(clientData, pseudo)
        {
            this.adresse = adresse;
            this.lienMaps = lienMaps;
        }

        //Méthodes
        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public string LienMaps
        {
            get
            {
                return lienMaps;
            }

            set
            {
                lienMaps = value;
            }
        }
    }
}
