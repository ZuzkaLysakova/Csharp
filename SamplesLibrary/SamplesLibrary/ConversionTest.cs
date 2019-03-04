using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni03.SamplesLibrary 
{
    internal class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Person(int iD)
        {
            ID = iD;
        }

        public override string ToString()
        {
            return ID + Name; //implicitne
            //return base.ToString();
        }

        public static implicit operator Person(int v)
        {
            return new Person(v);
        }
        public static implicit operator int(Person pers)
        {
            return pers.ID;
        }

        
    }


    public static class ConversionTest
    {
        public static void DoIt()
        {
            double realNumber = 3.14;
            realNumber = Math.PI;
            realNumber = 10;
            realNumber = 10.0;
            realNumber = (double)10;

            int integerNumber = 3;
            integerNumber = (int)3.14;
            integerNumber = (int)Math.Round(3.14);
            integerNumber = Convert.ToInt32(realNumber);
            integerNumber = Convert.ToInt32(Math.PI);

            Person person = new Person(1);
            Person person2 = (Person)integerNumber;
            int integerNumber2 = person2; //ok

            object pers3= new Person(2);
            
            (pers3 as Person).Name = "Jarda";

            if(pers3 is Person)
            {

            }
            if(pers3 is Person pers4) { }
            //if(pers3.GetType() == typeof(Person)) { }
        }

    }
}
