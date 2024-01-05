using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetPerso
{
    public partial class FrmMenuPrincipale : Form
    {
        public FrmMenuPrincipale()
        {
            InitializeComponent();
        }

        private void btnAfficherClass_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLeaderboard frmleaderboardequipe = new FrmLeaderboard();//création d'une nouvelle form//
            frmleaderboardequipe.ShowDialog();
        }

        private void btnAddPartie_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAjouterPartie frmajouterpartie = new FormAjouterPartie();//création d'une nouvelle form//
            frmajouterpartie.ShowDialog();
        }
    }
}
