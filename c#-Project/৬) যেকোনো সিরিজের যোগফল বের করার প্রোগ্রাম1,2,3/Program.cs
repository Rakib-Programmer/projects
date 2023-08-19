//1+2+3+....+10 ............................................................

using System;
namespace Damu{
    class Exercise{
        public static void Main(string[]args){
            int i, sum=0;
            for (i=1; i<=10; i++)
            // 1+3+5+7+....9
            //for (i=1; i<=9; i=i+2)
            {
                sum = sum+i;
            }
            Console.WriteLine("sum is: {0}",sum);
            
        }
    }
}

// 1+2+3+.....n .....................................................................
// using System;
// namespace Damu{
//     class Exercise{
//         public static void Main(string[]args){
//             int i, n, sum=0;
//             Console.Write("Enter The Number: ");
//             n=Convert.ToInt32(Console.ReadLine());
//             for (i=1; i<=n; i++)
//             {
//                 sum = sum+i;
//             }
//             Console.WriteLine("sum is: {0}",sum);
            
//         }
//     }
// }

// 1+3+5+7+....9  ..............................................................................
// using System;
// namespace Dam{
//     class Exercise{
//         public static void Main(string[]args){
            
//             int i, sum=0;
            
//             for (i=1; i<=9; i=i+2)
//             {
//                 sum = sum+i;
                
//             }
//             Console.WriteLine("sum is: {0}",sum);
            
//         }
//     }
// }

// 2+4+6+.......+20 ....................................................
// using System;
// namespace Damu{
//     class Exercise{
//         public static void Main(string[]args){
//             int i, sum=0;
//             for (i=2; i<=10; i=i+2)
//             {
//                 sum = sum+i;
//             }
//             Console.WriteLine("sum is: {0}",sum);
            
//         }
//     }
// }



// using System;
// namespace Damu{
//     class Exercise{
//         public static void Main(string[]args){
//             int i;
//             for (i=1; i<=10; i++)
//             {
//                 Console.WriteLine("sum is: {0}",i);
//             }
            
            
//         }
//     }
// }