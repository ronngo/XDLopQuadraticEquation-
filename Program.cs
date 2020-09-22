using System;

namespace XDLopQuadraticEquation_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Nhap a :");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b :");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c :");
            double c = double.Parse(Console.ReadLine());
            QuadraticEquation quadraticequation = new QuadraticEquation(a,b,c);

            if (quadraticequation.GetDiscriminant() > 0)
            {
                Console.WriteLine("PT co 2 nghiem !");
                Console.WriteLine("X1 = " + quadraticequation.GetTruonghop2());
                Console.WriteLine("X2 = " + quadraticequation.GetTruonghop3());
            }
            else if (quadraticequation.GetDiscriminant() == 0)
            {
                Console.WriteLine("PT co 1 nghiem duy nhat x = " + quadraticequation.GetTruonghop1());
            }
            else
                Console.WriteLine("PT vo nghiem !");
        }
    }
}
