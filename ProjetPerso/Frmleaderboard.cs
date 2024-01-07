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
    public partial class FrmLeaderboard : Form
    {
        List<Equipe> equipes = new List<Equipe>();
        List<Joueur> joueurs = new List<Joueur>();
        List<Systpoint> systpoint = new List<Systpoint>();
        public FrmLeaderboard(List<Equipe> equipe, List<Joueur> joueur, List<Systpoint> systpoints, List<Partie> parties)
        {
            InitializeComponent();
            equipes = equipe;
            joueurs = joueur;
            systpoint = systpoints;
        }

        private void FrmLeaderboard_Load(object sender, EventArgs e)
        {
            int nombreDeJoueur = joueurs.Count;
            int nombreEquipe = equipes.Count - 1;

            for (int i = 0; i <= nombreEquipe / 2; i++)
            {
                int posX = 250;
                Label label = new Label();
                label.Text = equipes[i].NomEquipe;
                label.Name = "lblEquipeHaut" + i.ToString();
                label.Location = new System.Drawing.Point(posX * (i + 1), 50);
                this.Controls.Add(label);
                int joueurNumEquipe = 0;
                for (int f = 0; f < nombreDeJoueur; f++)
                {
                    if (joueurs[f].NomEquipe == equipes[i].NomEquipe)
                    {
                        joueurNumEquipe = joueurNumEquipe + 1;
                        Label labeljoueur = new Label();
                        labeljoueur.Text = $"{joueurs[f].Nom}";
                        labeljoueur.Name = "lblJoueur" + f.ToString();
                        labeljoueur.Location = new System.Drawing.Point(posX * (i + 1), 50 + (20 * joueurNumEquipe));
                        this.Controls.Add(labeljoueur);
                    }
                }
            }
            for (int i = nombreEquipe / 2 + 1; i <= nombreEquipe; i++)
            {
                int posX = 250;
                Label label = new Label();
                label.Text = equipes[i].NomEquipe;
                label.Name = "lblEquipeBas" + i.ToString();
                label.Location = new System.Drawing.Point(posX * (i - nombreEquipe / 2), 250);
                this.Controls.Add(label);
                int joueurNumEquipe = 0;
                for (int f = 0; f < nombreDeJoueur; f++)
                {
                    if (joueurs[f].NomEquipe == equipes[i].NomEquipe)
                    {
                        joueurNumEquipe = joueurNumEquipe + 1;
                        Label labeljoueur = new Label();
                        labeljoueur.Text = $"{joueurs[f].Nom}";
                        labeljoueur.Name = "lblJoueursbas" + f.ToString();
                        labeljoueur.Location = new System.Drawing.Point(posX * (i - nombreEquipe / 2), 250 + (20 * joueurNumEquipe));
                        this.Controls.Add(labeljoueur);
                    }
                }
            }
        }

        private void FrmLeaderboard_Load_1(object sender, EventArgs e)
        {

        }
    }
}

