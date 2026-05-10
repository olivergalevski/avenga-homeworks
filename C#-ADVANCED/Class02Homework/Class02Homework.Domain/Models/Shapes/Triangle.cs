using Class02Homework.Domain.Interfaces;

namespace Class02Homework.Domain.Models.Shapes
{
    public class Triangle : Shape, IShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double Height { get; set; }

        public Triangle(double sideA, double height)
        {
            SideA = sideA;
            Height = height;
        }
        public Triangle(double sideA, double sideB, double sideC, double height)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Height = height;
        }

        public double GetArea()
        {
            return (SideA * Height) / 2;
        }
        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }

        public override double CalculateArea()
        {
            return (SideA * Height) / 2;
        }
    }
}