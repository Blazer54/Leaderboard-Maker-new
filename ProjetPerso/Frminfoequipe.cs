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
                int joueurNumEquipe = 0;
                for (int f = 1; f <= nombreDeJoueur; f++)
                {
                    if (joueur[f].NomEquipe == equipe[i].NomEquipe)
                    {
                        joueurNumEquipe = joueurNumEquipe + 1;
                        Label labeljoueur = new Label();
                        labeljoueur.Text = $"{joueur[f].Nom}";
                        labeljoueur.Name = "lblJoueur" + f.ToString();
                        labeljoueur.Location = new System.Drawing.Point(posX * i, 50 + (20 * joueurNumEquipe));
                        this.Controls.Add(labeljoueur);
                    }

                }
            }
            for (int i = nombreEquipe / 2 +1; i <= nombreEquipe; i++)
            {
                int posX = 250;
                Label label = new Label();
                label.Text = equipe[i].NomEquipe;
                label.Name = "lblEquipeBas" + i.ToString();
                label.Location = new System.Drawing.Point(posX * (i - nombreEquipe / 2), 250);
                this.Controls.Add(label);
                int joueurNumEquipe = 0;
                for (int f = 1; f <= nombreDeJoueur; f++)
                {
                    if (joueur[f].NomEquipe == equipe[i].NomEquipe)
                    {
                        Label labeljoueur = new Label();
                        labeljoueur.Text = $"{joueur[f].Nom}";
                        labeljoueur.Name = "lblJoueurs" + f.ToString();
                        labeljoueur.Location = new System.Drawing.Point(posX * (i - nombreEquipe / 2), 250 +(20 * joueurNumEquipe));
                        this.Controls.Add(labeljoueur);
                    }
                }
            }
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
