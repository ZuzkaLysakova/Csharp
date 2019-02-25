using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{   
    /// <summary>
    /// Random number generator vith [-10,10] range.
    /// </summary>
    static public class RandomNumberGenerator
    {
        const int MIN_VALUE = -10;
        const int MAX_VALUE = 10;
        static Random random = new Random();
        /// <summary>
        /// Print class name without namespace.
        /// Returns class name.
        /// </summary>
        static public void GetClassName() {
            
            Console.WriteLine(nameof(RandomNumberGenerator));
        }

        /// <summary>
        /// Get next random number between [-10,10] range.
        /// </summary>
        /// <returns></returns>
        static public int Next()
        {   
            //aby vracel hodnoty mezi -10 - +10
            //random.Next() % 21 -10;
            return random.Next(MIN_VALUE,MAX_VALUE);

        }

         
    }
}
