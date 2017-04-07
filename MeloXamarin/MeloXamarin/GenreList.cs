using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_Melo
{
    class GenreList
    {
        double rock;
        double rap;
        double classique;


        //Cosntructeurs
        public GenreList(double rock, double rap, double classique)
        {
            this.Rock = rock;
            this.Rap = rap;
            this.Classique = classique;
        }

        //Méthodes
        public double Rock
        {
            get
            {
                return rock;
            }

            set
            {
                rock = value;
            }
        }

        public double Rap
        {
            get
            {
                return rap;
            }

            set
            {
                rap = value;
            }
        }

        public double Classique
        {
            get
            {
                return classique;
            }

            set
            {
                classique = value;
            }
        }
    }
}
