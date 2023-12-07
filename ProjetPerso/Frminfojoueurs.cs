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
            for (int i = 1; i <= nombreJoueurTransmisInt / 2 ;i++ )
            {
                int posX = 180;
                // Créer un Label
                Label label = new Label();
                label.Text = "Joueur" + i.ToString();
                label.Name = "lblJoueur" + i.ToString();
                label.Location = new System.Drawing.Point(posX + 25, 50 * i + 30);
                this.Controls.Add(label);

                TextBox textBox = new TextBox();
                textBox.Location = new System.Drawing.Point(posX + 125, 50 * i + 30);
                textBox.Size = new System.Drawing.Size(100, 20);
                textBox.Name = "tbxJoueur" + i.ToString(); // Nommer la TextBox de manière unique
                this.Controls.Add(textBox);

                // Créer une ComboBox
                ComboBox comboBox = new ComboBox();
                comboBox.Items.Add(equipe[1].NomEquipe);
                comboBox.Items.Add(equipe[2].NomEquipe);
                comboBox.Items.Add(equipe[3].NomEquipe);
                comboBox.Items.Add(equipe[4].NomEquipe);
                comboBox.Items.Add(equipe[5].NomEquipe);
                comboBox.Items.Add(equipe[6].NomEquipe);
                comboBox.Location = new System.Drawing.Point(posX + 245, 50 * i + 30);
                comboBox.Size = new System.Drawing.Size(100, 20);
                comboBox.Name = "cbxJoueur" + i.ToString(); // Nommer la ComboBox de manière unique
                this.Controls.Add(comboBox);
            }
            int posY = 80;
            for (int i = nombreJoueurTransmisInt / 2 + 1; i <= nombreJoueurTransmisInt; i++)
            {
                int posX = 600;
                // Créer un Label
                Label label = new Label();
                label.Text = "Joueur" + i.ToString();
                label.Name = "lblJoueur" + i.ToString();
                label.Location = new System.Drawing.Point(posX + 25, posY);
                this.Controls.Add(label);

                TextBox textBox = new TextBox();
                textBox.Location = new System.Drawing.Point(posX + 125, posY);
                textBox.Size = new System.Drawing.Size(100, 20);
                textBox.Name = "tbxJoueur" + i.ToString(); // Nommer la TextBox de manière unique
                this.Controls.Add(textBox);

                // Créer une ComboBox
                ComboBox comboBox = new ComboBox();
                comboBox.Items.Add(equipe[1].NomEquipe);
                comboBox.Items.Add(equipe[2].NomEquipe);
                comboBox.Items.Add(equipe[3].NomEquipe);
                comboBox.Items.Add(equipe[4].NomEquipe);
                comboBox.Items.Add(equipe[5].NomEquipe);
                comboBox.Items.Add(equipe[6].NomEquipe);
                comboBox.Location = new System.Drawing.Point(posX + 245, posY);
                comboBox.Size = new System.Drawing.Size(100, 20);
                comboBox.Name = "cbxJoueur" + i.ToString(); // Nommer la ComboBox de manière unique
                this.Controls.Add(comboBox);
                posY = posY + 50;
            }
        }

        private void btnValider_Click(object sender, EventArgs e) //evènement quand on clique sur le bouton
        {
            //on ajoute les nom de joueurs à la classe joueurs

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
                FrmSystPoint frmSystPoint = new FrmSystPoint(equipe, joueurs, nombreJoueurTransmis);//création d'une nouvelle form//
                frmSystPoint.ShowDialog();
            }
        }
    }
}
