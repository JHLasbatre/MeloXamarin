using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_Melo
{
    class Panorama : PersonneMorale
    {
        //AUCUN ATTRIBUTS 

        //Constructeur

        public Panorama(string pseudo, ClientRC clientData, string adresse, string lienMaps) : base(pseudo, clientData, adresse, lienMaps)
        {
            this.Pseudo = pseudo;
            this.ClientData = clientData;
            this.Adresse = adresse;
            this.LienMaps = lienMaps;

        }
    }
}
