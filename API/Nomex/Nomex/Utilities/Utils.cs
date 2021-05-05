using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Nomex.Utilities
{
    public class Utils
    {
        private static Random r = new Random();
        private static int[] Digits = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        public static string GeneratePersonalCode(int length = 5)
        {
            string code = "";
            for (int i = 0; i < length; i++)
            {
                code += Digits[r.Next(0, Digits.Length)];
            }
            return code;
        }
    }
}
