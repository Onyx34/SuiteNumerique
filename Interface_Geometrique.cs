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
    public partial class Interface_Geometrique : Form
    {
        suite_geometrique suite;

        public Interface_Geometrique()
        {
            InitializeComponent();
        }

        private void btn_nouvelle_Click(object sender, EventArgs e)
        {
            suite = new suite_geometrique();
            label_r_terme.Text = "r : " + suite.Raison;
            label_U0_terme.Text = "U\u2080" + suite.Premier;
        }
    }
}
