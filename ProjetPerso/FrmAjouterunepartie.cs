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
    public partial class FormAjouterPartie : Form
    {
        List<Equipe> equipes = new List<Equipe>();
        List<Joueur> joueurs = new List<Joueur>();
        List<Systpoint> systpoint = new List<Systpoint>();
        public FormAjouterPartie(List<Equipe> equipe, List<Joueur> joueur, List<Systpoint> systpoints)
        {
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

            for (int i = 0; i <= equipes.Count / 2 - 1; i++)
            {
                //on définit une variable qui va être la position de x des éléments
                int posX = 180;
                // Créer un Label
                Label label = new Label();
                //on dit que le texte du label sera le nom du joueur à l'index qui est i
                label.Text = $"{equipes[i].NomEquipe}";
                //on donne un nom pour le label
                label.Name = "lblJoueur" + i.ToString();
                //on donne la position de où est ce que le label apparaitra
                label.Location = new System.Drawing.Point(posX + 25, posY);
                this.Controls.Add(label);

                //on ajoute une nouvelle textbox
                TextBox textBoxJoueur = new TextBox();
                //on définit la position
                textBoxJoueur.Location = new System.Drawing.Point(posX + 125, posY);
                textBoxJoueur.Size = new System.Drawing.Size(100, 20);
                textBoxJoueur.Name = "tbxJoueur" + i.ToString(); // Nommer la TextBox de manière unique
                this.Controls.Add(textBoxJoueur);
            }



            for (int i = equipes.Count / 2; i <= equipes.Count - 1; i++)
            {
                //déclaration de la variable pour la cordonée X
                int posX = 250;
                // Créer un Label
                Label label = new Label();
                //on définit ses propriétées
                label.Text = $"{equipes[i].NomEquipe}";
                label.Name = "lblJoueur" + i.ToString();
                label.Location = new System.Drawing.Point(posX + 275, posY);
                //on l'ajoute à la liste des labels
                this.Controls.Add(label);

                //on créer une nouvelle textebox
                TextBox textBoxJoueur = new TextBox();
                //on indique la position de l'élément
                textBoxJoueur.Location = new System.Drawing.Point(posX + 350, posY);
                textBoxJoueur.Size = new System.Drawing.Size(100, 20);
                textBoxJoueur.Name = "tbxJoueur" + i.ToString(); // Nommer la TextBox de manière unique
                this.Controls.Add(textBoxJoueur);

                posY = posY + 50;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuPrincipale frmMenuPrincipale = new FrmMenuPrincipale(systpoint, equipes, joueurs);
            frmMenuPrincipale.ShowDialog();
        }
    }
}
