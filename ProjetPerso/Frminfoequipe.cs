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
        string nombrejoueur;
        public Frminfoequipe(List<Equipe> equipe1, List<Joueur> joueur1 ,string nombreJoueurTransmis) //création de la nouvelle form //
        {
            InitializeComponent();
            equipe = equipe1;
            joueur = joueur1;
            nombrejoueur = nombreJoueurTransmis;
        }

        private void Frminfoequipe_Load(object sender, EventArgs e) //quand la form apparait a l'écrant //
        {

            int nombreDeJoueur = Convert.ToInt32(nombrejoueur);
            int nombreEquipe = equipe.Count -1;

            for (int i = 1; i <= nombreEquipe / 2; i++)
            {
                int posX = 250;
                Label label = new Label();
                label.Text = equipe[i].NomEquipe;
                label.Name = "lblEquipeHaut" + i.ToString();
                label.Location = new System.Drawing.Point(posX * i, 50);
                this.Controls.Add(label);
            }
            for (int i = nombreEquipe / 2 +1; i <= nombreEquipe; i++)
            {
                int posX = 250;
                Label label = new Label();
                label.Text = equipe[i].NomEquipe;
                label.Name = "lblEquipeBas" + i.ToString();
                label.Location = new System.Drawing.Point(posX * (i -3), 250);
                this.Controls.Add(label);
             }
            

            /*
            for (int i = 1; i < nombreDeJoueur; i++)
            {
                if (joueur[i].NomEquipe == equipe[1].NomEquipe) // si le joueur appartient a l'équipe 1 //
                {
                    if (lbljoueur1equip1.Text == "") //si le lbl joueur1 equipe 1 est vide //
                    { lbljoueur1equip1.Text = joueur[i].Nom; } //je met alors le nom du joueur a la place //
                    else if (lbljoueur2equip1.Text == "")
                    { lbljoueur2equip1.Text = joueur[i].Nom; }
                    else if (lbljoueur3equip1.Text == "")
                    { lbljoueur3equip1.Text = joueur[i].Nom; }
                    else if (lbljoueur4equip1.Text == "")
                    { lbljoueur4equip1.Text = joueur[i].Nom; }
                    else if (lbljoueur5equip1.Text == "")
                    { lbljoueur5equip1.Text = joueur[i].Nom; }
                    else if (lbljoueur6equip1.Text == "")
                    { lbljoueur6equip1.Text = joueur[i].Nom; }
                }
                else if (joueur[i].NomEquipe == equipe[2].NomEquipe) // si le joueur appartient a l'équipe 2 //
                {
                    if (lbljoueur1equip2.Text == "")
                    { lbljoueur1equip2.Text = joueur[i].Nom; }
                    else if (lbljoueur2equip2.Text == "")
                    { lbljoueur2equip2.Text = joueur[i].Nom; }
                    else if (lbljoueur3equip2.Text == "")
                    { lbljoueur3equip2.Text = joueur[i].Nom; }
                    else if (lbljoueur4equip2.Text == "")
                    { lbljoueur4equip2.Text = joueur[i].Nom; }
                    else if (lbljoueur5equip2.Text == "")
                    { lbljoueur5equip2.Text = joueur[i].Nom; }
                    else if (lbljoueur6equip2.Text == "")
                    { lbljoueur6equip2.Text = joueur[i].Nom; }
                }
                else if (joueur[i].NomEquipe == equipe[3].NomEquipe) // si le joueur appartient a l'équipe 3 //
                {
                    if (lbljoueur1equip3.Text == "")
                    { lbljoueur1equip3.Text = joueur[i].Nom; }
                    else if (lbljoueur2equip3.Text == "")
                    { lbljoueur2equip3.Text = joueur[i].Nom; }
                    else if (lbljoueur3equip3.Text == "")
                    { lbljoueur3equip3.Text = joueur[i].Nom; }
                    else if (lbljoueur4equip3.Text == "")
                    { lbljoueur4equip3.Text = joueur[i].Nom; }
                    else if (lbljoueur5equip3.Text == "")
                    { lbljoueur5equip3.Text = joueur[i].Nom; }
                    else if (lbljoueur6equip3.Text == "")
                    { lbljoueur6equip3.Text = joueur[i].Nom; }
                }
                else if (joueur[i].NomEquipe == equipe[4].NomEquipe) // si le joueur appartient a l'équipe 4 //
                {
                    if (lbljoueur1equip4.Text == "")
                    { lbljoueur1equip4.Text = joueur[i].Nom; }
                    else if (lbljoueur2equip4.Text == "")
                    { lbljoueur2equip4.Text = joueur[i].Nom; }
                    else if (lbljoueur3equip4.Text == "")
                    { lbljoueur3equip4.Text = joueur[i].Nom; }
                    else if (lbljoueur4equip4.Text == "")
                    { lbljoueur4equip4.Text = joueur[i].Nom; }
                    else if (lbljoueur5equip4.Text == "")
                    { lbljoueur5equip4.Text = joueur[i].Nom; }
                    else if (lbljoueur6equip4.Text == "")
                    { lbljoueur6equip4.Text = joueur[i].Nom; }
                }
                else if (joueur[i].NomEquipe == equipe[5].NomEquipe) // si le joueur appartient a l'équipe 5 //
                {
                    if (lbljoueur1equip5.Text == "")
                    { lbljoueur1equip5.Text = joueur[i].Nom; }
                    else if (lbljoueur2equip5.Text == "")
                    { lbljoueur2equip5.Text = joueur[i].Nom; }
                    else if (lbljoueur3equip5.Text == "")
                    { lbljoueur3equip5.Text = joueur[i].Nom; }
                    else if (lbljoueur4equip5.Text == "")
                    { lbljoueur4equip5.Text = joueur[i].Nom; }
                    else if (lbljoueur5equip5.Text == "")
                    { lbljoueur5equip5.Text = joueur[i].Nom; }
                    else if (lbljoueur6equip5.Text == "")
                    { lbljoueur6equip5.Text = joueur[i].Nom; }
                }
                else if (joueur[i].NomEquipe == equipe[6].NomEquipe) // si le joueur appartient a l'équipe 6 //
                {
                    if (lbljoueur1equip6.Text == "")
                    { lbljoueur1equip6.Text = joueur[i].Nom; }
                    else if (lbljoueur2equip6.Text == "")
                    { lbljoueur2equip6.Text = joueur[i].Nom; }
                    else if (lbljoueur3equip6.Text == "")
                    { lbljoueur3equip6.Text = joueur[i].Nom; }
                    else if (lbljoueur4equip6.Text == "")
                    { lbljoueur4equip6.Text = joueur[i].Nom; }
                    else if (lbljoueur5equip6.Text == "")
                    { lbljoueur5equip6.Text = joueur[i].Nom; }
                    else if (lbljoueur6equip6.Text == "")
                    { lbljoueur6equip6.Text = joueur[i].Nom; }
                }
            }
            */


        }
        private void btnModifier_Click(object sender, EventArgs e) //si on clique sur le bouton modifier//
        {
            FrmModifier Frmmodifier = new FrmModifier(equipe , joueur, nombrejoueur);// crée une nouvelle form //
            Frmmodifier.ShowDialog();
            this.Hide();//cache la form acctuelle //
        }

        private void btnValider_Click(object sender, EventArgs e) //si on clique sur le bouton valider //
        {
            FrmSystPoint Frmsystpoint = new FrmSystPoint(equipe, joueur, nombrejoueur);// crée une nouvelle form //
            Frmsystpoint.ShowDialog();
            this.Hide();//cache la form acctuelle //
        }
    }
}
