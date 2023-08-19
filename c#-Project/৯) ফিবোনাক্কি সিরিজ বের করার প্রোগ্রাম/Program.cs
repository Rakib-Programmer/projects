using System;
namespace Damu{
    class Fimo{
        public static void Main(){
            int a=0, b=1, c, i, Nunber;
            Console.Write("Enter The Number: ");
            Nunber = Convert.ToInt32(Console.ReadLine());
            Console.Write(a+" "+b+" ");
            for(i=2; i<Nunber; ++i){
                c=a+b;
                Console.Write(c+" ");
                a=b;
                b=c;
            }
        }
    }
}


