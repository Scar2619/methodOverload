using System;

namespace methodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static int Add(int x, int y)
        {
            return x += y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return x += y;
        }
        public string Add(int x, int y, bool isTrue)
        {
            var sum = 0;
            var response = "";

            if (isTrue)
            {
                sum = x + y;

                if (sum == 1)
                {
                    response = $"{sum} dollar.";
                }
                else
                {
                    response = $"{sum} dollars.";
                }
            }
            return response;

        }
    }
}

