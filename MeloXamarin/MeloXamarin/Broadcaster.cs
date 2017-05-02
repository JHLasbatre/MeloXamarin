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
        private int userLikes;

        public Broadcaster(ClientRC clientData, string pseudo, int userLikes)
        {
            this.ClientData = clientData;
            this.Pseudo = pseudo;

/* Modification non fusionnée à partir du projet 'MeloXamarin.iOS'
Avant :
            this.userLikes = userLikes;
Après :
            this.UserLikes = userLikes;
*/
            this.UserLikes = userLikes;
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

        public int UserLikes
        {
            get
            {
                return userLikes;
            }

            set
            {
                userLikes = value;
            }
        }

        internal ClientRC ClientData
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

        //Constructeurs


        //Méthodes

    }
}
