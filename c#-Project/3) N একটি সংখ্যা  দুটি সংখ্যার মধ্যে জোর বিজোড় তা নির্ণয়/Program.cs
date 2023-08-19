using System;
namespace Rakib{
class Hello{
        private static void Main(string[]args){
           int N;
           Console.Write("Enter your number: ");
           N=Convert.ToInt32(Console.ReadLine());
           if(N%2==0){
            Console.Write("This is Even number");
           }
           else{
            Console.Write("This is odd number");
           }
        }
    }
}

