package com.mycompany.multilevelinheritance;
class Add{
    public void addition(int a, int b){
        System.out.println("Addition is: " + (a+b));
    }
}
class sub extends Add{
    public void subtraction(int a, int b){
        System.out.println("Subtraction is: " + (a-b));
    }
}
class Multi extends sub {
    public void multiplication(int a, int b){
        System.out.println("Multiplication is: " + (a*b));
    }
    public void display(){
        addition(10,20);
        subtraction(20,10);
        multiplication(10,5);
    }
}
public class MultilevelInheritance {

    public static void main(String[] args) {
        
        Multi m = new Multi();
        m.display();
    }
}
