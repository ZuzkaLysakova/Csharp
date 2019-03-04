using Cviceni03.SamplesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Cviceni03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Random number: {RandomNumberGenerator.Next()}");
            //RandomNumberGenerator.Next();
            ConversionTest.DoIt();
            OverflowUnderflow.DoIt();

        }
    }
}
