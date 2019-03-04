using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fei
{
    namespace BaseLib
    {
        public class Reading
        {
            public static void nactiZKlavesnice()
            {

                Console.WriteLine("Zadej text: ");
                string text = Console.ReadLine();
                string jmeno = Reading.NactiString("Vase jmeno");
                int vek = Reading.NactiInt("Vas vek");
                char cisloPopisne = Reading.NactiChar("Vase PSC");
                double vyska = Reading.NactiDouble("Vase vyska");

            }
            //staticka verejna metoda na nacteni intu
            public static int NactiInt(string vyzva)
            {

                Console.WriteLine(vyzva); //vypsani vyzvy
                return Convert.ToInt32(Console.ReadLine()); //vraceni a prekonvertovani stringu na int

            }
            //staticka verejna metoda na nacteni doublu
            public static double NactiDouble(string vyzva)
            {
                Console.WriteLine(vyzva); //vypsani vyzvy
                return Convert.ToDouble(Console.ReadLine()); //vraceni a prekonvertovani stringu na double
            }
            //staticka verejna metoda na nacteni charu
            public static char NactiChar(string vyzva)
            {
                Console.WriteLine(vyzva); //vypsani vyzvy
                return Convert.ToChar(Console.ReadLine()); //vraceni a prekonvertovani stringu na char

            }
            //staticka verejna metoda na nacteni stringu
            public static string NactiString(string vyzva)
            {
                Console.WriteLine(vyzva); //vypsani vyzvy
                return Convert.ToString(Console.ReadLine()); //vraceni a prekonvertovani stringu na string
            }
        }
    }
}


