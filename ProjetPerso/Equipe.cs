using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPerso
{

    internal class Equipe
    {
        string nomJoueur;

        public Equipe(string nomJoueur)
        {
            this.nomJoueur = nomJoueur;
        }

        public override string ToString()
        {
            return $"{nomJoueur}";
        }
    }
}
