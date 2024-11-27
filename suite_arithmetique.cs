using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Suites_Numériques
{
    internal class suite_arithmetique : suite
    {
        // Attributs
        private int raison;

        // Constructeurs
        public suite_arithmetique() : base(Program.GenererAleatoire(-25, 25))
        {
            raison = Program.GenererAleatoire(-10, 10);
            if (raison == 0) // Exlusion de la raison nulle inintéressante
            {
                raison = 1;
            }

        }

        public suite_arithmetique(int LaRaison, int LePremier) : base(LePremier)
        {
            raison = LaRaison;
        }

        public suite_arithmetique(int LaRaison, int LePremier, int IncidePremier) : base(LePremier, IncidePremier)
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
            return premier_terme + (leRang * raison);
        }

        public int SommeDesTermes(int rangLaSomme)
        {
            return (rangLaSomme + 1) * (premier_terme + TermeDeRang(rangLaSomme)) / 2;

        }

        public string Monotonie()
        {
            if (raison > 0)
            {
                return "Croissante";
            }
            else if (raison < 0)
            {
                return "Décroissante";
            }
            else
            {
                return "Constante";
            }
        }
    }
}
