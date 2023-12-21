using System;
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

namespace ProjetPerso
{
    public partial class FrmModifier : Form
    {
        //on déclare les listes qui vont récupérer les informations qui ont été mise à jour dans les listes dans les forms précédentes
        List<Joueur> joueurs = new List<Joueur>();
        List<Equipe> equipe = new List<Equipe>();
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
            for (int i = 1; i <= nbJoueurInt / 2; i++) 
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
                label.Location = new System.Drawing.Point(posX + 25, 50 * i + 30);
                this.Controls.Add(label);
                //on va créer une nouvelle combobox
                ComboBox comboBoxJoueur = new ComboBox();
                //la boucle commence à 1 et continue tant que i n'est pas égal au nombre d'équipe - 1 (car on enlève l'équipe 0 qui est vide)
                for (int f = 1; f < equipe.Count  ; f++)
                {
                    //a chaque fois que la boucle se répète on ajoute
                    comboBoxJoueur.Items.Add(equipe[f].NomEquipe);

                }
                
                for(int f = 1;f < equipe.Count  ; f++)
                {                
                    if (equipe[f].NomEquipe == joueurs[f].NomEquipe)
                    {
                        comboBoxJoueur.SelectedIndex = f ;
                    }
                }

                comboBoxJoueur.Location = new System.Drawing.Point(posX + 200, 50 * i + 30);
                comboBoxJoueur.Size = new System.Drawing.Size(100, 20);
                comboBoxJoueur.Name = "cbxJoueur" + i.ToString(); // Nommer la ComboBox de manière unique
                this.Controls.Add(comboBoxJoueur);

            }
            int posY = 80;
            for (int i = nbJoueurInt / 2 + 1; i <= nbJoueurInt; i++)
            {
                int posX = 180;
                // Créer un Label
                Label label = new Label();
                label.Text = $"{joueurs[i].Nom}";
                label.Name = "lblJoueur" + i.ToString();
                label.Location = new System.Drawing.Point(posX + 500, 35 * i + 10);
                this.Controls.Add(label);
                ComboBox comboBoxJoueur = new ComboBox();
                comboBoxJoueur.SelectedItem = joueurs[i].NomEquipe;
                for (int f = 1; f < equipe.Count ; f++)
                {
                    comboBoxJoueur.Items.Add(equipe[f].NomEquipe);
                }
                for (int f = 1; f < equipe.Count  ; f++)
                {
                    if (equipe[f].NomEquipe == joueurs[f].NomEquipe)
                    {
                        comboBoxJoueur.SelectedIndex = f;
                    }
                }
                comboBoxJoueur.Location = new System.Drawing.Point(posX + 630, 35 * i + 10);
                comboBoxJoueur.Size = new System.Drawing.Size(100, 20);
                comboBoxJoueur.Name = "cbxJoueur" + i.ToString(); // Nommer la ComboBox de manière unique
                this.Controls.Add(comboBoxJoueur);
                posY = posY + 50;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.Hide(); //on cache
            //alors on affiche la form pour les information sur les équipes
            Frminfoequipe frminfoequipe = new Frminfoequipe(equipe, joueurs, nombreJoueur);//création d'une nouvelle form//
            frminfoequipe.ShowDialog();
        }
    }
}
