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
        //création de liste //
        List<Equipe> equipe = new List<Equipe>();
        List<Joueur> joueur = new List<Joueur>();
        List<Systpoint> systpoints = new List<Systpoint>();
        public FrmMenuPrincipale(List<Systpoint> systpoint, List<Equipe> equipes, List<Joueur> joueurs)
        {
            InitializeComponent();
            //recupération des info transemise//
            equipe = equipes;
            joueur = joueurs;
            systpoints = systpoint;
        }
        private void btnAddPartie_Click(object sender, EventArgs e)//quand le bouton ajouter une partie est cliquer //
        {
            this.Hide();
            FormAjouterPartie frmajouterpartie = new FormAjouterPartie(equipe, joueur, systpoints);//création d'une nouvelle form//
            frmajouterpartie.ShowDialog();
        }
    }
}
