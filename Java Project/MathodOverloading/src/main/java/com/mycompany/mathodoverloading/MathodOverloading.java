
package com.mycompany.mathodoverloading;
public class MathodOverloading {
    public int add(int a, int b){
        return(a+b);
    }
    public int add(int a, int b, int c){
        return (a+b+c);
    }
    public float add(float a, float b){
        return (a+b);
    }
    public static void main(String[] args) {
        MathodOverloading m=new MathodOverloading();
        System.out.println(m.add(3.5f, 4.5f));
        System.out.println(m.add(10, 20, 30));
        System.out.println(m.add(10, 20));
        
    }
}
