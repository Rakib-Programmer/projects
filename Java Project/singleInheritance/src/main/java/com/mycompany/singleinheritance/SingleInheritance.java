package com.mycompany.singleinheritance;
class Add{
    public void addition(int a, int b){
        System.out.println("Addition is: " + (a+b));
    }
}
class sub extends Add{
    public void subtraction(int a, int b){
        System.out.println("Subtraction is: " + (a-b));
    }
    public void display(){
        addition(10,20);
        subtraction(20,10);
    }
}
public class SingleInheritance {
    
    public static void main(String[] args) {
        
        sub s=new sub();
        s.display();
    }
}
