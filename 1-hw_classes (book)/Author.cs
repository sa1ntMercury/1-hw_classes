using System;
namespace _1_hw_classes__book_
{
	public class Author
	{
        private string _author;

        public Author(string author)
        {
            _author = author;
        }

        public void Show()
        {
            Console.WriteLine(_author);
        }
    }
}

