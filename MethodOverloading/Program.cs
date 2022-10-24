using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    public class Program
    {

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool yay)
        {
            int answer3 = num1 + num2;

            if (answer3 > 1 && yay == true)
                return $"{answer3} dollars";
            
            else if (answer3 == 1 && yay == true)
                return $"{answer3} dollar";
            
            else
                return ($"program is stopped.  It is false");

            
        }

        
          
            
        



        static void Main(string[] args)
        {
            var x = 6;
            var y = 7;
            var answerOne = (x + y);
            
            Console.WriteLine(answerOne);

            var a = 6.8m;
            var b = 5.4m;
            var answerTwo = (a + b);

            Console.WriteLine(answerTwo);

            var answerThree = Add(0, 0, true);
            Console.WriteLine(answerThree);

        }
    }
}
