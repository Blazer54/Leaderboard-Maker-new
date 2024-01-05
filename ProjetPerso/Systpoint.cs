using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPerso
{
    public class Systpoint
    {
        //attributs
        private string pointclass;
        private string pointelim;
        public Systpoint(string pointclass, string pointelim)
        {
            this.Pointclass = pointclass;
            this.Pointelim = pointelim;
        }

        //propriétés
        public string Pointclass { get => pointclass; set => pointclass = value; }
        public string Pointelim { get => pointelim; set => pointelim = value; }

        public override string ToString()
        {
            return $"{Pointclass} {Pointelim} ";
        }
 
    }
}
