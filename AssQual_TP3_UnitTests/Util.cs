using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssQual_TP3_UnitTests
{
    class Util
    {
        public static int[] GetRandomIntArray(int arrayLength)
        {
            int min = 0;
            int max = 5000;
            int[] randIntArray = new int[arrayLength];

            Random randNum = new Random();
            for (int i = 0; i < randIntArray.Length; i++)
            {
                randIntArray[i] = randNum.Next(min, max);
            }

            return randIntArray;
        }

        public static int[] GetOrderedIntArray(int arrayLength)
        {
            return Enumerable.Repeat(0, arrayLength).ToArray(); ;
        }
    }
}
