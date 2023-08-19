using System;
public class Student{
    public int roll=19;
}
public class Marks : Student{
    public int mark=83;
}
public class Result : Marks{
    public float gpa=3.80f;
}
class Inher{
    public static void Main(string[]args){
        Result r = new Result();
        Console.WriteLine("My Roll is: "+r.roll);
        Console.WriteLine("My Marks is: "+r.mark);
        Console.WriteLine("My GPA is: "+r.gpa);
    }
}
