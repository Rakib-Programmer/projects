package com.mycompany.triangle;
import java.util.Scanner;
public class Triangle {

    public static void main(String[] args) {
    Scanner s=new Scanner(System.in);
    double base,hight, area;
    System.out.print("Enter tne base: ");
    base=s.nextDouble();
    System.out.print("Enter tne hight: " );
    hight=s.nextDouble();
    area=0.5*base*hight;
    System.out.print("The area ia Tringle: "+ area);
    }
}
