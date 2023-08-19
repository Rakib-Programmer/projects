using System;
namespace Damo
{
    class Qud
    {
        public static void Main(string[] args)
        {
            double a, b, c, d, x1, x2, x;
            Console.Write("Enter The First number: ");
            a=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The Second number: ");
            b=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The Third number: ");
            c=Convert.ToDouble(Console.ReadLine());
            d=(b*b-4*a*c);
            if(d>0){
                x1=(-b+Math.Sqrt(d)/2*a);
                x2=(-b-Math.Sqrt(d)/2*a);
                Console.WriteLine(x1);
                Console.WriteLine(x2);
            }
            else if(d==0){
                x=(-b/2*a);
                Console.WriteLine(x);
            }
            else{
                Console.WriteLine("Root are imagiary");
            }

        }
    }
}