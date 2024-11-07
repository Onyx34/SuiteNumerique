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
        public suite_geometrique() : base(Program.GenererAleatoire(-8, 8))
        {
            raison = Program.GenererAleatoire(-5, 5);
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
        public int TermeDeRang(int leRang)
        {
            return premier_terme * (int)Math.Pow(raison, leRang);
        }

        public int SommeDesTermes(int rangLaSomme)
        {
            return premier_terme * ((int)Math.Pow(raison, rangLaSomme + 1) - 1) / (raison - 1);
        }

        public string Monotonie()
        {
            if ((raison > 1 && premier_terme > 0) || (raison == 0 && premier_terme < 0))
            {
                return "Croissante";
            }
            else if ((raison > 1 && premier_terme < 0) || (raison > 0 && raison < 1 && premier_terme > 0) || (raison == 0 && premier_terme > 0))
            {
                return "Décroissante";
            }
            else if (raison == 1 || premier_terme == 0)
            {
                return "Constante";
            }
            else
            {
                return "NonMonotone";
            }
        }
    }
}
