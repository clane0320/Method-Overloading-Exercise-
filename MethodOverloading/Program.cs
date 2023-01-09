using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    public class Program
   
    {
        //Create a method named Add, that accepts two integers and returns the sum of 
        //those two integers

        public static int Add(int x1, int y2)
        {
            return x1 + y2;
        }

        public static decimal Add(decimal x1, decimal y2)
        {
            return x1 + y2;
        }

        public static string Add(int x1, int y2, bool isCheck)
        {
            var sum = x1 + y2;

            if (isCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCheck == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isCheck == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }

        static void Main(string[] args)
        {
            var x1 = 569;
            var y2 = 256;

            var answer = Add(x1, y2);

            var x = 12.5m;
            var y = 66.0m;

            var decimalAnswer = Add(x, y);

            var thirdAnswer = Add(2, 5, true);

            Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
            Console.WriteLine(thirdAnswer);
        }
    }
}