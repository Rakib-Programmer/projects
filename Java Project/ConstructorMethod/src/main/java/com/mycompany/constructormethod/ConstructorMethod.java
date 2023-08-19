package com.mycompany.constructormethod;
public class ConstructorMethod {
    int roll, mark;
    public ConstructorMethod(){
        roll= 583946;
        mark= 89;
        System.out.println("Roll is: "+roll);
        System.out.println("Mark is: "+mark);
    }
    public static void main(String[] args) {
       ConstructorMethod c=new ConstructorMethod();
       
    }
}
