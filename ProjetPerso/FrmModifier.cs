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
    public partial class FrmModifier : Form
    {
        List<Joueur> joueurs = new List<Joueur>();
        List<Equipe> equipe = new List<Equipe>();
        public string nombreJoueur;
        public FrmModifier(List<Equipe> equipeTransmis, List<Joueur> joueursTransmis, string nombreJoueurTranmsis)
        {
            InitializeComponent();
            nombreJoueur = nombreJoueurTranmsis;
            equipe = equipeTransmis;
            joueurs = joueursTransmis;
        }

        private void FrmModifier_Load(object sender, EventArgs e)
        {
            //on convertit le nombre de joueur transmis en int pour les calculs et les conditions
            int nombreJoueurTransmisInt = Convert.ToInt32(nombreJoueur);
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
            //condition pour afficher les élélments
            if (nombreJoueurTransmisInt == 2)//si il y a que 2 joueurs
            {
                //alors on affiche le nombre conséquent de label et textbox
                lblJoueur1.Show();
                lblJoueur2.Show();
            }
            else if (nombreJoueurTransmisInt == 3)//si il y a que 3 joueurs
            {
                //alors on affiche le nombre conséquent de label et textbox
                lblJoueur1.Show();
                lblJoueur2.Show();
                lblJoueur3.Show();
            }
            else if (nombreJoueurTransmisInt == 4)//si il y a que 4 joueurs
            {
                //alors on affiche le nombre conséquent de label et textbox
                lblJoueur1.Show();
                lblJoueur2.Show();
                lblJoueur3.Show();
                lblJoueur4.Show();
            }
            else if (nombreJoueurTransmisInt == 5)//si il y a que 5 joueurs
            {
                //alors on affiche le nombre conséquent de label et textbox
                lblJoueur1.Show();
                lblJoueur2.Show();
                lblJoueur3.Show();
                lblJoueur4.Show();
                lblJoueur5.Show();
            }
            else if (nombreJoueurTransmisInt == 6)//si il y a que 6 joueurs
            {
                //alors on affiche le nombre conséquent de label et textbox
                lblJoueur1.Show();
                lblJoueur2.Show();
                lblJoueur3.Show();
                lblJoueur4.Show();
                lblJoueur5.Show();
                lblJoueur6.Show();
            }
            else if (nombreJoueurTransmisInt == 7)//si il y a que 7 joueurs
            {
                //alors on affiche le nombre conséquent de label et textbox
                lblJoueur1.Show();
                lblJoueur2.Show();
                lblJoueur3.Show();
                lblJoueur4.Show();
                lblJoueur5.Show();
                lblJoueur6.Show();
                lblJoueur7.Show();
            }
            else if (nombreJoueurTransmisInt == 8)//si il y a que 8 joueurs
            {
                //alors on affiche le nombre conséquent de label et textbox
                lblJoueur1.Show();
                lblJoueur2.Show();
                lblJoueur3.Show();
                lblJoueur4.Show();
                lblJoueur5.Show();
                lblJoueur6.Show();
                lblJoueur7.Show();
                lblJoueur8.Show();
            }
            else if (nombreJoueurTransmisInt == 9)//si il y a que 9 joueurs
            {
                //alors on affiche le nombre conséquent de label et textbox
                lblJoueur1.Show();
                lblJoueur2.Show();
                lblJoueur3.Show();
                lblJoueur4.Show();
                lblJoueur5.Show();
                lblJoueur6.Show();
                lblJoueur7.Show();
                lblJoueur8.Show();
                lblJoueur9.Show();
            }
            else if (nombreJoueurTransmisInt == 10)//si il y a que 10 joueurs
            {
                //alors on affiche le nombre conséquent de label et textbox
                lblJoueur1.Show();
                lblJoueur2.Show();
                lblJoueur3.Show();
                lblJoueur4.Show();
                lblJoueur5.Show();
                lblJoueur6.Show();
                lblJoueur7.Show();
                lblJoueur8.Show();
                lblJoueur9.Show();
                lblJoueur10.Show();
            }
            else if (nombreJoueurTransmisInt == 11)//si il y a que 11 joueurs
            {
                //alors on affiche le nombre conséquent de label et textbox
                lblJoueur1.Show();
                lblJoueur2.Show();
                lblJoueur3.Show();
                lblJoueur4.Show();
                lblJoueur5.Show();
                lblJoueur6.Show();
                lblJoueur7.Show();
                lblJoueur8.Show();
                lblJoueur9.Show();
                lblJoueur10.Show();
                lblJoueur11.Show();
            }
            else if (nombreJoueurTransmisInt == 12)//si il y a que 12 joueurs
            {
                //alors on affiche le nombre conséquent de label et textbox
                lblJoueur1.Show();
                lblJoueur2.Show();
                lblJoueur3.Show();
                lblJoueur4.Show();
                lblJoueur5.Show();
                lblJoueur6.Show();
                lblJoueur7.Show();
                lblJoueur8.Show();
                lblJoueur9.Show();
                lblJoueur10.Show();
                lblJoueur11.Show();
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

            if (nombreJoueurTransmisInt == 2)//si la compétion est en équipe et qu'il y a 2 joueurs
            {
                //alors on affiche les combo box selon le nombre de joueurs
                cbxJoueur1.Show();
                cbxJoueur2.Show();

            }
            else if (nombreJoueurTransmisInt == 3)
            {
                //alors on affiche les combo box selon le nombre de joueurs
                cbxJoueur1.Show();
                cbxJoueur2.Show();
                cbxJoueur3.Show();


            }

            else if (nombreJoueurTransmisInt == 4)
            {
                //alors on affiche les combo box selon le nombre de joueurs
                cbxJoueur1.Show();
                cbxJoueur2.Show();
                cbxJoueur3.Show();
                cbxJoueur4.Show();
            }
            else if (nombreJoueurTransmisInt == 5)
            {
                //alors on affiche les combo box selon le nombre de joueurs
                cbxJoueur1.Show();
                cbxJoueur2.Show();
                cbxJoueur3.Show();
                cbxJoueur4.Show();
                cbxJoueur5.Show();


            }
            else if (nombreJoueurTransmisInt == 6)
            {
                //alors on affiche les combo box selon le nombre de joueurs
                cbxJoueur1.Show();
                cbxJoueur2.Show();
                cbxJoueur3.Show();
                cbxJoueur4.Show();
                cbxJoueur5.Show();
                cbxJoueur6.Show();


            }
            else if (nombreJoueurTransmisInt == 7)
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
            else if (nombreJoueurTransmisInt == 8)
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
            else if (nombreJoueurTransmisInt == 9)
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
            else if (nombreJoueurTransmisInt == 10)
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
            else if (nombreJoueurTransmisInt == 11)
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

            else if (nombreJoueurTransmisInt == 12)
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
    }
}
