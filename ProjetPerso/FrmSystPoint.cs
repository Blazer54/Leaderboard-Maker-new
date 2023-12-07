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
    public partial class FrmSystPoint : Form
    {
        List<Equipe> equipes = new List<Equipe>();
        List<Joueur> joueurs = new List<Joueur>();
        List<Systpoint>systpoint = new List<Systpoint>();
        string nombrejoueurs;
        int nbrequipe;
    public FrmSystPoint(List<Equipe> equipe, List<Joueur> joueur, string nombrejoueur)
        {
            InitializeComponent();
            equipes = equipe;
            joueurs = joueur;
            nombrejoueurs = nombrejoueur;
            nbrequipe = equipes.Count;
        }

        private void FrmSystPoint_Load(object sender, EventArgs e)
        {
            lbl3eme.Hide();
            lbl4eme.Hide();
            lbl4eme.Hide();
            lbl5eme.Hide();
            lbl6eme.Hide();
            tbx3eme.Hide();
            tbx4eme.Hide();
            tbx5eme.Hide();
            tbx6eme.Hide();
            if (nbrequipe == 3)
            {
                lbl3eme.Show();
                tbx3eme.Show();
            }
            else if (nbrequipe == 4)
            {
                lbl3eme.Show();
                tbx3eme.Show();
                lbl4eme.Show();
                tbx4eme.Show();
            }
            else if (nbrequipe == 5)
            {
                lbl3eme.Show();
                tbx3eme.Show();
                lbl5eme.Show();
                tbx5eme.Show();
            }
            else if (nbrequipe == 6)
            {
                lbl3eme.Show();
                tbx3eme.Show();
                lbl6eme.Show();
                tbx6eme.Show();
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {

            /*
            
            tbx2eme.Text;
            tbx3eme.Text;
            tbx4eme.Text;
            tbx5eme.Text;
            tbx6eme.Text;
            */
        }
    }
}
