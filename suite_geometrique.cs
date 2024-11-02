using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suites_Numériques
{
    internal class suite_geometrique : suite
    {
        // Attributs
        private int raison;

        // Constructeurs
        public suite_geometrique() : base(GenererPremier())
        {
            Random rnd = new Random();
            raison = rnd.Next(-10, 10);
        }

        public suite_geometrique(int LaRaison, int LePremier) : base(LePremier)
        {
            raison = LaRaison;
        }

        public suite_geometrique(int LaRaison, int LePremier, int IncidePremier) : base(LePremier, IncidePremier)
        {
            raison = LaRaison;
        }


        // Accesseurs
        public int Raison
        {
            get { return raison; }
            set { raison = value; }
        }


        // Methodes
        private static int GenererPremier()
        {
            Random rnd = new Random();
            int premier = rnd.Next(-50, 50);
            return premier;
        }
    }
}
