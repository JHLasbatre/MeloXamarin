using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_Melo
{
    class PersonnePhysique:Broadcaster
    {
        //Attributs
        private int range;

        //Constructeur
        public PersonnePhysique(int range, string pseudo, ClientRC clientData) : base(clientData, pseudo)
        {
            this.range = range;
        }

        //Méthodes
        public int Range
        {
            get
            {
                return range;
            }

            set
            {
                range = value;
            }
        }
    }
}
