using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPerso
{
    public class Partie
    {
        private string nomEquipe;
        private int placement;
        private int kill;

        public Partie(string nomEquipe, int placement, int kill) 
        {
            this.NomEquipe = nomEquipe;
            this.Placement = placement;
            this.Kill = kill;
        }

        public string NomEquipe { get => nomEquipe; set => nomEquipe = value; }
        public int Placement { get => placement; set => placement = value; }
        public int Kill { get => kill; set => kill = value; }
        public override string ToString()
        {
            return $"{NomEquipe} {Placement} {Kill}";
        }
    }
}
