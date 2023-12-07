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
        public Frminfoequipe(string nomEquipe1Transmis,string nomEquipe2Transmis,string nomEquipe3Transmis,string nomEquipe4Transmis,string nomEquipe5Transmis,string nomEquipe6Transmis  , string nombreJoueurTransmis)
        {
            InitializeComponent();
        }

        private void Frminfoequipe_Load(object sender, EventArgs e)
        {
            lblequipe1.Hide();
            lblequipe2.Hide();
            lblequipe3.Hide();
            lblequipe4.Hide();
            lblequipe5.Hide();
            lblequipe6.Hide();
            lbljoueur1equip1.Hide();
            lbljoueur2equip1.Hide();
            lbljoueur3equip1.Hide();
            lbljoueur4equip1.Hide();
            lbljoueur5equip1.Hide();
            lbljoueur6equip1.Hide();
            lbljoueur1equip2.Hide();
            lbljoueur2equip2.Hide();
            lbljoueur3equip2.Hide();
            lbljoueur4equip2.Hide();
            lbljoueur5equip2.Hide();
            lbljoueur6equip2.Hide();
            lbljoueur1equip3.Hide();
            lbljoueur2equip3.Hide();
            lbljoueur3equip3.Hide();
            lbljoueur4equip3.Hide();
            lbljoueur5equip3.Hide();
            lbljoueur6equip3.Hide();
            lbljoueur1equip4.Hide();
            lbljoueur2equip4.Hide();
            lbljoueur3equip4.Hide();
            lbljoueur4equip4.Hide();
            lbljoueur5equip4.Hide();
            lbljoueur6equip4.Hide();
            lbljoueur1equip5.Hide();
            lbljoueur2equip5.Hide();
            lbljoueur3equip5.Hide();
            lbljoueur4equip5.Hide();
            lbljoueur5equip5.Hide();
            lbljoueur6equip5.Hide();
            lbljoueur1equip6.Hide();
            lbljoueur2equip6.Hide();
            lbljoueur3equip6.Hide();
            lbljoueur4equip6.Hide();
            lbljoueur5equip6.Hide();
            lbljoueur6equip6.Hide();
            
            string nomequipe1 = "a";
            lblequipe1.Text = nomequipe1;
            string nomequipe2 = "b";
            lblequipe2.Text = nomequipe2;
            string nomequipe3 = "c";
            lblequipe3.Text = nomequipe3;
            string nomequipe4 = "d";
            lblequipe4.Text = nomequipe4;
            string nomequipe5 = "e";
            lblequipe5.Text = nomequipe5;
            string nomequipe6 = "f";
            lblequipe6.Text = nomequipe6;
            string nomJouer = "a";
            lbljoueur1equip1.Text = nomJouer;
            lbljoueur2equip1.Text = nomJouer;
            lbljoueur3equip1.Text = nomJouer;
            lbljoueur4equip1.Text = nomJouer;
            lbljoueur5equip1.Text = nomJouer;
            lbljoueur6equip1.Text = nomJouer;
            lbljoueur1equip2.Text = nomJouer;
            lbljoueur2equip2.Text = nomJouer;
            lbljoueur3equip2.Text = nomJouer;
            lbljoueur4equip2.Text = nomJouer;
            lbljoueur5equip2.Text = nomJouer;
            lbljoueur6equip2.Text = nomJouer;
            lbljoueur1equip3.Text = nomJouer;
            lbljoueur2equip3.Text = nomJouer;
            lbljoueur3equip3.Text = nomJouer;
            lbljoueur4equip3.Text = nomJouer;
            lbljoueur5equip3.Text = nomJouer;
            lbljoueur6equip3.Text = nomJouer;

            int nombreEquipe = 1;
                if(nombreEquipe == 2) 
            {

                lblequipe1.Show();
                lblequipe2.Show();
                lbljoueur1equip1.Show();
                lbljoueur2equip1.Show();
                lbljoueur3equip1.Show();
                lbljoueur4equip1.Show();
                lbljoueur5equip1.Show();
                lbljoueur6equip1.Show();
                lbljoueur1equip2.Show();
                lbljoueur2equip2.Show();
                lbljoueur3equip2.Show();
                lbljoueur4equip2.Show();
                lbljoueur5equip2.Show();
                lbljoueur6equip2.Show();
                lbljoueur1equip3.Show();
                lbljoueur2equip3.Show();
                lbljoueur3equip3.Show();
                lbljoueur4equip3.Show();
                lbljoueur5equip3.Show();
                lbljoueur6equip3.Show();

            }
                else if (nombreEquipe == 3)
            {
                lblequipe1.Show();
                lblequipe2.Show();
                lblequipe3.Show();
                lbljoueur1equip1.Show();
                lbljoueur2equip1.Show();
                lbljoueur3equip1.Show();
                lbljoueur4equip1.Show();
                lbljoueur5equip1.Show();
                lbljoueur6equip1.Show();
                lbljoueur1equip2.Show();
                lbljoueur2equip2.Show();
                lbljoueur3equip2.Show();
                lbljoueur4equip2.Show();
                lbljoueur5equip2.Show();
                lbljoueur6equip2.Show();
                lbljoueur1equip3.Show();
                lbljoueur2equip3.Show();
                lbljoueur3equip3.Show();
                lbljoueur4equip3.Show();
                lbljoueur5equip3.Show();
                lbljoueur6equip3.Show();

            }
                else if (nombreEquipe == 4)
            {
                lblequipe1.Show();
                lblequipe2.Show();
                lblequipe3.Show(); 
                lblequipe4.Show();
                lbljoueur1equip1.Show();
                lbljoueur2equip1.Show();
                lbljoueur3equip1.Show();
                lbljoueur4equip1.Show();
                lbljoueur5equip1.Show();
                lbljoueur6equip1.Show();
                lbljoueur1equip2.Show();
                lbljoueur2equip2.Show();
                lbljoueur3equip2.Show();
                lbljoueur4equip2.Show();
                lbljoueur5equip2.Show();
                lbljoueur6equip2.Show();
                lbljoueur1equip3.Show();
                lbljoueur2equip3.Show();
                lbljoueur3equip3.Show();
                lbljoueur4equip3.Show();
                lbljoueur5equip3.Show();
                lbljoueur6equip3.Show();
                lbljoueur1equip4.Show();
                lbljoueur2equip4.Show();
                lbljoueur3equip4.Show();
                lbljoueur4equip4.Show();
                lbljoueur5equip4.Show();
                lbljoueur6equip4.Show();

            }
            else if (nombreEquipe == 5)
            {
                lblequipe1.Show();
                lblequipe2.Show();
                lblequipe3.Show();
                lblequipe4.Show();
                lblequipe5.Show();
                lbljoueur1equip1.Show();
                lbljoueur2equip1.Show();
                lbljoueur3equip1.Show();
                lbljoueur4equip1.Show();
                lbljoueur5equip1.Show();
                lbljoueur6equip1.Show();
                lbljoueur1equip2.Show();
                lbljoueur2equip2.Show();
                lbljoueur3equip2.Show();
                lbljoueur4equip2.Show();
                lbljoueur5equip2.Show();
                lbljoueur6equip2.Show();
                lbljoueur1equip3.Show();
                lbljoueur2equip3.Show();
                lbljoueur3equip3.Show();
                lbljoueur4equip3.Show();
                lbljoueur5equip3.Show();
                lbljoueur6equip3.Show();
                lbljoueur1equip4.Show();
                lbljoueur2equip4.Show();
                lbljoueur3equip4.Show();
                lbljoueur4equip4.Show();
                lbljoueur5equip4.Show();
                lbljoueur6equip4.Show();
                lbljoueur1equip5.Show();
                lbljoueur2equip5.Show();
                lbljoueur3equip5.Show();
                lbljoueur4equip5.Show();
                lbljoueur5equip5.Show();
                lbljoueur6equip5.Show();


            }
            else if (nombreEquipe == 6)
            {
                lblequipe1.Show();
                lblequipe2.Show();
                lblequipe3.Show();
                lblequipe4.Show();
                lblequipe5.Show();
                lblequipe6.Show();
                lbljoueur1equip1.Show();
                lbljoueur2equip1.Show();
                lbljoueur3equip1.Show();
                lbljoueur4equip1.Show();
                lbljoueur5equip1.Show();
                lbljoueur6equip1.Show();
                lbljoueur1equip2.Show();
                lbljoueur2equip2.Show();
                lbljoueur3equip2.Show();
                lbljoueur4equip2.Show();
                lbljoueur5equip2.Show();
                lbljoueur6equip2.Show();
                lbljoueur1equip3.Show();
                lbljoueur2equip3.Show();
                lbljoueur3equip3.Show();
                lbljoueur4equip3.Show();
                lbljoueur5equip3.Show();
                lbljoueur6equip3.Show();
                lbljoueur1equip4.Show();
                lbljoueur2equip4.Show();
                lbljoueur3equip4.Show();
                lbljoueur4equip4.Show();
                lbljoueur5equip4.Show();
                lbljoueur6equip4.Show();
                lbljoueur1equip5.Show();
                lbljoueur2equip5.Show();
                lbljoueur3equip5.Show();
                lbljoueur4equip5.Show();
                lbljoueur5equip5.Show();
                lbljoueur6equip5.Show();
                lbljoueur1equip6.Show();
                lbljoueur2equip6.Show();
                lbljoueur3equip6.Show();
                lbljoueur4equip6.Show();
                lbljoueur5equip6.Show();
                lbljoueur6equip6.Show();
            }
        }
    }
}
