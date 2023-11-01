using System;

delegate void MDelegate();

class DM
{
    public static void Display()
    {
        Console.WriteLine("New Delhi");
    }

    public static void Print()
    {
        Console.WriteLine("New York");
    }
}

class MTest
{
    public static void Main()
    {
        MDelegate m1 = new MDelegate(DM.Display);
        MDelegate m2 = new MDelegate(DM.Print);

        MDelegate m3 = m1 + m2;
        MDelegate m4 = m2 + m1;
        MDelegate m5 = m3 - m2;

        m3();
        m4();
        m5();
    }
}
