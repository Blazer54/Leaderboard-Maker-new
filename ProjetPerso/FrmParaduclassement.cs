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
                bool equipeVerif = true;//envoie l'information true //
                btnValidernbrequipe.Show();
            }
            else //si la check box équipe n'est pas couchée//
            {

                lblnbrequipe.Hide();
                tbxnbrequipe.Hide();
                bool equipeVerif = false;//si la check box équipe n'est pas cochée //
                btnValidernbrequipe.Hide();
            }
        }

        private void FrmParaduclassement_Load(object sender, EventArgs e)//quand la forme ce charge //
        {
            tbxnbrequipe.Hide();
            lblnbrequipe.Hide();
            btnValidernbrequipe.Hide();
        }

        private void btnvalider_Click(object sender, EventArgs e)//quand on clique sur le btn valider //
        {
            AjouterEquipe();
            this.Hide();//cache la form acctuelle //
            string nombreDeJoueur = tbxnbrjoueur.Text;
            
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
            
        }

        private void cbxnbrequipe_SelectedIndexChanged(object sender, EventArgs e)//quand check box est changer//
        {
           
        }
       
        private void tbxnbrequipe_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnValidernbrequipe_Click(object sender, EventArgs e)
        {

            int nbrcbxnbrequipe = Convert.ToInt32(tbxnbrequipe.Text);
            for (int i = 1; i <= nbrcbxnbrequipe / 2; i++)
            {
                int posX = 200;
                // Créer un Label
                Label label = new Label();
                label.Text = "Nom equipe : " + i.ToString();
                label.Name = "lblEquipe" + i.ToString();
                label.Location = new System.Drawing.Point(posX + 25, 50 * i + 70);
                this.Controls.Add(label);
                
                TextBox textBox = new TextBox();
                textBox.Location = new System.Drawing.Point(posX + 125, 50 * i + 70);
                textBox.Size = new System.Drawing.Size(100, 20);
                textBox.Name = "tbxnomequipe" + i.ToString(); // Nommer la TextBox de manière unique
                tbxequipe.Add(textBox);
                this.Controls.Add(textBox);

            }
            for (int i = nbrcbxnbrequipe / 2 + 1; i <= nbrcbxnbrequipe; i++)
            {

                int posX = 500;
                // Créer un Label
                Label label = new Label();
                label.Text = "Nom equipe : " + i.ToString();
                label.Name = "lblEquipe" + i.ToString();
                label.Location = new System.Drawing.Point(posX + 25, 50 * (i - nbrcbxnbrequipe / 2) + 70);
                this.Controls.Add(label);

                TextBox textBox = new TextBox();
                textBox.Location = new System.Drawing.Point(posX + 125, 50 * (i - nbrcbxnbrequipe / 2) + 70);
                textBox.Size = new System.Drawing.Size(100, 20);
                textBox.Name = "tbxnomequipe" + i.ToString(); // Nommer la TextBox de manière unique
                tbxequipe.Add(textBox);
                this.Controls.Add(textBox);

            }
        }
        public void AjouterEquipe()
        {
            for (int i = 0; i < tbxequipe.Count; i++) 
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
