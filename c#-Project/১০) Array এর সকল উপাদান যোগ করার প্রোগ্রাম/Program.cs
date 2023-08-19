using System;
namespace Damu{
    class Array{
        public static void Main(){
            int [] arr = new int[5] {10, 100, 50, 20, 50};
            int i, sum=0, n;
            n = 5;
            
            for(i=0; i<n; ++i){
                sum=sum+arr[i];
                Console.WriteLine("sum is arr "+sum);
            }
            
            
        }
    }
}
