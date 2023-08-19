using System;
namespace Damu{
    class Array{
        public static void Main(){
            int [] arr = new int[5] {10, 100, 50, 20, -50};
            int i, max, min, n;
            n = 5;
            max = arr[0];
            min = arr[0];
            for(i=1; i<n; i++){
                if(arr[i]>max){
                    max = arr[i];
                }
                if(arr[i]<min){
                    min = arr[i];
                }
            }
            Console.WriteLine("Max array is: {0}",max);
            Console.WriteLine("Min array is: {0}",min);
        }
    }
}

//Array এর সকল উপাদান যোগ করার প্রোগ্রাম 

// using System;
// namespace Damu{
//     class Array{
//         public static void Main(){
//             int [] arr = new int[5] {10, 100, 50, 20, 50};
//             int i, sum=0, n;
//             n = 5;
            
//             for(i=0; i<n; ++i){
//                 sum=sum+arr[i];
//                 Console.WriteLine("sum is arr "+sum);
//             }
            
            
//         }
//     }
// }
