using System;
namespace rakib{
    class Hello{
        public static void Main(string[]args)
        {
            double pi=3.1416,r,area;
            Console.Write("Enter your radious: ");
            r=Convert.ToDouble(Console.ReadLine());
            area=pi*r*r;
            Console.WriteLine(area);
        }
    }
}
