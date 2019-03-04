using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni03.SamplesLibrary
{
    public static class OverflowUnderflow
    {
        public static void DoIt()
        {
            uint max = uint.MaxValue;
            uint min = uint.MinValue;

            Console.WriteLine($"max: {max}, min: {min}");

            checked
            {
                /*unchecked
                {
                }*/
                max++;
                min--;
            }
            
            Console.WriteLine($"max: {max}, min: {min}");
        }
        
    }
}
