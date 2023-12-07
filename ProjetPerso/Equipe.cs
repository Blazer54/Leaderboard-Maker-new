using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPerso
{

    internal class Equipe
    {
        //attributs
        private string nomEquipe;

        public Equipe(string nomEquipe)
        {
            this.NomEquipe = nomEquipe;
        }

        //propriétés
        public string NomEquipe { get => nomEquipe; set => nomEquipe = value; }

        public override string ToString()
        {
            return $"{NomEquipe}";
        }
    }
}
