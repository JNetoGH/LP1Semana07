using System;

namespace FillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Sphere(new Color(255, 255, 255, 255), 5);
            Console.WriteLine(s1.GetColor());
            
        }
    }
}