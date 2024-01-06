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
    public partial class FormAjouterPartie : Form
    {
        List<Equipe> equipes = new List<Equipe>();
        List<Joueur> joueurs = new List<Joueur>();
        List<Systpoint> systpoint = new List<Systpoint>();
        public FormAjouterPartie(List<Equipe> equipe, List<Joueur> joueur, List<Systpoint> systpoints)
        {
            InitializeComponent();
            equipes = equipe;
            joueurs = joueur;
            systpoint = systpoints;
        }

        private void FormAjouterPartie_Load(object sender, EventArgs e)
        {

        }

        private void FormAjouterPartie_Load_1(object sender, EventArgs e)
        {

        }
    }
}
