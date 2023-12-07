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
    public partial class Frminfoequipe : Form
    {
        List<Equipe> equipe = new List<Equipe>();
        List<Joueur> joueur = new List<Joueur>();
        public Frminfoequipe()
        {
            InitializeComponent();
        }

        private void Frminfoequipe_Load(object sender, EventArgs e)
        {
            lblequipe1.Hide();
            lblequipe2.Hide();
            lblequipe3.Hide();
            lblequipe4.Hide();
            lblequipe5.Hide();
            lblequipe6.Hide();
            lbljoueur1equip1.Hide();
            lbljoueur2equip1.Hide();
            lbljoueur3equip1.Hide();
            lbljoueur4equip1.Hide();
            lbljoueur5equip1.Hide();
            lbljoueur6equip1.Hide();
            lbljoueur1equip2.Hide();
            lbljoueur2equip2.Hide();
            lbljoueur3equip2.Hide();
            lbljoueur4equip2.Hide();
            lbljoueur5equip2.Hide();
            lbljoueur6equip2.Hide();
            lbljoueur1equip3.Hide();
            lbljoueur2equip3.Hide();
            lbljoueur3equip3.Hide();
            lbljoueur4equip3.Hide();
            lbljoueur5equip3.Hide();
            lbljoueur6equip3.Hide();
            lbljoueur1equip4.Hide();
            lbljoueur2equip4.Hide();
            lbljoueur3equip4.Hide();
            lbljoueur4equip4.Hide();
            lbljoueur5equip4.Hide();
            lbljoueur6equip4.Hide();
            lbljoueur1equip5.Hide();
            lbljoueur2equip5.Hide();
            lbljoueur3equip5.Hide();
            lbljoueur4equip5.Hide();
            lbljoueur5equip5.Hide();
            lbljoueur6equip5.Hide();
            lbljoueur1equip6.Hide();
            lbljoueur2equip6.Hide();
            lbljoueur3equip6.Hide();
            lbljoueur4equip6.Hide();
            lbljoueur5equip6.Hide();
            lbljoueur6equip6.Hide();

            lblequipe1.Text = equipe[1].NomEquipe;
            lblequipe2.Text = equipe[2].NomEquipe;
            lblequipe3.Text = equipe[3].NomEquipe;
            lblequipe4.Text = equipe[4].NomEquipe;
            lblequipe5.Text = equipe[5].NomEquipe;
            lblequipe6.Text = equipe[6].NomEquipe;
            for (int i = 1; i < 10; i++)
            {
                if (joueur[i].NomEquipe == equipe[1].NomEquipe)
                {
                    if (lbljoueur1equip1.Text == null)
                    {lbljoueur1equip1.Text = joueur[i].Nom;}
                    else if (lbljoueur2equip1.Text == null)
                    { lbljoueur2equip1.Text = joueur[i].Nom; }
                    else if (lbljoueur3equip1.Text == null)
                    { lbljoueur3equip1.Text = joueur[i].Nom; }
                    else if (lbljoueur4equip1.Text == null)
                    { lbljoueur4equip1.Text = joueur[i].Nom; }
                    else if (lbljoueur5equip1.Text == null)
                    { lbljoueur5equip1.Text = joueur[i].Nom; }
                    else if (lbljoueur6equip1.Text == null)
                    { lbljoueur6equip1.Text = joueur[i].Nom;}
                }
                else if (joueur[i].NomEquipe == equipe[2].NomEquipe)
                {
                    if (lbljoueur1equip2.Text == null)
                    { lbljoueur1equip2.Text = joueur[i].Nom; }
                    else if (lbljoueur2equip2.Text == null)
                    { lbljoueur2equip2.Text = joueur[i].Nom; }
                    else if (lbljoueur3equip2.Text == null)
                    { lbljoueur3equip2.Text = joueur[i].Nom; }
                    else if (lbljoueur4equip2.Text == null)
                    { lbljoueur4equip2.Text = joueur[i].Nom; }
                    else if (lbljoueur5equip2.Text == null)
                    { lbljoueur5equip2.Text = joueur[i].Nom; }
                    else if (lbljoueur6equip2.Text == null)
                    { lbljoueur6equip2.Text = joueur[i].Nom; }
                    
                    lbljoueur2equip2.Text = joueur[i].Nom;      
                    lbljoueur3equip2.Text = joueur[i].Nom;
                    lbljoueur4equip2.Text = joueur[i].Nom;
                    lbljoueur5equip2.Text = joueur[i].Nom;
                    lbljoueur6equip2.Text = joueur[i].Nom;
                }
                else if (joueur[i].NomEquipe == equipe[3].NomEquipe)
                {
                    lbljoueur1equip3.Text = joueur[i].Nom;
                    lbljoueur2equip3.Text = joueur[i].Nom;
                    lbljoueur3equip3.Text = joueur[i].Nom;
                    lbljoueur4equip3.Text = joueur[i].Nom;
                    lbljoueur5equip3.Text = joueur[i].Nom;
                    lbljoueur6equip3.Text = joueur[i].Nom;
                }
                else if (joueur[i].NomEquipe == equipe[3].NomEquipe)
                {
                    lbljoueur1equip4.Text = joueur[i].Nom;
                    lbljoueur2equip4.Text = joueur[i].Nom;
                    lbljoueur3equip4.Text = joueur[i].Nom;
                    lbljoueur4equip4.Text = joueur[i].Nom;
                    lbljoueur5equip4.Text = joueur[i].Nom;
                    lbljoueur6equip4.Text = joueur[i].Nom;
                }
                else if (joueur[i].NomEquipe == equipe[3].NomEquipe)
                {
                    lbljoueur1equip5.Text = joueur[i].Nom;
                    lbljoueur2equip5.Text = joueur[i].Nom;
                    lbljoueur3equip5.Text = joueur[i].Nom;
                    lbljoueur4equip5.Text = joueur[i].Nom;
                    lbljoueur5equip5.Text = joueur[i].Nom;
                    lbljoueur6equip5.Text = joueur[i].Nom;
                }
                else if (joueur[i].NomEquipe == equipe[3].NomEquipe)
                {
                    lbljoueur1equip6.Text = joueur[i].Nom;
                    lbljoueur2equip6.Text = joueur[i].Nom;
                    lbljoueur3equip6.Text = joueur[i].Nom;
                    lbljoueur4equip6.Text = joueur[i].Nom;
                    lbljoueur5equip6.Text = joueur[i].Nom;
                    lbljoueur6equip6.Text = joueur[i].Nom;
                }
            }
            int nombreEquipe = 1;
                if(nombreEquipe == 2) 
            {

                lblequipe1.Show();
                lblequipe2.Show();
                lbljoueur1equip1.Show();
                lbljoueur2equip1.Show();
                lbljoueur3equip1.Show();
                lbljoueur4equip1.Show();
                lbljoueur5equip1.Show();
                lbljoueur6equip1.Show();
                lbljoueur1equip2.Show();
                lbljoueur2equip2.Show();
                lbljoueur3equip2.Show();
                lbljoueur4equip2.Show();
                lbljoueur5equip2.Show();
                lbljoueur6equip2.Show();
                lbljoueur1equip3.Show();
                lbljoueur2equip3.Show();
                lbljoueur3equip3.Show();
                lbljoueur4equip3.Show();
                lbljoueur5equip3.Show();
                lbljoueur6equip3.Show();

            }
                else if (nombreEquipe == 3)
            {
                lblequipe1.Show();
                lblequipe2.Show();
                lblequipe3.Show();
                lbljoueur1equip1.Show();
                lbljoueur2equip1.Show();
                lbljoueur3equip1.Show();
                lbljoueur4equip1.Show();
                lbljoueur5equip1.Show();
                lbljoueur6equip1.Show();
                lbljoueur1equip2.Show();
                lbljoueur2equip2.Show();
                lbljoueur3equip2.Show();
                lbljoueur4equip2.Show();
                lbljoueur5equip2.Show();
                lbljoueur6equip2.Show();
                lbljoueur1equip3.Show();
                lbljoueur2equip3.Show();
                lbljoueur3equip3.Show();
                lbljoueur4equip3.Show();
                lbljoueur5equip3.Show();
                lbljoueur6equip3.Show();

            }
                else if (nombreEquipe == 4)
            {
                lblequipe1.Show();
                lblequipe2.Show();
                lblequipe3.Show(); 
                lblequipe4.Show();
                lbljoueur1equip1.Show();
                lbljoueur2equip1.Show();
                lbljoueur3equip1.Show();
                lbljoueur4equip1.Show();
                lbljoueur5equip1.Show();
                lbljoueur6equip1.Show();
                lbljoueur1equip2.Show();
                lbljoueur2equip2.Show();
                lbljoueur3equip2.Show();
                lbljoueur4equip2.Show();
                lbljoueur5equip2.Show();
                lbljoueur6equip2.Show();
                lbljoueur1equip3.Show();
                lbljoueur2equip3.Show();
                lbljoueur3equip3.Show();
                lbljoueur4equip3.Show();
                lbljoueur5equip3.Show();
                lbljoueur6equip3.Show();
                lbljoueur1equip4.Show();
                lbljoueur2equip4.Show();
                lbljoueur3equip4.Show();
                lbljoueur4equip4.Show();
                lbljoueur5equip4.Show();
                lbljoueur6equip4.Show();

            }
            else if (nombreEquipe == 5)
            {
                lblequipe1.Show();
                lblequipe2.Show();
                lblequipe3.Show();
                lblequipe4.Show();
                lblequipe5.Show();
                lbljoueur1equip1.Show();
                lbljoueur2equip1.Show();
                lbljoueur3equip1.Show();
                lbljoueur4equip1.Show();
                lbljoueur5equip1.Show();
                lbljoueur6equip1.Show();
                lbljoueur1equip2.Show();
                lbljoueur2equip2.Show();
                lbljoueur3equip2.Show();
                lbljoueur4equip2.Show();
                lbljoueur5equip2.Show();
                lbljoueur6equip2.Show();
                lbljoueur1equip3.Show();
                lbljoueur2equip3.Show();
                lbljoueur3equip3.Show();
                lbljoueur4equip3.Show();
                lbljoueur5equip3.Show();
                lbljoueur6equip3.Show();
                lbljoueur1equip4.Show();
                lbljoueur2equip4.Show();
                lbljoueur3equip4.Show();
                lbljoueur4equip4.Show();
                lbljoueur5equip4.Show();
                lbljoueur6equip4.Show();
                lbljoueur1equip5.Show();
                lbljoueur2equip5.Show();
                lbljoueur3equip5.Show();
                lbljoueur4equip5.Show();
                lbljoueur5equip5.Show();
                lbljoueur6equip5.Show();


            }
            else if (nombreEquipe == 6)
            {
                lblequipe1.Show();
                lblequipe2.Show();
                lblequipe3.Show();
                lblequipe4.Show();
                lblequipe5.Show();
                lblequipe6.Show();
                lbljoueur1equip1.Show();
                lbljoueur2equip1.Show();
                lbljoueur3equip1.Show();
                lbljoueur4equip1.Show();
                lbljoueur5equip1.Show();
                lbljoueur6equip1.Show();
                lbljoueur1equip2.Show();
                lbljoueur2equip2.Show();
                lbljoueur3equip2.Show();
                lbljoueur4equip2.Show();
                lbljoueur5equip2.Show();
                lbljoueur6equip2.Show();
                lbljoueur1equip3.Show();
                lbljoueur2equip3.Show();
                lbljoueur3equip3.Show();
                lbljoueur4equip3.Show();
                lbljoueur5equip3.Show();
                lbljoueur6equip3.Show();
                lbljoueur1equip4.Show();
                lbljoueur2equip4.Show();
                lbljoueur3equip4.Show();
                lbljoueur4equip4.Show();
                lbljoueur5equip4.Show();
                lbljoueur6equip4.Show();
                lbljoueur1equip5.Show();
                lbljoueur2equip5.Show();
                lbljoueur3equip5.Show();
                lbljoueur4equip5.Show();
                lbljoueur5equip5.Show();
                lbljoueur6equip5.Show();
                lbljoueur1equip6.Show();
                lbljoueur2equip6.Show();
                lbljoueur3equip6.Show();
                lbljoueur4equip6.Show();
                lbljoueur5equip6.Show();
                lbljoueur6equip6.Show();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            FrmModifier Frmmodifier = new FrmModifier();
            Frmmodifier.ShowDialog();
            this.Hide();//cache la form acctuelle //
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            FrmParaduclassement Frmparaduclassement = new FrmParaduclassement();
            Frmparaduclassement.ShowDialog();
            this.Hide();//cache la form acctuelle //
        }
    }
}
