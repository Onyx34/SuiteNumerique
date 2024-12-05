using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suites_Numériques
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Interface_Accueil());
        }

        public static int GenererAleatoire(int minValue, int maxValue)
        {
            using (var rng = RandomNumberGenerator.Create())
            {
                byte[] randomNumber = new byte[4];
                rng.GetBytes(randomNumber);

                // Convertir les 4 octets en un entier
                int generatedValue = BitConverter.ToInt32(randomNumber, 0);

                // Mettre le résultat dans la plage désirée
                return Math.Abs(generatedValue % (maxValue - minValue)) + minValue;
            }
        }

        public static string MettreEnIndice(int indice)
        {
            char[] indiceDe = { '\u2080', '\u2081', '\u2082', '\u2083', '\u2084', '\u2085', '\u2086', '\u2087', '\u2088', '\u2089' };

            string indice_str = "";
            if (indice > 9)
            {
                indice_str = $"{indiceDe[(int)indice / 10]}";
            }
            indice_str += $"{indiceDe[indice % 10]}";

            return indice_str;
        }
    }
}
