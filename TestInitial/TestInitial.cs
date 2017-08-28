using System;

public class TestInitial
{
    private static int b;
    private int c = 1;
    private int d;
    public TestInitial()
    {
        Console.WriteLine("In TestInitial constructor");
        Console.WriteLine("c = {0}", c);
        Console.WriteLine("d = {0}", d);
        //"d" has no value until initialized, it is given it's type default of 0. No hoisting in C#
        d = 2;
    }
    public static void Main(string[] args)
    {
        int a;
        Console.WriteLine("b = {0}", b);
        TestInitial ti = new TestInitial();
        Console.WriteLine("In Main after TestInitial has been constructed");
        Console.WriteLine("c = {0}", ti.c);
        Console.WriteLine("d = {0}", ti.d);
    }
}