using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPerso
{
    internal class StockagePoint
    {
        //attributs
        private int pointclass;
        private int pointelim;
        public StockagePoint(int pointclass, int pointelim)
        {
            this.Pointclass = pointclass;
            this.Pointelim = pointelim;
        }

        //propriétés
        public int Pointclass { get => pointclass; set => pointclass = value; }
        public int Pointelim { get => pointelim; set => pointelim = value; }

        public override string ToString()
        {
            return $"{Pointclass} {Pointelim} ";
        }

    }
}
