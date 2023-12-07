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
    public partial class FrmInfoJoueurs : Form
    {
        //on déclare la liste de la classe pour récupérer les modification dans la classe de la form d'avant
        List<Joueur> joueurs = new List<Joueur>();
        List<Equipe> equipe = new List<Equipe>();
        //les variables pour récupérer les variables de la form d'avant
        public bool equipeTransmis;
        public string nombreJoueurTransmis;
        public FrmInfoJoueurs(string nombreDeJoueur, bool equipeVerif,List<Equipe> equipeClassTransmis )// on met les paramètre qui ont été transféré de la form d'avant
        {
            InitializeComponent();
            //on dit que chaque paramètre sont récupérer et stocker dans une variable
            equipeTransmis = equipeVerif;
            nombreJoueurTransmis = nombreDeJoueur;
            equipe = equipeClassTransmis;
        }


        private void lblJoueur2_Click(object sender, EventArgs e)
        {

        }


        private void FrmInfoJoueurs_Load_1(object sender, EventArgs e)//quand le form se charge
        {
            //on ajoute un joueur vide pour la liste pour que quand on ajoute des joueurs leur index commence à 1
            joueurs.Add(new Joueur("_blank", "Blank"));
            //on convertit le nombre de joueur transmis en int pour les calculs et les conditions
            int nombreJoueurTransmisInt = Convert.ToInt32(nombreJoueurTransmis);
            //tout les labels sont cachés
            lblJoueur1.Hide();
            lblJoueur2.Hide();
            lblJoueur3.Hide();
            lblJoueur4.Hide();
            lblJoueur5.Hide();
            lblJoueur6.Hide();
            lblJoueur7.Hide();
            lblJoueur8.Hide();
            lblJoueur9.Hide();
            lblJoueur10.Hide();
            lblJoueur11.Hide();
            lblJoueur12.Hide();
            //on cache les textbox
            tbxJoueur1.Hide();
            tbxJoueur1.Hide();
            tbxJoueur2.Hide();
            tbxJoueur3.Hide();
            tbxJoueur4.Hide();
            tbxJoueur5.Hide();
            tbxJoueur6.Hide();
            tbxJoueur7.Hide();
            tbxJoueur8.Hide();
            tbxJoueur9.Hide();
            tbxJoueur10.Hide();
            tbxJoueur11.Hide();
            tbxJoueur12.Hide();
            //condition pour afficher les élélments
            if (nombreJoueurTransmisInt == 2)//si il y a que 2 joueurs
            {
                //alors on affiche le nombre conséquent de label et textbox
                tbxJoueur1.Show();
                lblJoueur1.Show();
                tbxJoueur2.Show();
                lblJoueur2.Show();
            }
            else if (nombreJoueurTransmisInt == 3)//si il y a que 3 joueurs
            {
                //alors on affiche le nombre conséquent de label et textbox
                tbxJoueur1.Show();
                lblJoueur1.Show();
                tbxJoueur2.Show();
                lblJoueur2.Show();
                tbxJoueur3.Show();
                lblJoueur3.Show();
            }
            else if (nombreJoueurTransmisInt == 4)//si il y a que 4 joueurs
            {
                //alors on affiche le nombre conséquent de label et textbox
                tbxJoueur1.Show();
                lblJoueur1.Show();
                tbxJoueur2.Show();
                lblJoueur2.Show();
                tbxJoueur3.Show();
                lblJoueur3.Show();
                tbxJoueur4.Show();
                lblJoueur4.Show();
            }
            else if (nombreJoueurTransmisInt == 5)//si il y a que 5 joueurs
            {
                //alors on affiche le nombre conséquent de label et textbox
                tbxJoueur1.Show();
                lblJoueur1.Show();
                tbxJoueur2.Show();
                lblJoueur2.Show();
                tbxJoueur3.Show();
                lblJoueur3.Show();
                tbxJoueur4.Show();
                lblJoueur4.Show();
                tbxJoueur5.Show();
                lblJoueur5.Show();
            }
            else if (nombreJoueurTransmisInt == 6)//si il y a que 6 joueurs
            {
                //alors on affiche le nombre conséquent de label et textbox
                tbxJoueur1.Show();
                lblJoueur1.Show();
                tbxJoueur2.Show();
                lblJoueur2.Show();
                tbxJoueur3.Show();
                lblJoueur3.Show();
                tbxJoueur4.Show();
                lblJoueur4.Show();
                tbxJoueur5.Show();
                lblJoueur5.Show();
                tbxJoueur6.Show();
                lblJoueur6.Show();
            }
            else if (nombreJoueurTransmisInt == 7)//si il y a que 7 joueurs
            {
                //alors on affiche le nombre conséquent de label et textbox
                tbxJoueur1.Show();
                lblJoueur1.Show();
                tbxJoueur2.Show();
                lblJoueur2.Show();
                tbxJoueur3.Show();
                lblJoueur3.Show();
                tbxJoueur4.Show();
                lblJoueur4.Show();
                tbxJoueur5.Show();
                lblJoueur5.Show();
                tbxJoueur6.Show();
                lblJoueur6.Show();
                tbxJoueur7.Show();
                lblJoueur7.Show();
            }
            else if (nombreJoueurTransmisInt == 8)//si il y a que 8 joueurs
            {
                //alors on affiche le nombre conséquent de label et textbox
                tbxJoueur1.Show();
                lblJoueur1.Show();
                tbxJoueur2.Show();
                lblJoueur2.Show();
                tbxJoueur3.Show();
                lblJoueur3.Show();
                tbxJoueur4.Show();
                lblJoueur4.Show();
                tbxJoueur5.Show();
                lblJoueur5.Show();
                tbxJoueur6.Show();
                lblJoueur6.Show();
                tbxJoueur7.Show();
                lblJoueur7.Show();
                tbxJoueur8.Show();
                lblJoueur8.Show();
            }
            else if (nombreJoueurTransmisInt == 9)//si il y a que 9 joueurs
            {
                //alors on affiche le nombre conséquent de label et textbox
                tbxJoueur1.Show();
                lblJoueur1.Show();
                tbxJoueur2.Show();
                lblJoueur2.Show();
                tbxJoueur3.Show();
                lblJoueur3.Show();
                tbxJoueur4.Show();
                lblJoueur4.Show();
                tbxJoueur5.Show();
                lblJoueur5.Show();
                tbxJoueur6.Show();
                lblJoueur6.Show();
                tbxJoueur7.Show();
                lblJoueur7.Show();
                tbxJoueur8.Show();
                lblJoueur8.Show();
                tbxJoueur9.Show();
                lblJoueur9.Show();
            }
            else if (nombreJoueurTransmisInt == 10)//si il y a que 10 joueurs
            {
                //alors on affiche le nombre conséquent de label et textbox
                tbxJoueur1.Show();
                lblJoueur1.Show();
                tbxJoueur2.Show();
                lblJoueur2.Show();
                tbxJoueur3.Show();
                lblJoueur3.Show();
                tbxJoueur4.Show();
                lblJoueur4.Show();
                tbxJoueur5.Show();
                lblJoueur5.Show();
                tbxJoueur6.Show();
                lblJoueur6.Show();
                tbxJoueur7.Show();
                lblJoueur7.Show();
                tbxJoueur8.Show();
                lblJoueur8.Show();
                tbxJoueur9.Show();
                lblJoueur9.Show();
                tbxJoueur10.Show();
                lblJoueur10.Show();
            }
            else if (nombreJoueurTransmisInt == 11)//si il y a que 11 joueurs
            {
                //alors on affiche le nombre conséquent de label et textbox
                tbxJoueur1.Show();
                lblJoueur1.Show();
                tbxJoueur2.Show();
                lblJoueur2.Show();
                tbxJoueur3.Show();
                lblJoueur3.Show();
                tbxJoueur4.Show();
                lblJoueur4.Show();
                tbxJoueur5.Show();
                lblJoueur5.Show();
                tbxJoueur6.Show();
                lblJoueur6.Show();
                tbxJoueur7.Show();
                lblJoueur7.Show();
                tbxJoueur8.Show();
                lblJoueur8.Show();
                tbxJoueur9.Show();
                lblJoueur9.Show();
                tbxJoueur10.Show();
                lblJoueur10.Show();
                tbxJoueur11.Show();
                lblJoueur11.Show();
            }
            else if (nombreJoueurTransmisInt == 12)//si il y a que 12 joueurs
            {
                //alors on affiche le nombre conséquent de label et textbox
                tbxJoueur1.Show();
                lblJoueur1.Show();
                tbxJoueur2.Show();
                lblJoueur2.Show();
                tbxJoueur3.Show();
                lblJoueur3.Show();
                tbxJoueur4.Show();
                lblJoueur4.Show();
                tbxJoueur5.Show();
                lblJoueur5.Show();
                tbxJoueur6.Show();
                lblJoueur6.Show();
                tbxJoueur7.Show();
                lblJoueur7.Show();
                tbxJoueur8.Show();
                lblJoueur8.Show();
                tbxJoueur9.Show();
                lblJoueur9.Show();
                tbxJoueur10.Show();
                lblJoueur10.Show();
                tbxJoueur11.Show();
                lblJoueur11.Show();
                tbxJoueur12.Show();
                lblJoueur12.Show();
            }
            //on cache les combobox de base 
            cbxJoueur1.Hide();
            cbxJoueur2.Hide();
            cbxJoueur3.Hide();
            cbxJoueur4.Hide();
            cbxJoueur5.Hide();
            cbxJoueur6.Hide();
            cbxJoueur7.Hide();
            cbxJoueur8.Hide();
            cbxJoueur9.Hide();
            cbxJoueur10.Hide();
            cbxJoueur11.Hide();
            cbxJoueur12.Hide();
            //on ajoute les options de chaque combo box
            cbxJoueur1.Items.Add(equipe[1].NomEquipe);
            cbxJoueur1.Items.Add(equipe[2].NomEquipe);
            cbxJoueur1.Items.Add(equipe[3].NomEquipe);
            cbxJoueur1.Items.Add(equipe[4].NomEquipe);
            cbxJoueur1.Items.Add(equipe[5].NomEquipe);
            cbxJoueur1.Items.Add(equipe[6].NomEquipe);

            cbxJoueur2.Items.Add(equipe[1].NomEquipe);
            cbxJoueur2.Items.Add(equipe[2].NomEquipe);
            cbxJoueur2.Items.Add(equipe[3].NomEquipe);
            cbxJoueur2.Items.Add(equipe[4].NomEquipe);
            cbxJoueur2.Items.Add(equipe[5].NomEquipe);
            cbxJoueur2.Items.Add(equipe[6].NomEquipe);

            cbxJoueur3.Items.Add(equipe[1].NomEquipe);
            cbxJoueur3.Items.Add(equipe[2].NomEquipe);
            cbxJoueur3.Items.Add(equipe[3].NomEquipe);
            cbxJoueur3.Items.Add(equipe[4].NomEquipe);
            cbxJoueur3.Items.Add(equipe[5].NomEquipe);
            cbxJoueur3.Items.Add(equipe[6].NomEquipe);

            cbxJoueur4.Items.Add(equipe[1].NomEquipe);
            cbxJoueur4.Items.Add(equipe[2].NomEquipe);
            cbxJoueur4.Items.Add(equipe[3].NomEquipe);
            cbxJoueur4.Items.Add(equipe[4].NomEquipe);
            cbxJoueur4.Items.Add(equipe[5].NomEquipe);
            cbxJoueur4.Items.Add(equipe[6].NomEquipe);

            cbxJoueur5.Items.Add(equipe[1].NomEquipe);
            cbxJoueur5.Items.Add(equipe[2].NomEquipe);
            cbxJoueur5.Items.Add(equipe[3].NomEquipe);
            cbxJoueur5.Items.Add(equipe[4].NomEquipe);
            cbxJoueur5.Items.Add(equipe[5].NomEquipe);
            cbxJoueur5.Items.Add(equipe[6].NomEquipe);

            cbxJoueur6.Items.Add(equipe[1].NomEquipe);
            cbxJoueur6.Items.Add(equipe[2].NomEquipe);
            cbxJoueur6.Items.Add(equipe[3].NomEquipe);
            cbxJoueur6.Items.Add(equipe[4].NomEquipe);
            cbxJoueur6.Items.Add(equipe[5].NomEquipe);
            cbxJoueur6.Items.Add(equipe[6].NomEquipe);

            cbxJoueur7.Items.Add(equipe[1].NomEquipe);
            cbxJoueur7.Items.Add(equipe[2].NomEquipe);
            cbxJoueur7.Items.Add(equipe[3].NomEquipe);
            cbxJoueur7.Items.Add(equipe[4].NomEquipe);
            cbxJoueur7.Items.Add(equipe[5].NomEquipe);
            cbxJoueur7.Items.Add(equipe[6].NomEquipe);

            cbxJoueur8.Items.Add(equipe[1].NomEquipe);
            cbxJoueur8.Items.Add(equipe[2].NomEquipe);
            cbxJoueur8.Items.Add(equipe[3].NomEquipe);
            cbxJoueur8.Items.Add(equipe[4].NomEquipe);
            cbxJoueur8.Items.Add(equipe[5].NomEquipe);
            cbxJoueur8.Items.Add(equipe[6].NomEquipe);

            cbxJoueur9.Items.Add(equipe[1].NomEquipe);
            cbxJoueur9.Items.Add(equipe[2].NomEquipe);
            cbxJoueur9.Items.Add(equipe[3].NomEquipe);
            cbxJoueur9.Items.Add(equipe[4].NomEquipe);
            cbxJoueur9.Items.Add(equipe[5].NomEquipe);
            cbxJoueur9.Items.Add(equipe[6].NomEquipe);

            cbxJoueur10.Items.Add(equipe[1].NomEquipe);
            cbxJoueur10.Items.Add(equipe[2].NomEquipe);
            cbxJoueur10.Items.Add(equipe[3].NomEquipe);
            cbxJoueur10.Items.Add(equipe[4].NomEquipe);
            cbxJoueur10.Items.Add(equipe[5].NomEquipe);
            cbxJoueur10.Items.Add(equipe[6].NomEquipe);

            cbxJoueur11.Items.Add(equipe[1].NomEquipe);
            cbxJoueur11.Items.Add(equipe[2].NomEquipe);
            cbxJoueur11.Items.Add(equipe[3].NomEquipe);
            cbxJoueur11.Items.Add(equipe[4].NomEquipe);
            cbxJoueur11.Items.Add(equipe[5].NomEquipe);
            cbxJoueur11.Items.Add(equipe[6].NomEquipe);

            cbxJoueur12.Items.Add(equipe[1].NomEquipe);
            cbxJoueur12.Items.Add(equipe[2].NomEquipe);
            cbxJoueur12.Items.Add(equipe[3].NomEquipe);
            cbxJoueur12.Items.Add(equipe[4].NomEquipe);
            cbxJoueur12.Items.Add(equipe[5].NomEquipe);
            cbxJoueur12.Items.Add(equipe[6].NomEquipe);
            if (equipeTransmis == true & nombreJoueurTransmisInt == 2)//si la compétion est en équipe et qu'il y a 2 joueurs
            {
                //alors on affiche les combo box selon le nombre de joueurs
                cbxJoueur1.Show();
                cbxJoueur2.Show();

            }
            else if (equipeTransmis == true & nombreJoueurTransmisInt == 3)
            {
                //alors on affiche les combo box selon le nombre de joueurs
                cbxJoueur1.Show();
                cbxJoueur2.Show();
                cbxJoueur3.Show();


            }

            else if (equipeTransmis == true & nombreJoueurTransmisInt == 4)
            {
                //alors on affiche les combo box selon le nombre de joueurs
                cbxJoueur1.Show();
                cbxJoueur2.Show();
                cbxJoueur3.Show();
                cbxJoueur4.Show();
            }
            else if (equipeTransmis == true & nombreJoueurTransmisInt == 5)
            {
                //alors on affiche les combo box selon le nombre de joueurs
                cbxJoueur1.Show();
                cbxJoueur2.Show();
                cbxJoueur3.Show();
                cbxJoueur4.Show();
                cbxJoueur5.Show();


            }
            else if (equipeTransmis == true & nombreJoueurTransmisInt == 6)
            {
                //alors on affiche les combo box selon le nombre de joueurs
                cbxJoueur1.Show();
                cbxJoueur2.Show();
                cbxJoueur3.Show();
                cbxJoueur4.Show();
                cbxJoueur5.Show();
                cbxJoueur6.Show();


            }
            else if (equipeTransmis == true & nombreJoueurTransmisInt == 7)
            {
                //alors on affiche les combo box selon le nombre de joueurs
                cbxJoueur1.Show();
                cbxJoueur2.Show();
                cbxJoueur3.Show();
                cbxJoueur4.Show();
                cbxJoueur5.Show();
                cbxJoueur6.Show();
                cbxJoueur7.Show();

            }
            else if (equipeTransmis == true & nombreJoueurTransmisInt == 8)
            {
                //alors on affiche les combo box selon le nombre de joueurs
                cbxJoueur1.Show();
                cbxJoueur2.Show();
                cbxJoueur3.Show();
                cbxJoueur4.Show();
                cbxJoueur5.Show();
                cbxJoueur6.Show();
                cbxJoueur7.Show();
                cbxJoueur8.Show();

            }
            else if (equipeTransmis == true & nombreJoueurTransmisInt == 9)
            {
                //alors on affiche les combo box selon le nombre de joueurs
                cbxJoueur1.Show();
                cbxJoueur2.Show();
                cbxJoueur3.Show();
                cbxJoueur4.Show();
                cbxJoueur5.Show();
                cbxJoueur6.Show();
                cbxJoueur7.Show();
                cbxJoueur8.Show();
                cbxJoueur9.Show();

            }
            else if (equipeTransmis == true & nombreJoueurTransmisInt == 10)
            {
                //alors on affiche les combo box selon le nombre de joueurs
                cbxJoueur1.Show();
                cbxJoueur2.Show();
                cbxJoueur3.Show();
                cbxJoueur4.Show();
                cbxJoueur5.Show();
                cbxJoueur6.Show();
                cbxJoueur7.Show();
                cbxJoueur8.Show();
                cbxJoueur9.Show();
                cbxJoueur10.Show();

            }
            else if (equipeTransmis == true & nombreJoueurTransmisInt == 11)
            {
                //alors on affiche les combo box selon le nombre de joueurs
                cbxJoueur1.Show();
                cbxJoueur2.Show();
                cbxJoueur3.Show();
                cbxJoueur4.Show();
                cbxJoueur5.Show();
                cbxJoueur6.Show();
                cbxJoueur7.Show();
                cbxJoueur8.Show();
                cbxJoueur9.Show();
                cbxJoueur10.Show();
                cbxJoueur11.Show();

            }

            else if (equipeTransmis == true & nombreJoueurTransmisInt == 12)
            {
                //alors on affiche les combo box selon le nombre de joueurs
                cbxJoueur1.Show();
                cbxJoueur2.Show();
                cbxJoueur3.Show();
                cbxJoueur4.Show();
                cbxJoueur5.Show();
                cbxJoueur6.Show();
                cbxJoueur7.Show();
                cbxJoueur8.Show();
                cbxJoueur9.Show();
                cbxJoueur10.Show();
                cbxJoueur11.Show();
                cbxJoueur12.Show();
            }
        }

        private void btnValider_Click(object sender, EventArgs e) //evènement quand on clique sur le bouton
        {
            //on ajoute les nom de joueurs à la classe joueurs
            joueurs.Add(new Joueur(tbxJoueur1.Text, cbxJoueur1.Text));
            joueurs.Add(new Joueur(tbxJoueur2.Text, cbxJoueur2.Text));
            joueurs.Add(new Joueur(tbxJoueur3.Text, cbxJoueur3.Text));
            joueurs.Add(new Joueur(tbxJoueur4.Text, cbxJoueur4.Text));
            joueurs.Add(new Joueur(tbxJoueur5.Text, cbxJoueur5.Text));
            joueurs.Add(new Joueur(tbxJoueur6.Text, cbxJoueur6.Text));
            joueurs.Add(new Joueur(tbxJoueur7.Text, cbxJoueur7.Text));
            joueurs.Add(new Joueur(tbxJoueur8.Text, cbxJoueur8.Text));
            joueurs.Add(new Joueur(tbxJoueur9.Text, cbxJoueur9.Text));
            joueurs.Add(new Joueur(tbxJoueur10.Text, cbxJoueur10.Text));
            joueurs.Add(new Joueur(tbxJoueur11.Text, cbxJoueur11.Text));
            joueurs.Add(new Joueur(tbxJoueur12.Text, cbxJoueur12.Text));
            this.Hide(); //on cache
            if (equipeTransmis == true)//si la compétition est en équipe
            {
                //alors on affiche la form pour les information sur les équipes
                Frminfoequipe frminfoequipe = new Frminfoequipe(equipe, joueurs, nombreJoueurTransmis);//création d'une nouvelle form//
                frminfoequipe.ShowDialog();
            }
            else //sinon (si la compétition est en solo)
            {
                //on passe directement à la page du système de points
                FrmSystPoint frmSystPoint = new FrmSystPoint();//création d'une nouvelle form//
                frmSystPoint.ShowDialog();
            }
        }
    }
}
