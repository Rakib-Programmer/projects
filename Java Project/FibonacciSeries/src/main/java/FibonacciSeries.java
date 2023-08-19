import java.util.Scanner;
public class FibonacciSeries {

    public static void main(String[] args) {
        Scanner s=new Scanner(System.in);
        int n, a=0, b=1, c;
        System.out.print("Enter ranng: ");
        n=s.nextInt();
        while(a<=n){
            System.out.print(a+", ");
            c=a+b;
            a=b;
            b=c;
        }
    }
}
