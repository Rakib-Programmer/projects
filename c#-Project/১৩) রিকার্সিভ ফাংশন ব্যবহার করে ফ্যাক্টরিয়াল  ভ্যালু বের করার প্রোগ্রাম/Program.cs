using System;
namespace Damu{
    class faci{
        static void Main(string[]args){
            Console.Write(" Input the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            long Fact = Factorial(n);
            Console.WriteLine("The Factorial of {0} is: {1}", n ,Fact);
            Console.ReadKey();
        }
        public static long Factorial(int n){
            if (n == 0){
                return 1;
            }
            return n*Factorial(n-1);
        }
    }
}
