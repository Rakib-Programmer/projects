
package com.mycompany.primenumber.or.molicnumber;

public class PrimeNumberOrMolicNumber {

    public static void main(String[] args) {
        int i,j;
        for(i=2; i<=25; i++){
            for(j=2; j<=i;j++){
                if(i%j==0)
                    break;
            }
            if(i==j)
                System.out.print(i+" ");
        }
    }
}
