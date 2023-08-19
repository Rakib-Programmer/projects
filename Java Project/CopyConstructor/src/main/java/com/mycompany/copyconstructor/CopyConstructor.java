package com.mycompany.copyconstructor;
public class CopyConstructor {
    int length, width;
    CopyConstructor(int l, int w){
        length=l;
        width= w;
    }
    CopyConstructor(CopyConstructor c){
        length = c.length;
        width = c.width;
    }
    int area(){
        int a;
        a=length*width;
        return a;
    }
    public static void main(String[] args) {
        CopyConstructor obj = new CopyConstructor(5,6);
        CopyConstructor obj1 = new CopyConstructor(obj);
        System.out.println("Area is p: "+obj.area());
        System.out.println("Area is c: "+obj1.area());
    }
}
