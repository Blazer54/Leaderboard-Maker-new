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
    }
}
