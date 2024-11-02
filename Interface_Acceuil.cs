using System;
using System.Windows.Forms;

namespace Suites_Numériques
{
    public partial class Interface_Acceuil : Form
    {
        public Interface_Acceuil()
        {
            InitializeComponent();
        }

        private void toolStrip_Arithmetiques_Click(object sender, EventArgs e)
        {
            Interface_Arithmetique arithmetique = new Interface_Arithmetique();
            arithmetique.Show();
        }

        private void toolStrip_Geometrique_Click(object sender, EventArgs e)
        {
            Interface_Geometrique geometrique = new Interface_Geometrique();
            geometrique.Show();
        }
    }
}
