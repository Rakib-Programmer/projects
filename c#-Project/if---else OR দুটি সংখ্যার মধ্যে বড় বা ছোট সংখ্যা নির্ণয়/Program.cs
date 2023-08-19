using System;
namespace Rakib{
    class Hello{
        private static void Main(string[]args){
            int a,b;
            Console.Write("Enter Your First Number: ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your secound number: ");
            b=Convert.ToInt32(Console.ReadLine());
                                                                // বড় (a>b)  ছোট(a<b)
           if(a>b){          
            Console.WriteLine("your Largest number is: {0}",a);
           }
           else{
            Console.WriteLine("your Largest number is: {0}",b);
           }
        }
    }
}
