using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPerso
{
    internal class Systpoint
    {
        //attributs
        private int point1er;
        private int point2eme;
        private int point3eme;
        private int point4eme;
        private int point5eme;
        private int point6eme;
        private int pointelim;
        public Systpoint(int point1er, int point2eme, int point3eme, int point4eme, int point5eme, int point6eme, int pointelim)
        {
            this.Point1er = point1er;
            this.Point2eme = point2eme;
            this.Point3eme = point3eme;
            this.Point4eme = point4eme;
            this.Point5eme = point5eme;
            this.Point6eme = point6eme;
            this.Pointelim = pointelim;
        }

        //propriétés
        public int Point1er { get => point1er; set => point1er = value; }
        public int Point2eme { get => point2eme; set => point2eme = value; }
        public int Point3eme { get => point3eme; set => point3eme = value; }
        public int Point4eme { get => point4eme; set => point4eme = value; }
        public int Point5eme { get => point5eme; set => point5eme = value; }
        public int Point6eme { get => point6eme; set => point6eme = value; }
        public int Pointelim { get => pointelim; set => pointelim = value; }
        public override string ToString()
        {
            return $"{Point1er} {Point2eme} {Point3eme} {point4eme} {point5eme} {point6eme} {pointelim}";
        }
 
    }
}
