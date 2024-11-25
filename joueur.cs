using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Suites_Numériques
{
    internal class joueur
    {
        // Attributs
        private string pseudo;
        private int score;

        // Constructeurs
        public joueur(string LePseudo)
        {
            pseudo = LePseudo;
            score = 0;
        }

        public joueur(string LePseudo, int LeScore)
        {
            pseudo = LePseudo;
            score = LeScore;
        }

        // Accesseurs
        public string Pseudo
        {
            get { return pseudo; }
            set { pseudo = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        // Methodes
        public bool Authentification(string LePassword)
        {
            // Fonction servant à l'authentification du joueur
            // Ouvre puis parcour le fichier "joueurs.txt" pour vérifier si le joueur existe
            // Si le joueur existe, vérifie si le mot de passe est correct et renvois true ou false
            // Sinon , crée un nouveau joueur et renvois true

            // Initionalisation des variables
            string nomFichier = "joueurs.txt";
            StreamReader fichierLecture;
            StreamWriter fichierEcriture;
            string[] ligne;
            char delimiteur = '\t';

            fichierLecture = new StreamReader(nomFichier);
            while (!fichierLecture.EndOfStream)
            {
                ligne = fichierLecture.ReadLine().Split(delimiteur);
                if (ligne[0] == pseudo)
                {
                    if (ligne[1] == LePassword)
                    {
                        fichierLecture.Close();
                        return true;
                    }
                    else
                    {
                        fichierLecture.Close();
                        return false;
                    }
                }
            }
            fichierLecture.Close();

            fichierEcriture = new StreamWriter(nomFichier, true);
            fichierEcriture.WriteLine(pseudo + delimiteur + LePassword + delimiteur + "0");
            fichierEcriture.Close();
            return true;
        }

        public void MettreAJourScore()
        {
            // Méthode pour mettre à jour le meilleur score dans le fichier joueurs.txt
            // Parcour le fichier pour trouver le joueur, si le score est meilleur, le remplace

            // Initionalisation des variables
            string nomFichier = "joueurs.txt";
            StreamReader fichierLecture;
            StreamWriter fichierEcriture;
            string[] ligne;
            char delimiteur = '\t';
            List<string> lignes = new List<string>();

            fichierLecture = new StreamReader(nomFichier);
            while (!fichierLecture.EndOfStream)
            {
                ligne = fichierLecture.ReadLine().Split(delimiteur);
                if (ligne[0] == pseudo)
                {
                    if (score > int.Parse(ligne[2]))
                    {
                        ligne[2] = score.ToString();
                    }
                }
                lignes.Add(ligne[0] + delimiteur + ligne[1] + delimiteur + ligne[2]);
            }
            fichierLecture.Close();

            fichierEcriture = new StreamWriter(nomFichier);
            foreach (string l in lignes)
            {
                fichierEcriture.WriteLine(l);
            }
            fichierEcriture.Close();
        }
    }
}
