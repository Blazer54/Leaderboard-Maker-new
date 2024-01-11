using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

namespace ProjetPerso
{
    public partial class FormAjouterPartie : Form
    {
        //on créer les différentes listes
        List<Equipe> equipes = new List<Equipe>();
        List<Joueur> joueurs = new List<Joueur>();
        List<Systpoint> systpoint = new List<Systpoint>();
        List<Partie> parties = new List<Partie>();
        List<TextBox> listTextboxPlacement = new List<TextBox>();
        List<TextBox> listTextboxKill = new List<TextBox>();
        List<StockagePoint> stockagesPoints = new List<StockagePoint>();
        public FormAjouterPartie(List<Equipe> equipe, List<Joueur> joueur, List<Systpoint> systpoints)
        {
            //on récupère les différentes informations
            InitializeComponent();
            equipes = equipe;
            joueurs = joueur;
            systpoint = systpoints;
        }

        private void FormAjouterPartie_Load(object sender, EventArgs e)
        {

        }

        private void FormAjouterPartie_Load_1(object sender, EventArgs e)
        {
            int posY = 80;

            for (int i = 0; i < equipes.Count / 2   ; i++)
            {
                //on définit une variable qui va être la position de x des éléments
                int posX = 90;
                // Créer un Label
                Label label = new Label();
                //on dit que le texte du label sera le nom du joueur à l'index qui est i
                label.Text = $"placement {equipes[i].NomEquipe}";
                //on donne un nom pour le label
                label.Name = "lblJoueur" + i.ToString();
                //on donne la position de où est ce que le label apparaitra
                label.Location = new System.Drawing.Point(posX + 25, posY);
                this.Controls.Add(label);

                //on ajoute une nouvelle textbox
                TextBox textBoxPlacement = new TextBox();
                //on définit la position
                textBoxPlacement.Location = new System.Drawing.Point(posX + 125, posY);
                textBoxPlacement.Size = new System.Drawing.Size(100, 20);
                textBoxPlacement.Name = "tbxJoueur" + i.ToString(); // Nommer la TextBox de manière unique
                this.Controls.Add(textBoxPlacement);
                //on ajoute à la liste des textbox
                listTextboxPlacement.Add(textBoxPlacement);

                //on créer un label pour indiquer que c'est la textbox des kills
                Label labelKill = new Label();
                labelKill.Text = $"Kill globaux";
                labelKill.Location= new System.Drawing.Point(posX + 275, posY + 30);
                this.Controls.Add(labelKill);

                //on ajoute une nouvelle textbox
                TextBox textBoxKill = new TextBox();
                //on définit la position
                textBoxKill.Location = new System.Drawing.Point(posX + 250, posY);
                textBoxKill.Size = new System.Drawing.Size(100, 20);
                textBoxKill.Name = "tbxJoueur" + i.ToString(); // Nommer la TextBox de manière unique
                this.Controls.Add(textBoxKill);

                listTextboxKill.Add(textBoxKill);

                posY = posY + 60;
            }

            int posY2 = 80;

            for (int i = equipes.Count / 2; i <= equipes.Count - 1; i++)
            {
                //déclaration de la variable pour la cordonée X
                int posX = 350;
                // Créer un Label
                Label label = new Label();
                //on définit ses propriétées
                label.Text = $"placement {equipes[i].NomEquipe}";
                label.Name = "lblJoueur" + i.ToString();
                label.Location = new System.Drawing.Point(posX + 135, posY2);
                //on l'ajoute à la liste des labels
                this.Controls.Add(label);

                //on créer une nouvelle textebox
                TextBox textBoxPlacement = new TextBox();
                //on indique la position de l'élément
                textBoxPlacement.Location = new System.Drawing.Point(posX + 250, posY2);
                textBoxPlacement.Size = new System.Drawing.Size(100, 20);
                textBoxPlacement.Name = "tbxJoueur" + i.ToString(); // Nommer la TextBox de manière unique
                this.Controls.Add(textBoxPlacement);
                //on l'ajoute à la liste des textbox
                listTextboxPlacement.Add(textBoxPlacement);

                //o céer un label pour^indiquer que c'est la textbox des kills
                Label labelKill = new Label();
                labelKill.Text = $"Kill globaux";
                labelKill.Location = new System.Drawing.Point(posX + 450, posY2 + 30);
                this.Controls.Add(labelKill);

                //on ajoute une nouvelle textbox
                TextBox textBoxKill = new TextBox();
                //on définit la position
                textBoxKill.Location = new System.Drawing.Point(posX + 425, posY2);
                textBoxKill.Size = new System.Drawing.Size(100, 20);
                textBoxKill.Name = "tbxJoueur" + i.ToString(); // Nommer la TextBox de manière unique
                this.Controls.Add(textBoxKill);
                //on ajoute la textbox à la liste des textbox
                listTextboxKill.Add(textBoxKill);

                //on ajoute 50 a posY
                posY2 = posY2 + 60;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //la form se cache
            this.Hide();
            //appelle fonction pour ajouter des parties
            AjouterPartie(listTextboxPlacement, listTextboxKill, parties, equipes);
            //fonction pour faire le calcul des points
            Calcul(parties, equipes, systpoint,stockagesPoints);
            //on passe à la form Menu principal 2
            FrmMenuPrincipale2 frmMenuPrincipale2 = new FrmMenuPrincipale2(systpoint, equipes, joueurs,  parties, stockagesPoints);
            frmMenuPrincipale2.ShowDialog();
        }

        static void AjouterPartie(List<TextBox> listTextboxPlacement, List<TextBox> listTextboxKill, List<Partie> parties, List<Equipe> equipes)
        {
            //on fait la boucle tant que i ne fait la taille de la liste des textboxplacement
            for (int i = 0; i < listTextboxPlacement.Count; i++) 
            {
                //on récupère les informations des listes et on les stock selon l'index actuel
                int placement = Convert.ToInt32(listTextboxPlacement[i].Text);
                int kill = Convert.ToInt32(listTextboxKill[i].Text);
                //on ajoute une partie à la liste des parties
                parties.Add(new Partie(equipes[i].NomEquipe,placement, kill));
            }
        }

        static void Calcul(List<Partie> parties, List<Equipe> equipes, List<Systpoint> systpoint, List<StockagePoint> stockagesPoints)
        {
            //on fait une boucle de la taille de la liste des équipes
            for (int i = 0;i < equipes.Count;i++)
            {
                int pointPlacement = 0;
                int pointKillGlobalEquipe = 0;

                string listPartieClassement = parties[i].Placement.ToString();
                //on stock et on convertit les nombres de points par top 1 et kills
                int multiplicateurKills = Convert.ToInt32(systpoint[0].Pointelim);
                //on va convertir la list des point de classement en Int
                List<int> listSystPointInt = new List<int>();
                //on convertit tout les éléments de la liste en int et on les ajoute à la nouvelle liste en int
                for (int j = 0; j <= systpoint.Count; j++)
                {
                    listSystPointInt.Add(Convert.ToInt32(systpoint[i].Pointclass));
                }

                //on déclare une variable qui va représenté le placement
                int placementEquipe = parties[i].Placement;
                //on récupère la valeur de points de classement 
                int pointEquipeClassementTest = TrouverPointsPourPlacements(placementEquipe, parties, listSystPointInt);

                

                //et on ajoute les points selon les kills

                pointKillGlobalEquipe = parties[i].Kill * multiplicateurKills;
                //on stock ensuite les points pour chaque equipe
                stockagesPoints.Add(new StockagePoint(pointEquipeClassementTest, pointKillGlobalEquipe));

            }
        }

        //fonction pour trouver le nombre de points à ajouter selon le placement
        static int TrouverPointsPourPlacements(int placementEquipe, List<Partie> parties, List<int> listSystPointInt)
        {
            //on parcoure la liste des parties
            for (int i = 0; i <= parties.Count; i++) 
            {
                //on vérifie le placement
                if (placementEquipe == parties[i].Placement) 
                {
                    //et on retourne le nombre de points à ajouter
                    return listSystPointInt[i];
                }
            }
            return 0;
        }
    }
}
