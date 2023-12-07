using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProjetPerso
{
    public partial class FrmParaduclassement : Form
    {
        List<Equipe> equipe = new List<Equipe>();
        public FrmParaduclassement()
        {
            InitializeComponent();
        }
        private void chbequipe_CheckedChanged(object sender, EventArgs e)
        {
            if (chbequipe.Checked == true) //si la checkbox équipe est cochée//
            {

                lblnbrequipe.Show();//montrer le label pour le nombre d'équipe//
                cbxnbrequipe.Show();//montrer la combo box pour le nombre d'équipe//
                chbSeul.Hide();//cacher la check box//
                bool equipeVerif = true;//envoie l'information true //
            }
            else //si la check box équipe n'est pas couchée//
            {

                lblnomequipe1.Hide();//cache le lbl//
                lblnomequipe2.Hide();
                lblnomequipe3.Hide();
                lblnomequipe4.Hide();
                lblnomequipe5.Hide();
                lblnomequipe6.Hide();
                tbxnomequipe1.Hide();//cache le tbx//
                tbxnomequipe2.Hide();
                tbxnomequipe3.Hide();
                tbxnomequipe4.Hide();
                tbxnomequipe5.Hide();
                tbxnomequipe6.Hide();
                lblnbrequipe.Hide();
                cbxnbrequipe.Hide();
                chbSeul.Show(); //montre la check box//
                bool equipe = false;//si la check box équipe n'est pas cochée //
            }
        }

        private void FrmParaduclassement_Load(object sender, EventArgs e)//quand la forme ce charge //
        {
            lblnomequipe1.Hide();//cache les lbl//
            lblnomequipe2.Hide();
            lblnomequipe3.Hide();   
            lblnomequipe4.Hide();
            lblnomequipe5.Hide();
            lblnomequipe6.Hide();
            tbxnomequipe1.Hide();//cache les tbx//
            tbxnomequipe2.Hide();
            tbxnomequipe3.Hide();
            tbxnomequipe4.Hide();
            tbxnomequipe5.Hide();
            tbxnomequipe6.Hide();
            lblnbrequipe.Hide();
            cbxnbrequipe.Hide();
        }

        private void chbSeul_CheckedChanged(object sender, EventArgs e)//quand la checkbox change d'état//
        {
            if (chbSeul.Checked == true) //si la checkbox seul est cochée //
            {
                chbequipe.Hide();//cache l'opption équipe//
            }
            else //so la checkbox n'est pas chochée
            { 
                chbequipe.Show(); //montre l'opption équipe//
            }

        }
        private void btnvalider_Click(object sender, EventArgs e)//quand on clique sur le btn valider //
        {
            this.Hide();//cache la form acctuelle //
            string nomEquipe1 = tbxnomequipe1.Text;//des string qui contient les contenus des nom d'équipe//
            string nomEquipe2 = tbxnomequipe2.Text;
            string nomEquipe3 = tbxnomequipe3.Text;
            string nomEquipe4 = tbxnomequipe4.Text;
            string nomEquipe5 = tbxnomequipe5.Text;
            string nomEquipe6 = tbxnomequipe6.Text;
            string nombreDeJoueur = cbxjoueur.Text;
            equipe.Add(new Equipe(tbxnomequipe1.Text));
            bool equipe = false;//le bool équipe est sur false de base//
            if (chbequipe.Checked == true)//si le checkbox équipe est cochée//
            {
               equipe = true;//le bool équipe est sur true//
            }
            else//sinon//
            {
            equipe = false;//le bool est sur false//
            }
            //création d'une nouvelle form qui a toutes les info sur les nom d'équipe le nombre de joueur//
           FrmInfoJoueurs Frminfojoueurs = new FrmInfoJoueurs(nomEquipe1, nomEquipe2, nomEquipe3, nomEquipe4, nomEquipe5, nomEquipe6,equipe,nombreDeJoueur);
            Frminfojoueurs.ShowDialog();
            

        }

        private void cbxnbrequipe_SelectedIndexChanged(object sender, EventArgs e)//quand check box est changer//
        {
            if (cbxnbrequipe.Text == "2") //si deux est choisi//
            {
                lblnomequipe1.Show();//montre les lbl et tbx des equipe 1 et 2 et les autres sont cacher//
                tbxnomequipe1.Show();
                lblnomequipe2.Show();
                tbxnomequipe2.Show();
                lblnomequipe3.Hide();
                tbxnomequipe3.Hide();
                lblnomequipe4.Hide();
                tbxnomequipe4.Hide();
                lblnomequipe5.Hide();
                tbxnomequipe5.Hide();
                lblnomequipe6.Hide();
                tbxnomequipe6.Hide();

            }
            else if (cbxnbrequipe.Text == "3")
            {
                lblnomequipe1.Show();//montre les lbl et tbx des equipe 1, 2 et 3 et les autres sont cacher//
                tbxnomequipe1.Show();
                lblnomequipe2.Show();
                tbxnomequipe2.Show();
                lblnomequipe3.Show();
                tbxnomequipe3.Show();
                lblnomequipe4.Hide();
                tbxnomequipe4.Hide();
                lblnomequipe5.Hide();
                tbxnomequipe5.Hide();
                lblnomequipe6.Hide();
                tbxnomequipe6.Hide();
            }
            else if (cbxnbrequipe.Text == "4")
            {
                lblnomequipe1.Show();//montre les lbl et tbx des equipe 1,2,3 et 4 les autres sont cacher//
                tbxnomequipe1.Show();
                lblnomequipe2.Show();
                tbxnomequipe2.Show();
                lblnomequipe3.Show();
                tbxnomequipe3.Show();
                lblnomequipe4.Show();
                tbxnomequipe4.Show();
                lblnomequipe5.Hide();
                tbxnomequipe5.Hide();
                lblnomequipe6.Hide();
                tbxnomequipe6.Hide();
            }
            else if (cbxnbrequipe.Text == "5")
            {
                lblnomequipe1.Show();//montre les lbl et tbx des equipe 1,2,3,4 et 5 les autres sont cacher//
                tbxnomequipe1.Show();
                lblnomequipe2.Show();
                tbxnomequipe2.Show();
                lblnomequipe3.Show();
                tbxnomequipe3.Show();
                lblnomequipe4.Show();
                tbxnomequipe4.Show();
                lblnomequipe5.Show();
                tbxnomequipe5.Show(); 
                lblnomequipe6.Hide();
                tbxnomequipe6.Hide();
            }
            else if (cbxnbrequipe.Text == "6")
            {
                lblnomequipe1.Show();//montre les lbl et tbx des equipe 1,2,3,4,5 et 6 les autres sont cacher//
                tbxnomequipe1.Show();
                lblnomequipe2.Show();
                tbxnomequipe2.Show();
                lblnomequipe3.Show();
                tbxnomequipe3.Show();
                lblnomequipe4.Show();
                tbxnomequipe4.Show();
                lblnomequipe5.Show();
                tbxnomequipe5.Show();
                lblnomequipe6.Show();
                tbxnomequipe6.Show();
            }
            else 
            {
                lblnomequipe1.Hide();//sinon tout les lbl et tbx sont cacher//
                tbxnomequipe1.Hide();
                lblnomequipe2.Hide();
                tbxnomequipe2.Hide();
                lblnomequipe3.Hide();
                tbxnomequipe3.Hide();
                lblnomequipe4.Hide();
                tbxnomequipe4.Hide();
                lblnomequipe5.Hide();
                tbxnomequipe5.Hide();
                lblnomequipe6.Hide();
                tbxnomequipe6.Hide();
            }
        }
    }
}
