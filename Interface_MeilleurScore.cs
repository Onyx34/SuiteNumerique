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
    public partial class Interface_MeilleurScore : Form
    {

        // Constructeur
        public Interface_MeilleurScore()
        {
            InitializeComponent();
            // Déclaration des labels
            for (int i = 1; i <= 10; i++)
            {
                joueur joueur = new joueur(i);
                Controls[$"label_joueur{i}"].Text = joueur.Pseudo;
                Controls[$"label_score{i}"].Text = joueur.Score.ToString();
                Controls[$"label_date{i}"].Text = joueur.Date;
            }
        }
    }
}
