using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_Melo
{
    class Song
    {
        string titre;
        string auteur;
        string album;
        string lienYT;
        GenreList classification;



        //Constructeurs
        public Song(string titre, string auteur, string album, string lienYT, GenreList classification)
        {
            this.Titre = titre;
            this.Auteur = auteur;
            this.Album = album;
            this.LienYT = lienYT;
            this.Classification = classification;
        }

        //Méthodes


        public string Titre
        {
            get
            {
                return titre;
            }

            set
            {
                titre = value;
            }
        }

        public string Auteur
        {
            get
            {
                return auteur;
            }

            set
            {
                auteur = value;
            }
        }

        public string Album
        {
            get
            {
                return album;
            }

            set
            {
                album = value;
            }
        }

        public string LienYT
        {
            get
            {
                return lienYT;
            }

            set
            {
                lienYT = value;
            }
        }

        public GenreList Classification
        {
            get
            {
                return classification;
            }

            set
            {
                classification = value;
            }
        }

        public string afficheClassification()
        {
            string reponse = "";
            reponse += "\tRock: " + classification.Rock;
            reponse += "\n\tRap: " + classification.Rap;
            reponse += "\n\tClassique: " + classification.Classique;
            return reponse;
        }
        public override string ToString()
        {
            return "titre: " + Titre + "\nauteur: " + Auteur + "\nalbum: " + Album + "\nLienYT: " + LienYT + "\nClassification" + afficheClassification();
        }
    }
}
