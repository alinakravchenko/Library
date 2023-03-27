using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    static class Generator
    {
        private static Random random = new Random();
        public static int newInteger(int min, int max)
        {
            if (min > max)
            {
                min = max;
            }
            return random.Next(min, max);
        }

        public static string newString(int length)
        {
            if (length <= 0)
            {
                return "";
            }
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                char letter = Convert.ToChar(
                    Convert.ToInt32(Math.Floor(('z' - 'a' + 1) * random.NextDouble())) + 'a');
                if (i == 0)
                {
                    letter = Char.ToUpper(letter);
                }
                builder.Append(letter);
            }

            return builder.ToString();
        }
    }
}
