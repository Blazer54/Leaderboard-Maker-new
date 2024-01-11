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
        //création de listes//
        List<Equipe> equipes = new List<Equipe>();
        List<Joueur> joueurs = new List<Joueur>();
        List<Systpoint> systpoint = new List<Systpoint>();
        List<Partie> partie = new List<Partie>();
        List<StockagePoint> stockagePoint = new List<StockagePoint>();
        public FrmLeaderboard(List<Equipe> equipe, List<Joueur> joueur, List<Systpoint> systpoints, List<Partie> parties, List<StockagePoint> stockagePoints)
        {
            InitializeComponent();
            //liste contienent les info tansmise//
            equipes = equipe;
            joueurs = joueur;
            systpoint = systpoints;
            partie = parties;
            stockagePoint = stockagePoints;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipale2 frmMenuPrincipale2 = new FrmMenuPrincipale2(systpoint, equipes, joueurs, partie, stockagePoint);
            frmMenuPrincipale2.ShowDialog();
            this.Hide();
        }

        private void FrmLeaderboard_Load_1(object sender, EventArgs e)
        {
            int nombreDeJoueur = joueurs.Count;
            int nombreEquipe = equipes.Count - 1;
            //ajout de label pour afficher le nom des équipes, la position, le nombre d'elimination// 
            for (int i = 0; i <= nombreEquipe / 2; i++)
            {
                int posX = 600;
                Label label = new Label();
                label.Text = equipes[i].ToString();
                label.Name = "lblEquipeHaut" + i.ToString();
                label.Location = new System.Drawing.Point(posX * (i + 1), 50);
                this.Controls.Add(label);
                int posX1 = 750;
                Label label1 = new Label();
                label1.Text = "Nombre de point de clasement : "+stockagePoint[i].Pointclass.ToString();
                label1.Name = "lblpointequipe" + i.ToString();
                label1.Location = new System.Drawing.Point(posX1 * (i + 1), 50);
                label1.Size = new System.Drawing.Size(150, 20);
                this.Controls.Add(label1);
                int posX2 = 1000;
                Label label2 = new Label();
                label2.Text = "Nombre de point d'elimination : " + stockagePoint[i].Pointelim.ToString();
                label2.Name = "lblpointelim" + i.ToString();
                label2.Location = new System.Drawing.Point(posX2 * (i + 1), 250);
                label1.Size = new System.Drawing.Size(150, 20);
                this.Controls.Add(label2);
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
                label.Text = equipes[i].ToString();
                label.Name = "lblEquipeBas" + i.ToString();
                label.Location = new System.Drawing.Point(posX * (i - nombreEquipe / 2), 250);
                this.Controls.Add(label);
                int posX1 = 270;
                Label label1 = new Label();
                label1.Text = "Nombre de point de clasement : " + stockagePoint[i].Pointclass.ToString();
                label1.Name = "lblpointequipe" + i.ToString();
                label1.Location = new System.Drawing.Point(posX1 * (i - nombreEquipe / 2), 250);
                this.Controls.Add(label1);
                int posX2 = 280;
                Label label2 = new Label();
                label2.Text = "Nombre de point d'elimination : " + stockagePoint[i].Pointelim.ToString();
                label2.Name = "lblpointelim" + i.ToString();
                label2.Location = new System.Drawing.Point(posX2 * (i - nombreEquipe / 2), 250);
                this.Controls.Add(label2);
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
    }
}


