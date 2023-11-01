using System;
class bank
{
    int x;
    int y;
    public bank(int a, int b)
    {
        x = a;
        y = b;
    }
    public bank()
    { }
    public void display()
    {
        Console.Write(" " + x);
        Console.Write(" " + y);
        Console.WriteLine();
    }
    public static bank operator -(bank b)
    {
        b.x = -b.x;
        b.y = -b.y;
        return b;
    }
    class program
    {
        public static void Main()
        {
            bank bal = new bank(10, -20);
            bal.display();
            bank ba2 = new bank();
            ba2.display();
            ba2 = -bal;
            ba2.display();
            Console.ReadLine();
        }
    }
}