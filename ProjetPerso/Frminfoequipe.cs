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


            lblequipe1.Text = equipe[1].NomEquipe; //le text du lbl de l'équipe est remplis par l'objet de la liste //
            lblequipe2.Text = equipe[2].NomEquipe;
            lblequipe3.Text = equipe[3].NomEquipe;
            lblequipe4.Text = equipe[4].NomEquipe;
            lblequipe5.Text = equipe[5].NomEquipe;
            lblequipe6.Text = equipe[6].NomEquipe;
            
            /*
            //joueur 1//
            if (joueur[1].NomEquipe == equipe[1].NomEquipe) // si le joueur appartient a l'équipe 1 //
            {
                if (lbljoueur1equip1.Text == null)
                { lbljoueur1equip1.Text = joueur[1].Nom; }
                else if (lbljoueur2equip1.Text == null)
                { lbljoueur2equip1.Text = joueur[1].Nom; }
                else if (lbljoueur3equip1.Text == null)
                { lbljoueur3equip1.Text = joueur[1].Nom; }
                else if (lbljoueur4equip1.Text == null)
                { lbljoueur4equip1.Text = joueur[1].Nom; }
                else if (lbljoueur5equip1.Text == null)
                { lbljoueur5equip1.Text = joueur[1].Nom; }
                else if (lbljoueur6equip1.Text == null)
                { lbljoueur6equip1.Text = joueur[1].Nom; }
            }
            else if (joueur[1].NomEquipe == equipe[2].NomEquipe) // si le joueur appartient a l'équipe 2 //
            {
                if (lbljoueur1equip2.Text == null)
                { lbljoueur1equip2.Text = joueur[1].Nom; }
                else if (lbljoueur2equip2.Text == null)
                { lbljoueur2equip2.Text = joueur[1].Nom; }
                else if (lbljoueur3equip2.Text == null)
                { lbljoueur3equip2.Text = joueur[1].Nom; }
                else if (lbljoueur4equip2.Text == null)
                { lbljoueur4equip2.Text = joueur[1].Nom; }
                else if (lbljoueur5equip2.Text == null)
                { lbljoueur5equip2.Text = joueur[1].Nom; }
                else if (lbljoueur6equip2.Text == null)
                { lbljoueur6equip2.Text = joueur[1].Nom; }
            }
            else if (joueur[1].NomEquipe == equipe[3].NomEquipe) // si le joueur appartient a l'équipe 3 //
            {
                if (lbljoueur1equip3.Text == null)
                { lbljoueur1equip3.Text = joueur[1].Nom; }
                else if (lbljoueur2equip3.Text == null)
                { lbljoueur2equip3.Text = joueur[1].Nom; }
                else if (lbljoueur3equip3.Text == null)
                { lbljoueur3equip3.Text = joueur[1].Nom; }
                else if (lbljoueur4equip3.Text == null)
                { lbljoueur4equip3.Text = joueur[1].Nom; }
                else if (lbljoueur5equip3.Text == null)
                { lbljoueur5equip3.Text = joueur[1].Nom; }
                else if (lbljoueur6equip3.Text == null)
                { lbljoueur6equip3.Text = joueur[1].Nom; }
            }
            else if (joueur[1].NomEquipe == equipe[4].NomEquipe) // si le joueur appartient a l'équipe 4 //
            {
                if (lbljoueur1equip4.Text == null)
                { lbljoueur1equip4.Text = joueur[1].Nom; }
                else if (lbljoueur2equip4.Text == null)
                { lbljoueur2equip4.Text = joueur[1].Nom; }
                else if (lbljoueur3equip4.Text == null)
                { lbljoueur3equip4.Text = joueur[1].Nom; }
                else if (lbljoueur4equip4.Text == null)
                { lbljoueur4equip4.Text = joueur[1].Nom; }
                else if (lbljoueur5equip4.Text == null)
                { lbljoueur5equip4.Text = joueur[1].Nom; }
                else if (lbljoueur6equip4.Text == null)
                { lbljoueur6equip4.Text = joueur[1].Nom; }
            }
            else if (joueur[1].NomEquipe == equipe[5].NomEquipe) // si le joueur appartient a l'équipe 5 //
            {
                if (lbljoueur1equip5.Text == null)
                { lbljoueur1equip5.Text = joueur[1].Nom; }
                else if (lbljoueur2equip5.Text == null)
                { lbljoueur2equip5.Text = joueur[1].Nom; }
                else if (lbljoueur3equip5.Text == null)
                { lbljoueur3equip5.Text = joueur[1].Nom; }
                else if (lbljoueur4equip5.Text == null)
                { lbljoueur4equip5.Text = joueur[1].Nom; }
                else if (lbljoueur5equip5.Text == null)
                { lbljoueur5equip5.Text = joueur[1].Nom; }
                else if (lbljoueur6equip5.Text == null)
                { lbljoueur6equip5.Text = joueur[1].Nom; }
            }
            else if (joueur[1].NomEquipe == equipe[6].NomEquipe) // si le joueur appartient a l'équipe 6 //
            {
                if (lbljoueur1equip6.Text == null)
                { lbljoueur1equip6.Text = joueur[1].Nom; }
                else if (lbljoueur2equip6.Text == null)
                { lbljoueur2equip6.Text = joueur[1].Nom; }
                else if (lbljoueur3equip6.Text == null)
                { lbljoueur3equip6.Text = joueur[1].Nom; }
                else if (lbljoueur4equip6.Text == null)
                { lbljoueur4equip6.Text = joueur[1].Nom; }
                else if (lbljoueur5equip6.Text == null)
                { lbljoueur5equip6.Text = joueur[1].Nom; }
                else if (lbljoueur6equip6.Text == null)
                { lbljoueur6equip6.Text = joueur[1].Nom; }
            }
            //joueur 2 //
            if (joueur[2].NomEquipe == equipe[1].NomEquipe) // si le joueur appartient a l'équipe 1 //
            {
                if (lbljoueur1equip1.Text == null)
                { lbljoueur1equip1.Text = joueur[2].Nom; }
                else if (lbljoueur2equip1.Text == null)
                { lbljoueur2equip1.Text = joueur[2].Nom; }
                else if (lbljoueur3equip1.Text == null)
                { lbljoueur3equip1.Text = joueur[2].Nom; }
                else if (lbljoueur4equip1.Text == null)
                { lbljoueur4equip1.Text = joueur[2].Nom; }
                else if (lbljoueur5equip1.Text == null)
                { lbljoueur5equip1.Text = joueur[2].Nom; }
                else if (lbljoueur6equip1.Text == null)
                { lbljoueur6equip1.Text = joueur[2].Nom; }
            }
            else if (joueur[2].NomEquipe == equipe[2].NomEquipe) // si le joueur appartient a l'équipe 2 //
            {
                if (lbljoueur1equip2.Text == null)
                { lbljoueur1equip2.Text = joueur[2].Nom; }
                else if (lbljoueur2equip2.Text == null)
                { lbljoueur2equip2.Text = joueur[2].Nom; }
                else if (lbljoueur3equip2.Text == null)
                { lbljoueur3equip2.Text = joueur[2].Nom; }
                else if (lbljoueur4equip2.Text == null)
                { lbljoueur4equip2.Text = joueur[2].Nom; }
                else if (lbljoueur5equip2.Text == null)
                { lbljoueur5equip2.Text = joueur[2].Nom; }
                else if (lbljoueur6equip2.Text == null)
                { lbljoueur6equip2.Text = joueur[2].Nom; }
            }
            else if (joueur[2].NomEquipe == equipe[3].NomEquipe) // si le joueur appartient a l'équipe 3 //
            {
                if (lbljoueur1equip3.Text == null)
                { lbljoueur1equip3.Text = joueur[2].Nom; }
                else if (lbljoueur2equip3.Text == null)
                { lbljoueur2equip3.Text = joueur[2].Nom; }
                else if (lbljoueur3equip3.Text == null)
                { lbljoueur3equip3.Text = joueur[2].Nom; }
                else if (lbljoueur4equip3.Text == null)
                { lbljoueur4equip3.Text = joueur[2].Nom; }
                else if (lbljoueur5equip3.Text == null)
                { lbljoueur5equip3.Text = joueur[2].Nom; }
                else if (lbljoueur6equip3.Text == null)
                { lbljoueur6equip3.Text = joueur[2].Nom; }
            }
            else if (joueur[2].NomEquipe == equipe[4].NomEquipe) // si le joueur appartient a l'équipe 4 //
            {
                if (lbljoueur1equip4.Text == null)
                { lbljoueur1equip4.Text = joueur[2].Nom; }
                else if (lbljoueur2equip4.Text == null)
                { lbljoueur2equip4.Text = joueur[2].Nom; }
                else if (lbljoueur3equip4.Text == null)
                { lbljoueur3equip4.Text = joueur[2].Nom; }
                else if (lbljoueur4equip4.Text == null)
                { lbljoueur4equip4.Text = joueur[2].Nom; }
                else if (lbljoueur5equip4.Text == null)
                { lbljoueur5equip4.Text = joueur[2].Nom; }
                else if (lbljoueur6equip4.Text == null)
                { lbljoueur6equip4.Text = joueur[2].Nom; }
            }
            else if (joueur[2].NomEquipe == equipe[5].NomEquipe) // si le joueur appartient a l'équipe 5 //
            {
                if (lbljoueur1equip5.Text == null)
                { lbljoueur1equip5.Text = joueur[2].Nom; }
                else if (lbljoueur2equip5.Text == null)
                { lbljoueur2equip5.Text = joueur[2].Nom; }
                else if (lbljoueur3equip5.Text == null)
                { lbljoueur3equip5.Text = joueur[2].Nom; }
                else if (lbljoueur4equip5.Text == null)
                { lbljoueur4equip5.Text = joueur[2].Nom; }
                else if (lbljoueur5equip5.Text == null)
                { lbljoueur5equip5.Text = joueur[2].Nom; }
                else if (lbljoueur6equip5.Text == null)
                { lbljoueur6equip5.Text = joueur[2].Nom; }
            }
            else if (joueur[2].NomEquipe == equipe[6].NomEquipe) // si le joueur appartient a l'équipe 6 //
            {
                if (lbljoueur1equip6.Text == null)
                { lbljoueur1equip6.Text = joueur[2].Nom; }
                else if (lbljoueur2equip6.Text == null)
                { lbljoueur2equip6.Text = joueur[2].Nom; }
                else if (lbljoueur3equip6.Text == null)
                { lbljoueur3equip6.Text = joueur[2].Nom; }
                else if (lbljoueur4equip6.Text == null)
                { lbljoueur4equip6.Text = joueur[2].Nom; }
                else if (lbljoueur5equip6.Text == null)
                { lbljoueur5equip6.Text = joueur[2].Nom; }
                else if (lbljoueur6equip6.Text == null)
                { lbljoueur6equip6.Text = joueur[2].Nom; }
            }
            //joueur 3 //
            if (joueur[3].NomEquipe == equipe[1].NomEquipe) // si le joueur appartient a l'équipe 1 //
            {
                if (lbljoueur1equip1.Text == null)
                { lbljoueur1equip1.Text = joueur[3].Nom; }
                else if (lbljoueur2equip1.Text == null)
                { lbljoueur2equip1.Text = joueur[3].Nom; }
                else if (lbljoueur3equip1.Text == null)
                { lbljoueur3equip1.Text = joueur[3].Nom; }
                else if (lbljoueur4equip1.Text == null)
                { lbljoueur4equip1.Text = joueur[3].Nom; }
                else if (lbljoueur5equip1.Text == null)
                { lbljoueur5equip1.Text = joueur[3].Nom; }
                else if (lbljoueur6equip1.Text == null)
                { lbljoueur6equip1.Text = joueur[3].Nom; }
            }
            else if (joueur[3].NomEquipe == equipe[2].NomEquipe) // si le joueur appartient a l'équipe 2 //
            {
                if (lbljoueur1equip2.Text == null)
                { lbljoueur1equip2.Text = joueur[3].Nom; }
                else if (lbljoueur2equip2.Text == null)
                { lbljoueur2equip2.Text = joueur[3].Nom; }
                else if (lbljoueur3equip2.Text == null)
                { lbljoueur3equip2.Text = joueur[3].Nom; }
                else if (lbljoueur4equip2.Text == null)
                { lbljoueur4equip2.Text = joueur[3].Nom; }
                else if (lbljoueur5equip2.Text == null)
                { lbljoueur5equip2.Text = joueur[3].Nom; }
                else if (lbljoueur6equip2.Text == null)
                { lbljoueur6equip2.Text = joueur[3].Nom; }
            }
            else if (joueur[3].NomEquipe == equipe[3].NomEquipe) // si le joueur appartient a l'équipe 3 //
            {
                if (lbljoueur1equip3.Text == null)
                { lbljoueur1equip3.Text = joueur[3].Nom; }
                else if (lbljoueur2equip3.Text == null)
                { lbljoueur2equip3.Text = joueur[3].Nom; }
                else if (lbljoueur3equip3.Text == null)
                { lbljoueur3equip3.Text = joueur[3].Nom; }
                else if (lbljoueur4equip3.Text == null)
                { lbljoueur4equip3.Text = joueur[3].Nom; }
                else if (lbljoueur5equip3.Text == null)
                { lbljoueur5equip3.Text = joueur[3].Nom; }
                else if (lbljoueur6equip3.Text == null)
                { lbljoueur6equip3.Text = joueur[3].Nom; }
            }
            else if (joueur[3].NomEquipe == equipe[4].NomEquipe) // si le joueur appartient a l'équipe 4 //
            {
                if (lbljoueur1equip4.Text == null)
                { lbljoueur1equip4.Text = joueur[3].Nom; }
                else if (lbljoueur2equip4.Text == null)
                { lbljoueur2equip4.Text = joueur[3].Nom; }
                else if (lbljoueur3equip4.Text == null)
                { lbljoueur3equip4.Text = joueur[3].Nom; }
                else if (lbljoueur4equip4.Text == null)
                { lbljoueur4equip4.Text = joueur[3].Nom; }
                else if (lbljoueur5equip4.Text == null)
                { lbljoueur5equip4.Text = joueur[3].Nom; }
                else if (lbljoueur6equip4.Text == null)
                { lbljoueur6equip4.Text = joueur[3].Nom; }
            }
            else if (joueur[3].NomEquipe == equipe[5].NomEquipe) // si le joueur appartient a l'équipe 5 //
            {
                if (lbljoueur1equip5.Text == null)
                { lbljoueur1equip5.Text = joueur[3].Nom; }
                else if (lbljoueur2equip5.Text == null)
                { lbljoueur2equip5.Text = joueur[3].Nom; }
                else if (lbljoueur3equip5.Text == null)
                { lbljoueur3equip5.Text = joueur[3].Nom; }
                else if (lbljoueur4equip5.Text == null)
                { lbljoueur4equip5.Text = joueur[3].Nom; }
                else if (lbljoueur5equip5.Text == null)
                { lbljoueur5equip5.Text = joueur[3].Nom; }
                else if (lbljoueur6equip5.Text == null)
                { lbljoueur6equip5.Text = joueur[3].Nom; }
            }
            else if (joueur[3].NomEquipe == equipe[6].NomEquipe) // si le joueur appartient a l'équipe 6 //
            {
                if (lbljoueur1equip6.Text == null)
                { lbljoueur1equip6.Text = joueur[3].Nom; }
                else if (lbljoueur2equip6.Text == null)
                { lbljoueur2equip6.Text = joueur[3].Nom; }
                else if (lbljoueur3equip6.Text == null)
                { lbljoueur3equip6.Text = joueur[3].Nom; }
                else if (lbljoueur4equip6.Text == null)
                { lbljoueur4equip6.Text = joueur[3].Nom; }
                else if (lbljoueur5equip6.Text == null)
                { lbljoueur5equip6.Text = joueur[3].Nom; }
                else if (lbljoueur6equip6.Text == null)
                { lbljoueur6equip6.Text = joueur[3].Nom; }
            }
            //joueur 4 //
            if (joueur[4].NomEquipe == equipe[1].NomEquipe) // si le joueur appartient a l'équipe 1 //
            {
                if (lbljoueur1equip1.Text == null)
                { lbljoueur1equip1.Text = joueur[4].Nom; }
                else if (lbljoueur2equip1.Text == null)
                { lbljoueur2equip1.Text = joueur[4].Nom; }
                else if (lbljoueur3equip1.Text == null)
                { lbljoueur3equip1.Text = joueur[4].Nom; }
                else if (lbljoueur4equip1.Text == null)
                { lbljoueur4equip1.Text = joueur[4].Nom; }
                else if (lbljoueur5equip1.Text == null)
                { lbljoueur5equip1.Text = joueur[4].Nom; }
                else if (lbljoueur6equip1.Text == null)
                { lbljoueur6equip1.Text = joueur[4].Nom; }
            }
            else if (joueur[4].NomEquipe == equipe[2].NomEquipe) // si le joueur appartient a l'équipe 2 //
            {
                if (lbljoueur1equip2.Text == null)
                { lbljoueur1equip2.Text = joueur[4].Nom; }
                else if (lbljoueur2equip2.Text == null)
                { lbljoueur2equip2.Text = joueur[4].Nom; }
                else if (lbljoueur3equip2.Text == null)
                { lbljoueur3equip2.Text = joueur[4].Nom; }
                else if (lbljoueur4equip2.Text == null)
                { lbljoueur4equip2.Text = joueur[4].Nom; }
                else if (lbljoueur5equip2.Text == null)
                { lbljoueur5equip2.Text = joueur[4].Nom; }
                else if (lbljoueur6equip2.Text == null)
                { lbljoueur6equip2.Text = joueur[4].Nom; }
            }
            else if (joueur[4].NomEquipe == equipe[3].NomEquipe) // si le joueur appartient a l'équipe 3 //
            {
                if (lbljoueur1equip3.Text == null)
                { lbljoueur1equip3.Text = joueur[4].Nom; }
                else if (lbljoueur2equip3.Text == null)
                { lbljoueur2equip3.Text = joueur[4].Nom; }
                else if (lbljoueur3equip3.Text == null)
                { lbljoueur3equip3.Text = joueur[4].Nom; }
                else if (lbljoueur4equip3.Text == null)
                { lbljoueur4equip3.Text = joueur[4].Nom; }
                else if (lbljoueur5equip3.Text == null)
                { lbljoueur5equip3.Text = joueur[4].Nom; }
                else if (lbljoueur6equip3.Text == null)
                { lbljoueur6equip3.Text = joueur[4].Nom; }
            }
            else if (joueur[4].NomEquipe == equipe[4].NomEquipe) // si le joueur appartient a l'équipe 4 //
            {
                if (lbljoueur1equip4.Text == null)
                { lbljoueur1equip4.Text = joueur[4].Nom; }
                else if (lbljoueur2equip4.Text == null)
                { lbljoueur2equip4.Text = joueur[4].Nom; }
                else if (lbljoueur3equip4.Text == null)
                { lbljoueur3equip4.Text = joueur[4].Nom; }
                else if (lbljoueur4equip4.Text == null)
                { lbljoueur4equip4.Text = joueur[4].Nom; }
                else if (lbljoueur5equip4.Text == null)
                { lbljoueur5equip4.Text = joueur[4].Nom; }
                else if (lbljoueur6equip4.Text == null)
                { lbljoueur6equip4.Text = joueur[4].Nom; }
            }
            else if (joueur[4].NomEquipe == equipe[5].NomEquipe) // si le joueur appartient a l'équipe 5 //
            {
                if (lbljoueur1equip5.Text == null)
                { lbljoueur1equip5.Text = joueur[4].Nom; }
                else if (lbljoueur2equip5.Text == null)
                { lbljoueur2equip5.Text = joueur[4].Nom; }
                else if (lbljoueur3equip5.Text == null)
                { lbljoueur3equip5.Text = joueur[4].Nom; }
                else if (lbljoueur4equip5.Text == null)
                { lbljoueur4equip5.Text = joueur[4].Nom; }
                else if (lbljoueur5equip5.Text == null)
                { lbljoueur5equip5.Text = joueur[4].Nom; }
                else if (lbljoueur6equip5.Text == null)
                { lbljoueur6equip5.Text = joueur[4].Nom; }
            }
            else if (joueur[4].NomEquipe == equipe[6].NomEquipe) // si le joueur appartient a l'équipe 6 //
            {
                if (lbljoueur1equip6.Text == null)
                { lbljoueur1equip6.Text = joueur[4].Nom; }
                else if (lbljoueur2equip6.Text == null)
                { lbljoueur2equip6.Text = joueur[4].Nom; }
                else if (lbljoueur3equip6.Text == null)
                { lbljoueur3equip6.Text = joueur[4].Nom; }
                else if (lbljoueur4equip6.Text == null)
                { lbljoueur4equip6.Text = joueur[4].Nom; }
                else if (lbljoueur5equip6.Text == null)
                { lbljoueur5equip6.Text = joueur[4].Nom; }
                else if (lbljoueur6equip6.Text == null)
                { lbljoueur6equip6.Text = joueur[1].Nom; }
            }
            //joueur 5 //
            if (joueur[5].NomEquipe == equipe[1].NomEquipe) // si le joueur appartient a l'équipe 1 //
            {
                if (lbljoueur1equip1.Text == null)
                { lbljoueur1equip1.Text = joueur[5].Nom; }
                else if (lbljoueur2equip1.Text == null)
                { lbljoueur2equip1.Text = joueur[5].Nom; }
                else if (lbljoueur3equip1.Text == null)
                { lbljoueur3equip1.Text = joueur[5].Nom; }
                else if (lbljoueur4equip1.Text == null)
                { lbljoueur4equip1.Text = joueur[5].Nom; }
                else if (lbljoueur5equip1.Text == null)
                { lbljoueur5equip1.Text = joueur[5].Nom; }
                else if (lbljoueur6equip1.Text == null)
                { lbljoueur6equip1.Text = joueur[5].Nom; }
            }
            else if (joueur[5].NomEquipe == equipe[2].NomEquipe) // si le joueur appartient a l'équipe 2 //
            {
                if (lbljoueur1equip2.Text == null)
                { lbljoueur1equip2.Text = joueur[5].Nom; }
                else if (lbljoueur2equip2.Text == null)
                { lbljoueur2equip2.Text = joueur[5].Nom; }
                else if (lbljoueur3equip2.Text == null)
                { lbljoueur3equip2.Text = joueur[5].Nom; }
                else if (lbljoueur4equip2.Text == null)
                { lbljoueur4equip2.Text = joueur[5].Nom; }
                else if (lbljoueur5equip2.Text == null)
                { lbljoueur5equip2.Text = joueur[5].Nom; }
                else if (lbljoueur6equip2.Text == null)
                { lbljoueur6equip2.Text = joueur[5].Nom; }
            }
            else if (joueur[5].NomEquipe == equipe[3].NomEquipe) // si le joueur appartient a l'équipe 3 //
            {
                if (lbljoueur1equip3.Text == null)
                { lbljoueur1equip3.Text = joueur[5].Nom; }
                else if (lbljoueur2equip3.Text == null)
                { lbljoueur2equip3.Text = joueur[5].Nom; }
                else if (lbljoueur3equip3.Text == null)
                { lbljoueur3equip3.Text = joueur[5].Nom; }
                else if (lbljoueur4equip3.Text == null)
                { lbljoueur4equip3.Text = joueur[5].Nom; }
                else if (lbljoueur5equip3.Text == null)
                { lbljoueur5equip3.Text = joueur[5].Nom; }
                else if (lbljoueur6equip3.Text == null)
                { lbljoueur6equip3.Text = joueur[5].Nom; }
            }
            else if (joueur[5].NomEquipe == equipe[4].NomEquipe) // si le joueur appartient a l'équipe 4 //
            {
                if (lbljoueur1equip4.Text == null)
                { lbljoueur1equip4.Text = joueur[5].Nom; }
                else if (lbljoueur2equip4.Text == null)
                { lbljoueur2equip4.Text = joueur[5].Nom; }
                else if (lbljoueur3equip4.Text == null)
                { lbljoueur3equip4.Text = joueur[5].Nom; }
                else if (lbljoueur4equip4.Text == null)
                { lbljoueur4equip4.Text = joueur[5].Nom; }
                else if (lbljoueur5equip4.Text == null)
                { lbljoueur5equip4.Text = joueur[5].Nom; }
                else if (lbljoueur6equip4.Text == null)
                { lbljoueur6equip4.Text = joueur[5].Nom; }
            }
            else if (joueur[5].NomEquipe == equipe[5].NomEquipe) // si le joueur appartient a l'équipe 5 //
            {
                if (lbljoueur1equip5.Text == null)
                { lbljoueur1equip5.Text = joueur[5].Nom; }
                else if (lbljoueur2equip5.Text == null)
                { lbljoueur2equip5.Text = joueur[5].Nom; }
                else if (lbljoueur3equip5.Text == null)
                { lbljoueur3equip5.Text = joueur[5].Nom; }
                else if (lbljoueur4equip5.Text == null)
                { lbljoueur4equip5.Text = joueur[5].Nom; }
                else if (lbljoueur5equip5.Text == null)
                { lbljoueur5equip5.Text = joueur[5].Nom; }
                else if (lbljoueur6equip5.Text == null)
                { lbljoueur6equip5.Text = joueur[5].Nom; }
            }
            else if (joueur[5].NomEquipe == equipe[6].NomEquipe) // si le joueur appartient a l'équipe 6 //
            {
                if (lbljoueur1equip6.Text == null)
                { lbljoueur1equip6.Text = joueur[5].Nom; }
                else if (lbljoueur2equip6.Text == null)
                { lbljoueur2equip6.Text = joueur[5].Nom; }
                else if (lbljoueur3equip6.Text == null)
                { lbljoueur3equip6.Text = joueur[5].Nom; }
                else if (lbljoueur4equip6.Text == null)
                { lbljoueur4equip6.Text = joueur[5].Nom; }
                else if (lbljoueur5equip6.Text == null)
                { lbljoueur5equip6.Text = joueur[5].Nom; }
                else if (lbljoueur6equip6.Text == null)
                { lbljoueur6equip6.Text = joueur[5].Nom; }
            }
            //joueur 6 //
            if (joueur[6].NomEquipe == equipe[1].NomEquipe) // si le joueur appartient a l'équipe 1 //
            {
                if (lbljoueur1equip1.Text == null)
                { lbljoueur1equip1.Text = joueur[6].Nom; }
                else if (lbljoueur2equip1.Text == null)
                { lbljoueur2equip1.Text = joueur[6].Nom; }
                else if (lbljoueur3equip1.Text == null)
                { lbljoueur3equip1.Text = joueur[6].Nom; }
                else if (lbljoueur4equip1.Text == null)
                { lbljoueur4equip1.Text = joueur[6].Nom; }
                else if (lbljoueur5equip1.Text == null)
                { lbljoueur5equip1.Text = joueur[6].Nom; }
                else if (lbljoueur6equip1.Text == null)
                { lbljoueur6equip1.Text = joueur[6].Nom; }
            }
            else if (joueur[6].NomEquipe == equipe[2].NomEquipe) // si le joueur appartient a l'équipe 2 //
            {
                if (lbljoueur1equip2.Text == null)
                { lbljoueur1equip2.Text = joueur[6].Nom; }
                else if (lbljoueur2equip2.Text == null)
                { lbljoueur2equip2.Text = joueur[6].Nom; }
                else if (lbljoueur3equip2.Text == null)
                { lbljoueur3equip2.Text = joueur[6].Nom; }
                else if (lbljoueur4equip2.Text == null)
                { lbljoueur4equip2.Text = joueur[6].Nom; }
                else if (lbljoueur5equip2.Text == null)
                { lbljoueur5equip2.Text = joueur[6].Nom; }
                else if (lbljoueur6equip2.Text == null)
                { lbljoueur6equip2.Text = joueur[6].Nom; }
            }
            else if (joueur[6].NomEquipe == equipe[3].NomEquipe) // si le joueur appartient a l'équipe 3 //
            {
                if (lbljoueur1equip3.Text == null)
                { lbljoueur1equip3.Text = joueur[6].Nom; }
                else if (lbljoueur2equip3.Text == null)
                { lbljoueur2equip3.Text = joueur[6].Nom; }
                else if (lbljoueur3equip3.Text == null)
                { lbljoueur3equip3.Text = joueur[6].Nom; }
                else if (lbljoueur4equip3.Text == null)
                { lbljoueur4equip3.Text = joueur[6].Nom; }
                else if (lbljoueur5equip3.Text == null)
                { lbljoueur5equip3.Text = joueur[6].Nom; }
                else if (lbljoueur6equip3.Text == null)
                { lbljoueur6equip3.Text = joueur[6].Nom; }
            }
            else if (joueur[6].NomEquipe == equipe[4].NomEquipe) // si le joueur appartient a l'équipe 4 //
            {
                if (lbljoueur1equip4.Text == null)
                { lbljoueur1equip4.Text = joueur[6].Nom; }
                else if (lbljoueur2equip4.Text == null)
                { lbljoueur2equip4.Text = joueur[6].Nom; }
                else if (lbljoueur3equip4.Text == null)
                { lbljoueur3equip4.Text = joueur[6].Nom; }
                else if (lbljoueur4equip4.Text == null)
                { lbljoueur4equip4.Text = joueur[6].Nom; }
                else if (lbljoueur5equip4.Text == null)
                { lbljoueur5equip4.Text = joueur[6].Nom; }
                else if (lbljoueur6equip4.Text == null)
                { lbljoueur6equip4.Text = joueur[6].Nom; }
            }
            else if (joueur[6].NomEquipe == equipe[5].NomEquipe) // si le joueur appartient a l'équipe 5 //
            {
                if (lbljoueur1equip5.Text == null)
                { lbljoueur1equip5.Text = joueur[6].Nom; }
                else if (lbljoueur2equip5.Text == null)
                { lbljoueur2equip5.Text = joueur[6].Nom; }
                else if (lbljoueur3equip5.Text == null)
                { lbljoueur3equip5.Text = joueur[6].Nom; }
                else if (lbljoueur4equip5.Text == null)
                { lbljoueur4equip5.Text = joueur[6].Nom; }
                else if (lbljoueur5equip5.Text == null)
                { lbljoueur5equip5.Text = joueur[6].Nom; }
                else if (lbljoueur6equip5.Text == null)
                { lbljoueur6equip5.Text = joueur[6].Nom; }
            }
            else if (joueur[6].NomEquipe == equipe[6].NomEquipe) // si le joueur appartient a l'équipe 6 //
            {
                if (lbljoueur1equip6.Text == null)
                { lbljoueur1equip6.Text = joueur[6].Nom; }
                else if (lbljoueur2equip6.Text == null)
                { lbljoueur2equip6.Text = joueur[6].Nom; }
                else if (lbljoueur3equip6.Text == null)
                { lbljoueur3equip6.Text = joueur[6].Nom; }
                else if (lbljoueur4equip6.Text == null)
                { lbljoueur4equip6.Text = joueur[6].Nom; }
                else if (lbljoueur5equip6.Text == null)
                { lbljoueur5equip6.Text = joueur[6].Nom; }
                else if (lbljoueur6equip6.Text == null)
                { lbljoueur6equip6.Text = joueur[6].Nom; }
            }ç*/
        }
    
    

   
       
           


        private void btnModifier_Click(object sender, EventArgs e) //si on clique sur le bouton modifier//
        {
            FrmModifier Frmmodifier = new FrmModifier(List<Equipe>equipe , List<Joueur>joueur, nombrejoueur);// crée une nouvelle form //
            Frmmodifier.ShowDialog();
            this.Hide();//cache la form acctuelle //
        }

        private void btnValider_Click(object sender, EventArgs e) //si on clique sur le bouton valider //
        {
            FrmSystPoint Frmsystpoint = new FrmSystPoint();// crée une nouvelle form //
            Frmsystpoint.ShowDialog();
            this.Hide();//cache la form acctuelle //
        }
    }
}
