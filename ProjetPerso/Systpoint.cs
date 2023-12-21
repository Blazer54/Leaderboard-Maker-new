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
        public Systpoint(string pointclass)
        {
            this.Pointclass = pointclass;  
        }

        //propriétés
        public string Pointclass { get => pointclass; set => pointclass = value; }
   
        public override string ToString()
        {
            return $"{Pointclass} ";
        }
 
    }
}
