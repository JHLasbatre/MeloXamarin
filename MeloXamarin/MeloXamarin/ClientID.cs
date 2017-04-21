using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_Melo
{
    class ClientID
    {
        private int id;


        //Constructeurs
        public ClientID(int id)
        {
            this.Id = id;
        }

        //Méthodes
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}
