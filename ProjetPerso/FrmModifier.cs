﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace ProjetPerso
{
    public partial class FrmModifier : Form
    {
        //on déclare les listes qui vont récupérer les informations qui ont été mise à jour dans les listes dans les forms précédentes
        List<Joueur> joueurs = new List<Joueur>();
        List<Equipe> equipe = new List<Equipe>();
        List<ComboBox> listCombobox = new List<ComboBox>();
        List<Label> listeLabels = new List<Label>();
        //on déclare une variable pour récupérer le nombre de joueurs
        public string nombreJoueur;
        public FrmModifier(List<Equipe> equipeTransmis, List<Joueur> joueursTransmis, string nombreJoueurTranmsis)
        {
            InitializeComponent();
            //on récupère les informations de la forms précédentes et on les stock
            nombreJoueur = nombreJoueurTranmsis;
            equipe = equipeTransmis;
            joueurs = joueursTransmis;
        }

        private void FrmModifier_Load(object sender, EventArgs e)
        {
            //on convertit le nombre de joueur qui était en string, il devient un int
            int nbJoueurInt = Convert.ToInt32(nombreJoueur);
            //boucle qui commence à 1 et qui se répète pour le nombre de joueur qu'il y a divisé par 2
            for (int i = 0; i <= nbJoueurInt / 2 - 1; i++) 
            {
                //on définit une variable qui va être la position de x des éléments
                int posX = 180;
                // Créer un Label
                Label label = new Label();
                //on dit que le texte du label sera le nom du joueur à l'index qui est i
                label.Text = $"{joueurs[i].Nom}";
                //on donne un nom pour le label
                label.Name = "lblJoueur" + i.ToString();
                //on donne la position de où est ce que le label apparaitra
                label.Location = new System.Drawing.Point(posX + 25, 40 * i + 85);
                listeLabels.Add(label);
                this.Controls.Add(label);
                //on va créer une nouvelle combobox
                ComboBox comboBoxJoueur = new ComboBox();
                //la boucle commence à 1 et continue tant que i n'est pas égal au nombre d'équipe - 1 (car on enlève l'équipe 0 qui est vide)
                for (int f = 0; f <= equipe.Count - 1 ; f++)
                {
                    //a chaque fois que la boucle se répète on ajoute
                    comboBoxJoueur.Items.Add(equipe[f].NomEquipe);

                }
                //on parcoure la liste des equipe
                for(int f = 0;f <= equipe.Count - 1 ; f++)
                {
                    //si le nom de l'équipe actuelle est égale au nom d'équipe du joueur actuel alors
                    if (equipe[f].NomEquipe == joueurs[i].NomEquipe)
                    {
                        //on dit que l'index séléctionné est f
                        comboBoxJoueur.SelectedIndex = f;
                    }
                }
                //on définit les propriétés de la combobox
                comboBoxJoueur.Location = new System.Drawing.Point(posX + 200,40 * i + 85);
                comboBoxJoueur.Size = new System.Drawing.Size(100, 20);
                comboBoxJoueur.Name = "cbxJoueur" + i.ToString(); // Nommer la ComboBox de manière unique
                //on l'ajoute à la liste des combobox
                listCombobox.Add(comboBoxJoueur);
                this.Controls.Add(comboBoxJoueur);

            }
            //on définit une variable pour la cordonée Y
            int posY = 80;
            //on parcoure l'autre moitié de la liste des joueurs
            for (int i = joueurs.Count / 2; i <= joueurs.Count - 1; i++)
            {
                //déclaration de la variable pour la cordonée X
                int posX = 180;
                // Créer un Label
                Label label = new Label();
                //on définit ses propriétées
                label.Text = $"{joueurs[i].Nom}";
                label.Name = "lblJoueur" + i.ToString();
                label.Location = new System.Drawing.Point(posX + 500, 35 * i + 10);
                //on l'ajoute à la liste des labels
                listeLabels.Add(label);
                this.Controls.Add(label);
                ComboBox comboBoxJoueur = new ComboBox();
                comboBoxJoueur.SelectedItem = joueurs[i].NomEquipe;
                for (int f = 0; f <= equipe.Count - 1; f++)
                {
                    //a chaque fois que la boucle se répète on ajoute
                    comboBoxJoueur.Items.Add(equipe[f].NomEquipe);

                }
                //on parcoure la liste des équipes
                for (int f = 0; f <= equipe.Count - 1; f++)
                {
                    //si le nom d'équipe actuelle est égale aux nom d'équipe du joueurs actuel alors
                    if (equipe[f].NomEquipe == joueurs[i].NomEquipe)
                    {
                        //l'index séléctionées sera f
                        comboBoxJoueur.SelectedIndex = f;
                    }
                }
                comboBoxJoueur.Location = new System.Drawing.Point(posX + 630, 35 * i + 10);
                comboBoxJoueur.Size = new System.Drawing.Size(100, 20);
                comboBoxJoueur.Name = "cbxJoueur" + i.ToString(); // Nommer la ComboBox de manière unique
                //on ajoute la combobox à la liste des combobox
                listCombobox.Add(comboBoxJoueur);
                this.Controls.Add(comboBoxJoueur);
                //on ajoute 50 à la position Ys
                posY = posY + 50;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.Hide(); //on cache
            joueurs.Clear();//on enleve tout ce qu'il y a dans la liste des joueurs
            AjouterJoueur(nombreJoueur);//on utilise la fonction pour ajouter les joueurs
            //alors on affiche la form pour les information sur les équipes
            FrmSystPoint frmSystPoint = new FrmSystPoint(equipe, joueurs, nombreJoueur);//création d'une nouvelle form//
            frmSystPoint.ShowDialog();
        }

        public void AjouterJoueur(string nbJoueur)//fonction pour ajouter les joueurs à la liste des joueurs
        {
            int nbJoueurInt = Convert.ToInt32(nbJoueur);//on convertit le nombre de joueur en int
            //la boucle se repète tant que ce n'est pas égale au nombre de joueur
            for (int i = 1; i <= nbJoueurInt - 1; i++)
            {
                //on transforme le texte de la combobox à l'index i en string
                string nomJoueur = listeLabels[i].Text;
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
