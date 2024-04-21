using System;
namespace _1_hw_classes__rectangle_
{
    public class Rectangle
    {
        private double _side1;
        private double _side2;

        public double Area { get => AreaCalculator(); }
        public double Perimeter { get => PerimeterCalculator(); }

        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }

        private double AreaCalculator()
        {
            return _side1 * _side2;
        }

        private double PerimeterCalculator()
        {
            return 2 * (_side1 + _side2);
        }
    }
}

