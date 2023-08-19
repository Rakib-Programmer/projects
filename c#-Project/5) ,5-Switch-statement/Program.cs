using System;
namespace Hello{
    class Rakib{
        public static void Main(string[]args){
            char ch;
            Console.Write("Enter your testing charcter: ");
            ch=Convert.ToChar(Console.Read());
            switch(Char.ToLower(ch)){
                case 'a':
                Console.WriteLine("This is vowel");
                break;
                case 'e':
                Console.WriteLine("This is vowel");
                break;
                case 'i':
                Console.WriteLine("This is vowel");
                break;
                case 'o':
                Console.WriteLine("This is vowel");
                break;
                case 'u':
                Console.WriteLine("This is vowel");
                break;
                default:
                Console.WriteLine("This is consonent");
                break;
            }
        }
    }
}