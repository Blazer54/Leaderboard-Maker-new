using System;
using System.Collections.Generic;
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
            int nombreEquipe = equipes.Count;

            for (int i = 1; i <= nombreEquipe; i++)
            {
                int posY = 50;
                Label label = new Label();
                label.Text = "Point pour l'équipe qui fini n°" + i.ToString();
                label.Name = "Lblpoint" + i.ToString();
                label.Location = new System.Drawing.Point(150, posY * i);
                label.Size = new System.Drawing.Size(170, 20);
                this.Controls.Add(label);

                TextBox textBoxPoint = new TextBox();
                textBoxPoint.Location = new System.Drawing.Point(150 + 170, posY * i);
                textBoxPoint.Size = new System.Drawing.Size(100, 20);
                textBoxPoint.Name = "tbxPoint" + i.ToString(); // Nommer la TextBox de manière unique
                tbx.Add(textBoxPoint);
                this.Controls.Add(textBoxPoint);
            }

        }
        private void btnValider_Click(object sender, EventArgs e)
        {
            this.Hide();
            AjouterPoint();
            FrmMenuPrincipale frmMenuPrincipale = new FrmMenuPrincipale(systpoint,equipes,joueurs);
            frmMenuPrincipale.ShowDialog();
        }
        public void AjouterPoint()
        {
            for (int i = 0; i < tbx.Count; i++)
            {
                string point = tbx[i].Text;
                string pointelim = tbxptselim.Text; 
                if (!string.IsNullOrEmpty(point))
                {
                    systpoint.Add(new Systpoint(point,pointelim));
                }
                else { return; }
            }
        }
    }
}
