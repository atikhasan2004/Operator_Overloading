using System;
class Complex
{
    public int real;
    public int img;
    public Complex(int r , int i)
    {
        real = r;
        img = i;
    }
    public static Complex operator + (Complex c1 , Complex c2)
    {
        return new Complex (c1.real + c2.real , c1.img + c2.img);
    }
    public void Display()
    {
        Console.WriteLine($"{real} + {img}i");
    }
}
class Program
{
    static void Main(string [] args)
    {
        Complex a = new Complex (1 , 3);
        Complex b  = new Complex (2 , 4);
        Complex result = a + b;
        result.Display();
    }
}