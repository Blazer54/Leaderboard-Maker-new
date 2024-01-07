using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 Nom : Bieri / Escalera
 prenom : Nicolas / Miguel
 Classe : i.fa-p1a
 But : Crée un programe pour faire des classement
 Date : 23.11.2023 au 07.01.2024
*/
namespace ProjetPerso
{
    public partial class FrmBienvenue : Form
    {
        public FrmBienvenue()
        {
            InitializeComponent();
        }

        private void btnCommencer_Click(object sender, EventArgs e)// quand on clique sur le bouton//
        {
            this.Hide();// cache cette form//
            FrmParaduclassement frmParaduclassement = new FrmParaduclassement();//création d'une nouvelle form//
            frmParaduclassement.ShowDialog();
        }
    }
}
