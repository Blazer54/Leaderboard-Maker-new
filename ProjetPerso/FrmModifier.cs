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
            int nbJoueurInt = Convert.ToInt32(nombreJoueur);

            for (int i = 1; i <= nbJoueurInt / 2; i++) 
            {
                int posX = 180;
                // Créer un Label
                Label label = new Label();
                label.Text = $"{joueurs[i].Nom}";
                label.Name = "lblJoueur" + i.ToString();
                label.Location = new System.Drawing.Point(posX + 25, 50 * i + 30);
                this.Controls.Add(label);
                ComboBox comboBoxJoueur = new ComboBox();
                for (int f = 1; f <= equipe.Count - 1 ; f++)
                {
                    comboBoxJoueur.Items.Add(equipe[f].NomEquipe);

                }
                
                for(int f = 1;f <= equipe.Count - 1 ; f++)
                {                
                    if (equipe[f].NomEquipe == joueurs[f].NomEquipe)
                    {
                        comboBoxJoueur.SelectedIndex = f - 2;
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
                label.Location = new System.Drawing.Point(posX + 500, 40 * i);
                this.Controls.Add(label);
                ComboBox comboBoxJoueur = new ComboBox();
                comboBoxJoueur.SelectedItem = joueurs[i].NomEquipe;
                for (int f = 0; f <= equipe.Count - 1; f++)
                {
                    comboBoxJoueur.Items.Add(equipe[f].NomEquipe);
                    if (equipe[f].NomEquipe == joueurs[f].NomEquipe)
                    {
                        comboBoxJoueur.SelectedIndex = f;
                    }
                }
                comboBoxJoueur.Location = new System.Drawing.Point(posX + 630, 40 * i);
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
