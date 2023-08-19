package sumofseires;
import java.util.Scanner;
public class SumOfSeires {

    public static void main(String[] args) {
        Scanner s=new Scanner(System.in);
        int n,i,sum=0;
        System.out.print("Enter The value of n: ");
        n=s.nextInt();
//        for(i=1; i<=n; i++){
//            //1+2+3+3+4+...
////            sum = sum+i;
////            1*2*3*4*..
////              sum = sum*i;
//              //1*1+2*2+3*3...
//              sum = sum+(i*i);
//        }
//            1+3+5...
//           for(i=1; i<=n; i=i+2){
//               sum=sum+i;
//           }
//            2+4+6+8...
            for(i=2; i<=n; i=i+2){
               sum=sum+i;
           }
        System.out.print("The summation of serise is: "+sum);
        
    }
}
