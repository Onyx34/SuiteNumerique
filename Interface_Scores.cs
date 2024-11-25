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
    public partial class Interface_Scores : Form
    {
        internal Interface_Scores(joueur joueur1, joueur joueur2)
        {
            InitializeComponent();
            if (joueur1.Score > joueur2.Score)
            {
                label_vainqueur.Text = $"VAINQUEUR : {joueur1.Pseudo}";
                label_vainqueur.ForeColor = Color.Red;
            }
            else
            {
                label_vainqueur.Text = $"VAINQUEUR : {joueur2.Pseudo}";
                label_vainqueur.ForeColor = Color.Blue;
            }
            label_joueur1.Text = $"{joueur1.Pseudo} : {joueur1.Score}";
            label_joueur2.Text = $"{joueur2.Pseudo} : {joueur2.Score}";
        }

        private void btn_nouvelle_Click(object sender, EventArgs e)
        {
            // Fermeture de cette interface et envois de l'info vers Interface_InitialisationJeu pour relancer une partie
            this.DialogResult = DialogResult.OK;
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            // Fermeture de cette interface et envois de l'info vers Interface_InitialisationJeu pour retourner au menu
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
