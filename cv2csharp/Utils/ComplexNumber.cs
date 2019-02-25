using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class ComplexNumber
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int? Thrid { get; set; }

        public ComplexNumber()
        {

        }
        public ComplexNumber(int first, int second, int? third)
        {
            First = first;
            Second = second;
            Thrid = third;
        }

        public ComplexNumber(ComplexNumber source)
        {
            First = source.First;
            Second = source.Second;
            Thrid = source.Thrid;
        }

        public override string ToString()
        {
            return "[" + First.ToString() + "; " + Second.ToString() + "; " + Thrid.ToString() + "]";
        }


    }
}
