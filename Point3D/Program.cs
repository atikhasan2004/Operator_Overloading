using System;
using System.Drawing;
class Point3D
{
    public int x,y,z;
    public Point3D(int x , int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public static Point3D operator * (Point3D a , Point3D b)
    {
        return new Point3D (a.x * b.x , a.y * b.y , a.z * b.y);
    }
    public static Point3D operator + (Point3D a , Point3D b)
    {
        return new Point3D (a.x + b.x , a.y + b.y , a.z + b.y);
    }
    public void Display()
    {
        Console.WriteLine($"x={x} , y={y} , z={z}");
    }
}
class Program
{
    static void Main(string [] args)
    {
        Point3D p1 = new Point3D (1 , 2 , 3);
        Point3D p2  = new Point3D (4 , 5 , 6);
        Point3D p3 = new Point3D (7 , 8 , 9);
        Point3D result = (p1 * p2) + p3 ;
        result.Display();
    }
}