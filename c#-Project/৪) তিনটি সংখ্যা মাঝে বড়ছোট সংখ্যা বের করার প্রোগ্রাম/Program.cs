using System;
namespace Demo
{
    class MYApplication{
        public static void Main(string[]args){
            int a, b, c;
           Console.Write("Enter The First Number: ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The second Number: ");
            b=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Third Number: ");
            c=Convert.ToInt32(Console.ReadLine());
            if (a>b && a>c)
            {
                Console.Write("Your largest Number is: {0}",a);
            }
            else if(b>c && b>a)
            {
                Console.Write("Your largest Number is: {0} ",b);
            }
            else
            {
             Console.Write("Your largest Number is: {0}",c);  
            }
        }
    }
}