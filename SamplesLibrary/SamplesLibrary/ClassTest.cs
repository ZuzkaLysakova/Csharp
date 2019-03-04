using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni03.SamplesLibrary
{
    internal class MyInteger
    {

        //public uint Value { get; set; }
        public uint Value { get { return Value; } set { Value = value; } }
        public bool Signed { get; private set; }
        public bool Minus { get; private set; }

        private uint value2;

        public int Value2
        {
            get { return (int)value2; }
            set
            {

                if(value > 1000000)
                {
                    throw new ArgumentOutOfRangeException("value cannot be higher then 1000000");
                }
                Minus = value < 0; //side-effec bad
                value2 = (uint)value;
            }
        }
        public static int GetMaxInt()
        {
            return int.MaxValue;
        }

        public int Value3 { get; set; } = 15;
        public int value4 => GetMaxInt() * 3;

        

        public MyInteger()
        {
        }
        public MyInteger(uint value, bool signed) {
            Value = value;
            Signed = signed;
        }

        public static implicit operator MyInteger(int v)
        {
            return new MyInteger() { Value = (uint)Math.Abs(v), Signed = v < 0 };
        }
    }

    class ClassTest
    {
        public static void DoIt()
        {
            MyInteger myInteger = new MyInteger() { Value = 33 };
            MyInteger myInteger2 = new MyInteger(33, true);
            MyInteger myInteger3 = 125;
        }
        

    }
}
