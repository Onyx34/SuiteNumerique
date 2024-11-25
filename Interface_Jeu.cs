using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suites_Numériques
{
    public partial class Interface_Jeu : Form
    {
        // Attributs
        suite_arithmetique suiteArithmetique;
        suite_geometrique suiteGeometrique;
        List<RadioButton> Bouttons = new List<RadioButton>(4);
        joueur joueur1;
        joueur joueur2;
        int rang;
        int rang2;
        int suite; // 0 pour arithmétique, 1 pour géométrique
        int tour; // 1 pour le joueur 1, 2 pour le joueur 2
        int question; //Numéro de la question
        bool chrono;
        DateTime debutChrono;
        DateTime finChrono;


        // Constructeurs
        internal Interface_Jeu(joueur LeJoueur1, joueur LeJoueur2, int Letour, int nQuestion, bool AvecChrono, int LaSuite)
        {
            InitializeComponent();
            // Initialisation des attributs
            suite = LaSuite;
            tour = Letour;
            question = nQuestion;
            chrono = AvecChrono;
            joueur1 = LeJoueur1;
            joueur2 = LeJoueur2;

            // Inititalisation des champs de linterface
            Bouttons.Add(radioBtn_NonMonotone);
            Bouttons.Add(radioBtn_Croissante);
            Bouttons.Add(radioBtn_Décroissante);
            Bouttons.Add(radioBtn_Constante);

            foreach (RadioButton btn in Bouttons)
            {
                btn.Checked = false;
            }
            textBox_reponse1.Text = "";
            textBox_reponse2.Text = "";

            if (tour == 1)
            {
                label_joueur.Text = "Joueur 1 :";
                label_nom.Text = joueur1.Pseudo;
                label_score.Text = $"Score : {joueur1.Score.ToString()}";
                label_score.ForeColor = Color.Red;
                label_nom.ForeColor = Color.Red;
            }
            else
            {
                label_joueur.Text = "Joueur 2 :";
                label_nom.Text = joueur2.Pseudo;
                label_score.Text = $"Score : {joueur2.Score.ToString()}";
                label_score.ForeColor = Color.Blue;
                label_nom.ForeColor = Color.Blue;
            }
            tabPage.Text = $"Question N°{question}/6";

            // Appeel de la méthode pour initialiser la question en fonction du numéro de la question
            switch (question)
            {
                case 1:
                    InitialiserQuestion1();
                    break;
                case 2:
                    InitialiserQuestion2();
                    break;
                case 3:
                    InitialiserQuestion3();
                    break;
                case 4:
                    InitialiserQuestion4();
                    break;
                case 5:
                    InitialiserQuestion5();
                    break;
                case 6:
                    InitialiserQuestion6();
                    break;
            }

            if (!chrono)
            {
                label_chrono.Visible = false;
            }
            else
            {
                debutChrono = DateTime.Now;
            }


        }

        // Methodes
        private void InitialiserQuestion1()
        {
            // Question 1 = Calculer un terme de rang

            label_reponse2.Visible = false;
            textBox_reponse2.Visible = false;
            groupBox_monotonie.Visible = false;


            if (suite == 0)
            {
                suiteArithmetique = new suite_arithmetique();
                rang = Program.GenererAleatoire(1, 10);
                label_enonce.Text = $"Soit la suite arithmétique (Uₙ) de premier terme U\u2080 et de raison r :";
                label_enonce1.Text = $"U\u2080 : {suiteArithmetique.Premier}";
                label_enonce2.Text = $"r : {suiteArithmetique.Raison}";

            }
            else
            {
                suiteGeometrique = new suite_geometrique();
                rang = Program.GenererAleatoire(1, 5);
                label_enonce.Text = $"Soit la suite géométrique (Uₙ) de premier terme U\u2080 et de raison r :";
                label_enonce1.Text = $"U\u2080 : {suiteGeometrique.Premier}";
                label_enonce2.Text = $"r : {suiteGeometrique.Raison}";
            }

            label_question.Text = $"Quel est la valeur du terme de rang {rang}";
            label_reponse1.Text = "Réponse :";

        }

        private void InitialiserQuestion2()
        {
            // Question 2 = Calculer le premier terme
            label_reponse2.Visible = false;
            textBox_reponse2.Visible = false;
            groupBox_monotonie.Visible = false;

            if (suite == 0)
            {
                suiteArithmetique = new suite_arithmetique();
                rang = Program.GenererAleatoire(1, 10);
                label_enonce.Text = $"Soit la suite arithmétique (Uₙ) définie par le terme U{Program.MettreEnIndice(rang)} et de raison r :";
                label_enonce1.Text = $"U{Program.MettreEnIndice(rang)} : {suiteArithmetique.TermeDeRang(rang)}";
                label_enonce2.Text = $"r : {suiteArithmetique.Raison}";
            }
            else
            {
                suiteGeometrique = new suite_geometrique();
                rang = Program.GenererAleatoire(1, 5);
                label_enonce.Text = $"Soit la suite géométrique (Uₙ) définie par le terme U{Program.MettreEnIndice(rang)} et de raison r :";
                label_enonce1.Text = $"U{Program.MettreEnIndice(rang)} : {suiteGeometrique.TermeDeRang(rang)}";
                label_enonce2.Text = $"r : {suiteGeometrique.Raison}";
            }

            label_question.Text = $"Quel est la valeur du premier terme U\u2080 ?";
            label_reponse1.Text = "Réponse :";

        }

        private void InitialiserQuestion3()
        {
            // Question 3 = Trouver le rang d'un terme
            label_reponse2.Visible = false;
            textBox_reponse2.Visible = false;
            groupBox_monotonie.Visible = false;

            if (suite == 0)
            {
                suiteArithmetique = new suite_arithmetique();
                rang = Program.GenererAleatoire(1, 10);
                label_enonce.Text = $"Soit la suite arithmétique (Uₙ) de premier terme U\u2080 et de raison r :";
                label_enonce1.Text = $"U\u2080 : {suiteArithmetique.Premier}";
                label_enonce2.Text = $"r : {suiteArithmetique.Raison}";
                label_question.Text = $"Quel est le rang du terme de valeur {suiteArithmetique.TermeDeRang(rang)} ?";
            }
            else
            {
                suiteGeometrique = new suite_geometrique();
                rang = Program.GenererAleatoire(1, 5);
                label_enonce.Text = $"Soit la suite géométrique (Uₙ) de premier terme U\u2080 et de raison r :";
                label_enonce1.Text = $"U\u2080 : {suiteGeometrique.Premier}";
                label_enonce2.Text = $"r : {suiteGeometrique.Raison}";
                label_question.Text = $"Quel est le rang du terme de valeur {suiteGeometrique.TermeDeRang(rang)} ?";
            }

            label_reponse1.Text = "Réponse :";
        }

        private void InitialiserQuestion4()
        {
            // Question 4 = Calculer la raison et le premier terme
            groupBox_monotonie.Visible = false;

            if (suite == 0)
            {
                suiteArithmetique = new suite_arithmetique();
                rang = Program.GenererAleatoire(1, 9);
                rang2 = Program.GenererAleatoire(rang + 1, 10);
                label_enonce.Text = $"Soit la suite arithmétique (Uₙ) définie par les termes U{Program.MettreEnIndice(rang)} et U{Program.MettreEnIndice(rang2)}";
                label_enonce1.Text = $"U{Program.MettreEnIndice(rang)} : {suiteArithmetique.TermeDeRang(rang)}";
                label_enonce2.Text = $"U{Program.MettreEnIndice(rang2)} : {suiteArithmetique.TermeDeRang(rang2)}";
            }
            else
            {
                suiteGeometrique = new suite_geometrique();
                rang = Program.GenererAleatoire(1, 4);
                rang2 = Program.GenererAleatoire(rang + 1, 5);
                label_enonce.Text = $"Soit la suite géométrique (Uₙ) définie par les termes U{Program.MettreEnIndice(rang)} et U{Program.MettreEnIndice(rang2)}";
                label_enonce1.Text = $"U{Program.MettreEnIndice(rang)} : {suiteGeometrique.TermeDeRang(rang)}";
                label_enonce2.Text = $"U{Program.MettreEnIndice(rang2)} : {suiteGeometrique.TermeDeRang(rang2)}";
            }

            label_question.Text = "Quelles sont les valeurs de la raison et du premier terme U\u2080 ?";
            label_reponse1.Text = "r :";
            label_reponse2.Text = "U\u2080 :";
        }

        private void InitialiserQuestion5()
        {
            // Question 5 = Calculer la somme des termes
            label_reponse2.Visible = false;
            textBox_reponse2.Visible = false;
            groupBox_monotonie.Visible = false;

            if (suite == 0)
            {
                suiteArithmetique = new suite_arithmetique();
                rang = Program.GenererAleatoire(1, 8);
                label_enonce.Text = $"Soit la suite arithmétique (Uₙ) de premier terme U\u2080 et de raison r :";
                label_enonce1.Text = $"U\u2080 : {suiteArithmetique.Premier}";
                label_enonce2.Text = $"r : {suiteArithmetique.Raison}";
            }
            else
            {
                suiteGeometrique = new suite_geometrique();
                rang = Program.GenererAleatoire(1, 4);
                label_enonce.Text = $"Soit la suite géométrique (Uₙ) de premier terme U\u2080 et de raison r :";
                label_enonce1.Text = $"U\u2080 : {suiteGeometrique.Premier}";
                label_enonce2.Text = $"r : {suiteGeometrique.Raison}";
            }

            label_question.Text = $"Quelle est la somme des {rang + 1} premiers termes de la suite ?";
            label_reponse1.Text = "Réponse :";
        }

        private void InitialiserQuestion6()
        {
            // Question 6 = Trouver la monotonie
            label_reponse1.Visible = false;
            textBox_reponse1.Visible = false;
            label_reponse2.Visible = false;
            textBox_reponse2.Visible = false;

            if (suite == 0)
            {
                suiteArithmetique = new suite_arithmetique();
                rang = Program.GenererAleatoire(1, 10);
                label_enonce.Text = $"Soit la suite arithmétique (Uₙ) de premier terme U\u2080 et de raison r :";
                label_enonce1.Text = $"U\u2080 : {suiteArithmetique.Premier}";
                label_enonce2.Text = $"r : {suiteArithmetique.Raison}";
            }
            else
            {
                suiteGeometrique = new suite_geometrique();
                rang = Program.GenererAleatoire(1, 5);
                label_enonce.Text = $"Soit la suite géométrique (Uₙ) de premier terme U\u2080 et de raison r :";
                label_enonce1.Text = $"U\u2080 : {suiteGeometrique.Premier}";
                label_enonce2.Text = $"r : {suiteGeometrique.Raison}";
            }

            label_question.Text = "Quelle est la monotonie de la suite ?";
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            // Envois la réponse à la méthode de vérification en fonction du numéro de la question
            string reponse = "";
            string solution = "";

            switch (question)
            {
                case 1:
                    if (suite == 0)
                    {
                        solution = suiteArithmetique.TermeDeRang(rang).ToString();
                    }
                    else
                    {
                        solution = suiteGeometrique.TermeDeRang(rang).ToString();
                    }
                    reponse = textBox_reponse1.Text;
                    break;
                case 2:
                    if (suite == 0)
                    {
                        solution = suiteArithmetique.Premier.ToString();
                    }
                    else
                    {
                        solution = suiteGeometrique.Premier.ToString();
                    }
                    reponse = textBox_reponse1.Text;
                    break;

                case 3:
                    if (suite == 0)
                    {
                        solution = rang.ToString();
                    }
                    else
                    {
                        solution = rang.ToString();
                    }
                    reponse = textBox_reponse1.Text;
                    break;

                case 4:
                    if (suite == 0)
                    {
                        solution = $"{suiteArithmetique.Raison}$${suiteArithmetique.Premier}";
                    }
                    else
                    {
                        solution = $"{suiteGeometrique.Raison}$${suiteGeometrique.Premier}";
                    }
                    reponse = $"{textBox_reponse1.Text}$$${textBox_reponse2.Text}";
                    break;

                case 5:
                    if (suite == 0)
                    {
                        solution = suiteArithmetique.SommeDesTermes(rang).ToString();
                    }
                    else
                    {
                        solution = suiteGeometrique.SommeDesTermes(rang).ToString();
                    }
                    reponse = textBox_reponse1.Text;
                    break;

                case 6:
                    if (suite == 0)
                    {
                        solution = suiteArithmetique.Monotonie();
                    }
                    else
                    {
                        solution = suiteGeometrique.Monotonie();
                    }

                    // On cherche le bouton sélectionné
                    foreach (RadioButton btn in Bouttons)
                    {
                        if (btn.Checked)
                        {
                            reponse = btn.Name.Split('_')[1];
                            break;
                        }
                    }

                    break;

            }
            Correction(reponse, solution);

        }

        private void button_passer_Click(object sender, EventArgs e)
        {
            // Ferme simplement le formulaire sans ajouter ou sousstraire de points
            this.Close();
        }

        private void Correction(string reponse, string solution)
        {
            // Fonction pour vérifier la réponse donnée par l'utilisateur en fonction de la solution (chaine)
            int pointsSupplementaire = 0;

            reponse = reponse.Trim();
            if (reponse == "")
            {
                return;
            }

            // Arrêt du chrono
            if (chrono)
            {
                finChrono = DateTime.Now;
                TimeSpan duree = finChrono - debutChrono;
                int secondesEcoulees = (int)duree.TotalSeconds;
                if (secondesEcoulees < 60)
                {
                    pointsSupplementaire = 3;
                }
                else if (secondesEcoulees < 120)
                {
                    pointsSupplementaire = 2;
                }
                else if (secondesEcoulees < 180)
                {
                    pointsSupplementaire = 1;
                }
            }

            if (reponse == solution)
            {
                if (tour == 1)
                {
                    joueur1.Score += 1 + pointsSupplementaire;
                }
                else
                {
                    joueur2.Score += 1 + pointsSupplementaire;
                }
                if (chrono)
                {
                    MessageBox.Show($"Réponse correcte\nVous avez gagné {pointsSupplementaire} points supplémentaires pour le temps", "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Réponse correcte", "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                if (tour == 1)
                {
                    joueur1.Score -= 1;
                }
                else
                {
                    joueur2.Score -= 1;
                }
                MessageBox.Show("Réponse incorrecte", "Résultat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void button_scores_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{joueur1.Pseudo} : {joueur1.Score}\n{joueur2.Pseudo} : {joueur2.Score}", "Partie en cours...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_regles_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- Le Jeu se joue à deux joueurs à tour de rôle avec 6 questions par parties\n" +
                "- A chaque tour, un calcul de même nature sur les suites est demandé\n" +
                "- Lors d'un tour, le joueur peut valider une réponse ou passer la question\n" +
                "- Si le joueur valide une réponse, il gagne un point pour une réponse correcte, il perd un point pour une réponse incorrecte\n" +
                "- Si le joueur passe la question, ses points ne sont pas modifiés\n" +
                "- Le jeu peut se jouer avec ou sans contrainte de temps\n" +
                "- Si la contrainte temps est activé alors le joueur se voit attribuer des points supplémentaires lors d'une bonne réponse rapide",
                "Jeu : Règles du jeu",
                MessageBoxButtons.OK);
        }
    }
}
