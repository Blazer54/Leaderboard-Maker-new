using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPerso
{

    internal class Equipe
    {
        string nomEquipe;

        public Equipe(string nomEquipe)
        {
            this.nomEquipe = nomEquipe;
        }

        public override string ToString()
        {
            return $"{nomEquipe}";
        }
    }
}
