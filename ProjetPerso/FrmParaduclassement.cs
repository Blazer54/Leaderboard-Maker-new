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
        List<Equipe>equipe = new List<Equipe>();
        List<TextBox> tbxequipe = new List<TextBox>();
        public FrmParaduclassement()
        {
            InitializeComponent();
        }
        private void chbequipe_CheckedChanged(object sender, EventArgs e)
        {
            if (chbequipe.Checked == true) //si la checkbox équipe est cochée//
            {

                lblnbrequipe.Show();//montrer le label pour le nombre d'équipe//
                tbxnbrequipe.Show();//montrer la combo box pour le nombre d'équipe//
                chbSeul.Hide();//cacher la check box//
                bool equipeVerif = true;//envoie l'information true //
                btnValidernbrequipe.Show();
            }
            else //si la check box équipe n'est pas couchée//
            {

                lblnbrequipe.Hide();
                tbxnbrequipe.Hide();
                chbSeul.Show(); //montre la check box//
                bool equipeVerif = false;//si la check box équipe n'est pas cochée //
                btnValidernbrequipe.Hide();
            }
        }

        private void FrmParaduclassement_Load(object sender, EventArgs e)//quand la forme ce charge //
        {
            
            equipe.Add(new Equipe("Blank"));
            tbxnbrequipe.Hide();
            lblnbrequipe.Hide();
            btnValidernbrequipe.Hide();
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
            string nombreDeJoueur = tbxnbrequipe.Text;
            
            bool equipeVerif = false;//le bool équipe est sur false de base//
            if (chbequipe.Checked == true)//si le checkbox équipe est cochée//
            {
                equipeVerif = true;//le bool équipe est sur true//
            }
            else//sinon//
            {
                equipeVerif = false;//le bool est sur false//
            }
            //création d'une nouvelle form qui a toutes les info sur les nom d'équipe le nombre de joueur//
           FrmInfoJoueurs Frminfojoueurs = new FrmInfoJoueurs(nombreDeJoueur,equipeVerif, equipe);
            Frminfojoueurs.ShowDialog();

            AjouterEquipe();
        }

        private void cbxnbrequipe_SelectedIndexChanged(object sender, EventArgs e)//quand check box est changer//
        {
           
            /*
            equipe.Add(new Equipe(tbxnomequipe1.Text));//ajout des nom d'équipe a la classe "equipe"//
            equipe.Add(new Equipe(tbxnomequipe2.Text));
            equipe.Add(new Equipe(tbxnomequipe3.Text));
            equipe.Add(new Equipe(tbxnomequipe4.Text));      
            equipe.Add(new Equipe(tbxnomequipe5.Text));
            equipe.Add(new Equipe(tbxnomequipe6.Text));
            */
        }
       
        private void tbxnbrequipe_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnValidernbrequipe_Click(object sender, EventArgs e)
        {

            int nbrcbxnbrequipe = Convert.ToInt32(tbxnbrequipe.Text);
            for (int i = 1; i <= nbrcbxnbrequipe / 2; i++)
            {
                int posX = 180;
                // Créer un Label
                Label label = new Label();
                label.Text = "Nom equipe : " + i.ToString();
                label.Name = "lblEquipe" + i.ToString();
                label.Location = new System.Drawing.Point(posX + 25, 50 * i + 50);
                this.Controls.Add(label);
                
                TextBox textBox = new TextBox();
                textBox.Location = new System.Drawing.Point(posX + 125, 50 * i + 50);
                textBox.Size = new System.Drawing.Size(100, 20);
                textBox.Name = "tbxnomequipe" + i.ToString(); // Nommer la TextBox de manière unique
                tbxequipe.Add(textBox);
                this.Controls.Add(textBox);

                this.equipe.Add(new Equipe(textBox.Text));
            }
            for (int i = nbrcbxnbrequipe / 2 + 1; i <= nbrcbxnbrequipe; i++)
            {

                int posX = 480;
                // Créer un Label
                Label label = new Label();
                label.Text = "Nom equipe : " + i.ToString();
                label.Name = "lblEquipe" + i.ToString();
                label.Location = new System.Drawing.Point(posX + 25, 50 * (i - nbrcbxnbrequipe / 2) + 50);
                this.Controls.Add(label);

                TextBox textBox = new TextBox();
                textBox.Location = new System.Drawing.Point(posX + 125, 50 * (i - nbrcbxnbrequipe / 2) + 50);
                textBox.Size = new System.Drawing.Size(100, 20);
                textBox.Name = "tbxnomequipe" + i.ToString(); // Nommer la TextBox de manière unique
                tbxequipe.Add(textBox);
                this.Controls.Add(textBox);
                this.equipe.Add(new Equipe(textBox.Text));

            }
        }
        public void AjouterEquipe()
        {
            for (int i = 0; i < equipe.Count; i++) 
            {
                string nomEquipe = tbxequipe[i].Text;
                if (!string.IsNullOrEmpty(nomEquipe))
                {
                    equipe.Add(new Equipe(nomEquipe));
                }
                else { return; }
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
