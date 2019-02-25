using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv1csharp
{
    class Address
    {
        public string Street;
        public string Number;
        public string City;
        public string Postcode;
    }
    class Person
    {
        public string Name;
        public string Surname;
        public Address Address;
    }

    class Program
    {
        const uint DEFAULT_COUNT = 100;
        static uint GetCount(string[] args)
        {
            //uint count = 100;
            if (args.Length == 0) return DEFAULT_COUNT;

            if (uint.TryParse(args[0], out uint temp)) return temp;
            //uint.TryParse(args[0], out count); //out predavani pomoci reference
            return DEFAULT_COUNT;
        }
        static void Main(string[] args)
        {
            /*Console.Write("Hello world!");
            //Console.ReadLine();
            Console.WriteLine("You sure?"); //zkracene cw tab
            uint count = GetCount(args);
            //uint count = uint.Parse(args[0]);
            //string grettings = "Hello worl";//string s maly s je alias
            ////String grettings2 = new string("Hello world");


            //for (uint i = 0; i < count; i++)
            //{
            //    grettings += "again ";
            //}

            //grettings = grettings.Insert(grettings.Length -1, "!");
            //Console.WriteLine(grettings);

            if (count != 0)
            {
                StringBuilder gretingsBuilder = new StringBuilder();
                gretingsBuilder.Append("Helo world again");
                for (int i = 1; i < count; i++)
                {
                    gretingsBuilder.Append(" again");
                }
                gretingsBuilder.Append("!");
                Console.WriteLine(gretingsBuilder.ToString());
            }*/

            Person pres = new Person();
            Address add = new Address();
            //Console.WriteLine(pres, add);
            
        }
        //vyresit aby za poslednim again nebyla mezera
        //vyresit aby se to zvladlo vyresit velke cislo za kratky cas
        //ctrl k, d - odsazení
        
    }
}
