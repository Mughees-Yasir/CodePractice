using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication8
{ 
class A
{
    public void display()
    {
        Console.WriteLine("hahahaha");
    }
}
class B : A
{
    public void display1()
    {
        Console.WriteLine("hihihih");
    }
}
class D : B
{
    public void display2()
    {

        Console.WriteLine("hohohohoh");
    }
}
class C
{
    public static void Main()
    {
        D x = new D();
        x.display();
        x.display1();
        x.display2();
    }
}
}