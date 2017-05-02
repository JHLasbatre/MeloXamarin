using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_Melo
{
    class PersonnePhysique : Broadcaster
    {

        //Attributs

        //Constructeur
        public PersonnePhysique(ClientRC clientData, string pseudo, int userLikes) : base(clientData, pseudo, userLikes)
        {

        }


        //Méthodes
        public override string ToString()
        {
            return base.ToString();
        }
        public void PlayBroadcasintSong()
        {

        }

        public void AddLike(Broadcaster b)
        {
            b.UserLikes
        }

        public void Unlike
    }
}
