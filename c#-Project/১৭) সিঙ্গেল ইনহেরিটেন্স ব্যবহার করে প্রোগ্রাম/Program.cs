using System;
public class Student{
    public int roll=19;
}
public class Result : Student{
    public float gpa=3.80f;
}
class Inher{
    public static void Main(string[]args){
        Result r = new Result();
        Console.WriteLine("My Roll is: "+r.roll);
        Console.WriteLine("My GPA is: "+r.gpa);
    }
}