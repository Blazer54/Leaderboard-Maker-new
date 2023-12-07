using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPerso
{
    public class Joueur
    {
        //creation des attributs de la classe
        private string nomEquipe;
        private string nom;

        public Joueur(string nom, string nomEquipe)
        {
            this.Nom = nom;
            this.NomEquipe = nomEquipe;
        }

        public string Nom { get => nom; set => nom = value; }
        public string NomEquipe { get => nomEquipe; set => nomEquipe = value; }

        public override string ToString() 
        {
            return $"{Nom} {NomEquipe}";
        }
    }
}
