using System;
namespace _1_hw_classes__point_and_figure_
{
	public class Point
	{
		private byte _x;
		private byte _y;
		private string _name;

		public byte X {get => _x;}
        public byte Y { get => _y; }
        public string Name { get => _name; }

        public Point(byte x, byte y, string name)
		{
			_x = x;
			_y = y;
			_name = name;
		}
	}
}

