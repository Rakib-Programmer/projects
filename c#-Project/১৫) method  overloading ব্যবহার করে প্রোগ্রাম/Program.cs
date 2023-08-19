using System;
namespace Damo{
    class Overload{
        public void add(int a, int b){
            Console.WriteLine(a+b);
        }
        public void add(float x, float y){
            Console.WriteLine(x+y);
        }
        public void add (string s1, string s2){
            Console.WriteLine(s1+s2);
        }
        static void Main(string[]args){
            Overload obj = new Overload();
            obj.add(100, 200);
            obj.add(10.5f, 20.5f);
            obj.add("CMT: ", "4th");
            Console.ReadKey();
        }
    }
}
