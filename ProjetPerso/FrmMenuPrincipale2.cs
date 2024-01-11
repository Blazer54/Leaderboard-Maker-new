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
    public partial class FrmMenuPrincipale2 : Form
    {
        List<Equipe> equipe = new List<Equipe>();
        List<Joueur> joueur = new List<Joueur>();
        List<Systpoint> systpoints = new List<Systpoint>();
        List<Partie> partie = new List<Partie>();
        public FrmMenuPrincipale2(List<Systpoint> systpoint, List<Equipe> equipes, List<Joueur> joueurs, List<Partie> parties)
        {
            InitializeComponent();
            equipe = equipes;
            joueur = joueurs;
            systpoints = systpoint;
            partie = parties; 
        }

        private void btnAfficherClass_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLeaderboard frmleaderboardequipe = new FrmLeaderboard(equipe, joueur, systpoints, partie);//création d'une nouvelle form//
            frmleaderboardequipe.ShowDialog();
        }

        private void btnAddPartie_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAjouterPartie frmajouterpartie = new FormAjouterPartie(equipe, joueur, systpoints);//création d'une nouvelle form//
            frmajouterpartie.ShowDialog();
        }
    }
}
