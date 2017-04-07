using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_Melo
{
    class ClientRC : ClientID
    {
        private List<Song> tops;
        private Position localisation;
        private Song broadcastingSong;



        //Constructeurs
        public ClientRC(int id, List<Song> tops, Position localisation, Song broadcastingSong) : base(id)
        {
            this.Tops = tops;
            this.Localisation = localisation;
            this.BroadcastingSong = broadcastingSong;
        }

        //Méthodes

        public List<Song> Tops
        {
            get
            {
                return tops;
            }

            set
            {
                tops = value;
            }
        }

        public Position Localisation
        {
            get
            {
                return localisation;
            }

            set
            {
                localisation = value;
            }
        }

        public Song BroadcastingSong
        {
            get
            {
                return broadcastingSong;
            }

            set
            {
                broadcastingSong = value;
            }
        }
    }
}
