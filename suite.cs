using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suites_Numériques
{
    internal class suite
    {
        // Attributs
        protected int premier_terme;
        protected int debut = 0;

        // Constructeurs
        public suite(int LePremier)
        {
            premier_terme = LePremier;
        }

        public suite(int LePremier, int LeDebut)
        {
            premier_terme = LePremier;
            debut = LeDebut;
        }

        // Accesseurs
        public int Premier
        {
            get { return premier_terme; }
            set { premier_terme = value; }
        }

        public int Debut
        {
            get { return debut; }
            set { debut = value; }
        }

        // Methodes

    }
}
