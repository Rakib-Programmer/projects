using System;
namespace Rakib
{
     class Swap
{
    public static void Main(string[]args)
    {
        int a, b, c;
        Console.Write("Enter The First Number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter The Second Number: ");
        b  = Convert.ToInt32(Console.ReadLine());
        c=a;
        a=b;
        b=c;
        
        Console.WriteLine("First Number is:"+a);
        Console.WriteLine("Secons Number is:"+b);
    }
}
}
