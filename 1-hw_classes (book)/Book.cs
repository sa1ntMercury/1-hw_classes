using System;
namespace _1_hw_classes__book_
{
	public class Book
	{
		private Title _title;
		private Author _author;
		private Content _content;

		public Book (string title, string author, string content)
		{
			_title = new Title(title);
			_author = new Author(author);
			_content = new Content(content);
		}

		public void Show()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			_title.Show();
			Console.ForegroundColor = ConsoleColor.Green;
			_author.Show();
			Console.ForegroundColor = ConsoleColor.Blue;
			_content.Show();
        }
	}
}

