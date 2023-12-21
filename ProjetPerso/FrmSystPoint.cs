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
    public partial class FrmSystPoint : Form
    {
        List<Equipe> equipes = new List<Equipe>();
        List<Joueur> joueurs = new List<Joueur>();
        List<Systpoint> systpoint = new List<Systpoint>();
        List<TextBox> tbx = new List<TextBox>();
        string nombrejoueurs;
        int nbrequipe;
        public FrmSystPoint(List<Equipe> equipe, List<Joueur> joueur, string nombrejoueur)
        {
            InitializeComponent();
            equipes = equipe;
            joueurs = joueur;
            nombrejoueurs = nombrejoueur;
            nbrequipe = equipes.Count;
        }

        private void FrmSystPoint_Load(object sender, EventArgs e)
        {
            int nombreDeJoueur = Convert.ToInt32(nombrejoueurs);
            int nombreEquipe = equipes.Count - 1;

            for (int i = 1; i <= nombreEquipe; i++)
            {
                int posY = 50;
                Label label = new Label();
                label.Text = "Point pour l'équipe qui fini n°" + i.ToString();
                label.Name = "Lblpoint" + i.ToString();
                label.Location = new System.Drawing.Point(150, posY * i);
                label.Size = new System.Drawing.Size(170, 20);
                this.Controls.Add(label);

                TextBox textBoxJoueur = new TextBox();
                textBoxJoueur.Location = new System.Drawing.Point(150 + 170, posY * i);
                textBoxJoueur.Size = new System.Drawing.Size(100, 20);
                textBoxJoueur.Name = "tbxJoueur" + i.ToString(); // Nommer la TextBox de manière unique
                tbx.Add(textBoxJoueur);
                this.Controls.Add(textBoxJoueur);
            }

        }
        private void btnValider_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuPrincipale frmMenuPrincipale = new FrmMenuPrincipale();
            frmMenuPrincipale.ShowDialog();
        }
        public void AjouterEquipe()
        {
            for (int i = 0; i < tbx.Count; i++)
            {
                string nbrPoint = tbx[i].Text;
                if (!string.IsNullOrEmpty(nbrPoint))
                {/*
                    systpoint.Add(new Pointclass(nbrPoint));
                */}
                else { return; }
            }
        }
    }
}
