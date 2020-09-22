using System;
namespace XDLopQuadraticEquation_

{
    internal class QuadraticEquation
    {
        private double a { set; get; }
        private double b { set; get; }
        private double c { set; get; }
        
        public QuadraticEquation()
        {

        }
        public QuadraticEquation(double a,double b,double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double GetDiscriminant()
        {
            double delta;
            return delta = b * b - (4 * a * c);
        }
        public double GetTruonghop1()
        {
            return -b / (2.0 * a);
        }
        public double GetTruonghop2()
        {
            return (-b + Math.Sqrt(GetDiscriminant())) / (2 * a);
        }

        public double GetTruonghop3()
        {
            return (-b - Math.Sqrt(GetDiscriminant())) / (2 * a);
        }
    }
}