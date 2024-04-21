using System;
namespace _1_hw_classes__book_
{
	public class Title
	{
		private string _title;

        public Title(string title)
		{
			_title = title;
		}

		public void Show()
		{
			Console.WriteLine(_title);
		}
	}
}

