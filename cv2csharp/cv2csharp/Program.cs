using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace cv2csharp
{

    class Program
    {
        static void WorkWithStaticClass()
        {
            //RandomNumberGenerator generator = new RandomNumberGenerator(); - nefunguje když je static

            RandomNumberGenerator.GetClassName();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(RandomNumberGenerator.Next());
            }
        }

        private static void WorkWithDataTypes()
        {
            int x = 3;
            int y = x;
            y += 2;
            x++;
            Console.WriteLine($"x: {x}; y: {y}");

            //ComplexNumber number1 = new ComplexNumber(1,2);
            ComplexNumber number1 = new ComplexNumber() { First = 1, Second = 2 };
            //ComplexNumber number2 = number1;
            ComplexNumber number2 = new ComplexNumber(number1);
            number2.First += 2;
            number1.Second++;
            Console.WriteLine(number1);
            Console.WriteLine(number2);
        }

        private static int GetMagicWand(string text)
        {
            if (text.Length == 0)
            {
                return -1;
            }
            return text.Length;
        }

        private static void WorkWithNullableTypes()
        {
            int number1 = 3;
            int? number2 = null; //nelze pokud tam není ?
            ComplexNumber number3 = null;
            if (number2.HasValue) { 
                int number4 = number2.Value; // nelze páč nevíme esik je tam hodnota, s value nebo hasvalue to jde obejít
            }
            number3?.Thrid.GetType();
            ComplexNumber number5 = new ComplexNumber(1, 2, null);
            number5?.Thrid?.GetType();
        }

        private static bool TryParse(string text, out int result)
        {
            //int MAGIC_WAND = text.Length == 0 ? -1 : text.Length;
            int magicWand2 = GetMagicWand(text);

            bool isConverted = int.TryParse(text, out result);
            return isConverted;         
        }

        static void Main(string[] args)
        {
            //WorkWithStaticClass();
            WorkWithDataTypes();
            WorkWithNullableTypes();
            int a = 2;
            var b = a;
            int[,] array2d = new int[2,3]; //x - start
            int[][] array02 = new int[2][];
            array02[0] = new int[4]; //A - element
            array02[1] = new int[2];

            //0 1 2 3 4 5 6 7 8 9
            //x
            //    A A A A
            //            B B
        }       
    }
}
