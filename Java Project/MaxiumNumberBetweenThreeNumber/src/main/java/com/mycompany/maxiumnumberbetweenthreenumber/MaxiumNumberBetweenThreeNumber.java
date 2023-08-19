
package com.mycompany.maxiumnumberbetweenthreenumber;
import java.util.Scanner;
public class MaxiumNumberBetweenThreeNumber {
    public static void main(String[] args) {
        Scanner s=new Scanner(System.in);
        int a,b,c;
        System.out.print("Enter first number: " );
        a=s.nextInt();
        System.out.print("Enter second number: " );
        b=s.nextInt();
        System.out.print("Enter third number: " );
        c=s.nextInt();
        if(a>b){
            if(a>c)
                System.out.print("A is largest number");
            else
                System.out.print("c is largest number");
        }
        else{
            if(b>c)
                System.out.print("b is largest number");
            else
                System.out.print("c is largest number");
    }
}
}
