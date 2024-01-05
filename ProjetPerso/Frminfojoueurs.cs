using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        List<TextBox> listTextbox = new List<TextBox>();
        List<ComboBox> listCombobox = new List<ComboBox>();
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
            cbxNone.Hide();
            tbxNone.Hide();
            //on ajoute un joueur vide pour la liste pour que quand on ajoute des joueurs leur index commence à 1
            listCombobox.Add(cbxNone);
            listTextbox.Add(tbxNone);
            //on convertit le nombre de joueur transmis en int pour les calculs et les conditions
            int nombreJoueurTransmisInt = Convert.ToInt32(nombreJoueurTransmis);
            for (int i = 1; i <= nombreJoueurTransmisInt / 2 ;i++ )
            {
                int posX = 180;
                // Créer un Label
                Label label = new Label();
                //le texte que va contenir le label serait une indication sur quel joueur
                label.Text = "Joueur" + i.ToString();
                label.Name = "lblJoueur" + i.ToString();
                //o définit la position
                label.Location = new System.Drawing.Point(posX + 25, 50 * i + 30);
                this.Controls.Add(label);

                //on ajoute une nouvelle textbox
                TextBox textBoxJoueur = new TextBox();
                //on définit la position
                textBoxJoueur.Location = new System.Drawing.Point(posX + 125, 50 * i + 30);
                textBoxJoueur.Size = new System.Drawing.Size(100, 20);
                textBoxJoueur.Name = "tbxJoueur" + i.ToString(); // Nommer la TextBox de manière unique
                //on l'ajoute à la liste des textbox
                listTextbox.Add(textBoxJoueur);
                this.Controls.Add(textBoxJoueur);

                // Créer une ComboBox
                if (equipeTransmis == true)
                {
                    //on créer la combobox
                    ComboBox comboBoxJoueur = new ComboBox();
                    //on ajoute les équipes à l'intérieur
                    for (int f = 0; f <= equipe.Count - 1; f++)
                    {
                        comboBoxJoueur.Items.Add(equipe[f].NomEquipe);
                    }
                    //on définit sa position
                    comboBoxJoueur.Location = new System.Drawing.Point(posX + 245, 50 * i + 30);
                    comboBoxJoueur.Size = new System.Drawing.Size(100, 20);
                    comboBoxJoueur.Name = "cbxJoueur" + i.ToString(); // Nommer la ComboBox de manière unique
                    //on ajoute la combobox à la liste des combobox
                    listCombobox.Add(comboBoxJoueur);
                    this.Controls.Add(comboBoxJoueur);
                }



            }
            //on créer une variable pour la cordonnée Y de la position
            int posY = 80;
            //boucle pour que cela place l'autre moitié des éléments
            for (int i = nombreJoueurTransmisInt / 2 + 1; i <= nombreJoueurTransmisInt; i++)
            {
                int posX = 600;
                // Créer un Label
                Label label = new Label();
                //le texte du label va indiquer quel joueur nous sommes entrain d'ajouter
                label.Text = "Joueur" + i.ToString();
                label.Name = "lblJoueur" + i.ToString();
                label.Location = new System.Drawing.Point(posX + 25, posY);
                this.Controls.Add(label);
                //on créer une nouvelle textebox
                TextBox textBoxJoueur = new TextBox();
                //on indique la position de l'élément
                textBoxJoueur.Location = new System.Drawing.Point(posX + 125, posY);
                textBoxJoueur.Size = new System.Drawing.Size(100, 20);
                textBoxJoueur.Name = "tbxJoueur" + i.ToString(); // Nommer la TextBox de manière unique
                //on ajoute la textbox à la liste de textbox
                listTextbox.Add(textBoxJoueur);
                this.Controls.Add(textBoxJoueur);

                // Créer une ComboBox
                if (equipeTransmis == true)
                {
                    //une nouvelle combobox
                    ComboBox comboBoxJoueur = new ComboBox();
                    //on va ajoute les équipes à la combobox
                    for (int f = 0; f <= equipe.Count - 1; f++)
                    {
                        comboBoxJoueur.Items.Add(equipe[f].NomEquipe);
                    }
                    //on indique sa position
                    comboBoxJoueur.Location = new System.Drawing.Point(posX + 245, posY);
                    comboBoxJoueur.Size = new System.Drawing.Size(100, 20);
                    comboBoxJoueur.Name = "cbxJoueur" + i.ToString(); // Nommer la ComboBox de manière unique
                    //on l'ajoute à la liste des combobox
                    listCombobox.Add(comboBoxJoueur);
                    this.Controls.Add(comboBoxJoueur);
                    //et on ajoute + 50 à la variable posY
                    posY = posY + 50;
                }

            }

        }

        private void btnValider_Click(object sender, EventArgs e) //evènement quand on clique sur le bouton
        {
            //on ajoute les nom de joueurs à la classe joueurs
            AjouterJoueur(nombreJoueurTransmis);
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

        public void AjouterJoueur(string nbJoueur)//fonction pour ajouter les joueurs à la liste des joueurs
        {
            int nbJoueurInt = Convert.ToInt32(nbJoueur);//on convertit le nombre de joueur en int
            //la boucle se repète tant que ce n'est pas égale au nombre de joueur
            for(int i = 1; i <= nbJoueurInt; i++) 
            {
                //on transforme le texte de la combobox à l'index i en string
                string nomJoueur = listTextbox[i].Text;
                string nomEquipe = listCombobox[i].SelectedItem?.ToString();
                //si ce n'est pas vide
                if (!string.IsNullOrEmpty(nomJoueur) || !string.IsNullOrEmpty(nomEquipe))
                {
                    // Créer un nouvel objet Joueur et l'ajouter à la liste
                    joueurs.Add(new Joueur(nomJoueur, nomEquipe));
                }

                else
                {
                    return; // Arrêter le processus si une valeur est manquante
                }
            }
        }
    }
}
