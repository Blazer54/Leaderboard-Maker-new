using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPerso
{
    internal class Joueur
    {
        //creation des attributs de la classe
        string nom, nomEquipe;

        public Joueur(string nom, string nomEquipe)
        {
            this.nom = nom;
            this.nomEquipe = nomEquipe;
        }

        public override string ToString() 
        {
            return $"{nom} {nomEquipe}";
        }
    }
}
