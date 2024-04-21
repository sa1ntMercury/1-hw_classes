using System;
namespace _1_hw_classes__point_and_figure_
{
	public class Figure
	{
        #region variant with params in constructor
        /*
		private Point[] _points;

		public Figure(params Point[] points)
		{
			_points = points;
		}
		private double LenghtSide (Point A, Point B)
		{
			return  Math.Sqrt(Math.Pow((B.X - A.X),2) + Math.Pow((B.Y - A.Y),2));
		}

		public void PerimeterCalculator()
		{
			double perimeter = 0;
            string name = null;

            for (int i = 0; i < _points.Length; i++)
			{
				if (_points.Length - i > 1)
				{
					perimeter += LenghtSide(_points[i], _points[i + 1]);
				}
				else
				{
                    perimeter += LenghtSide(_points[i], _points[0]);
                }

				name += _points[i].Name;
			}
			Console.WriteLine($"Figure - {name}\tPerimeter = {perimeter}");
		}
		*/
        #endregion

        public string Name { get; private set; }
        public double Perimeter { get; private set; }

        public Figure(Point A, Point B, Point C)
        {
            PerimeterCalculator(A, B, C);
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            PerimeterCalculator(A, B, C, D);
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            PerimeterCalculator(A, B, C, D, E);
        }

        private double LenghtSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
        }

        private void PerimeterCalculator(params Point[] _points)
        {  
            for (int i = 0; i < _points.Length; i++)
            {
                if (_points.Length - i > 1)
                {
                    Perimeter += LenghtSide(_points[i], _points[i + 1]);
                }
                else
                {
                    Perimeter += LenghtSide(_points[i], _points[0]);
                }

                Name += _points[i].Name;
            }
        }

    }
}

