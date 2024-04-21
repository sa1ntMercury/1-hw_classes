using System;
namespace _1_hw_classes__book_
{
	public class Content
	{
        private string _content;

        public Content(string content)
        {
            _content = content;
        }

        public void Show()
        {
            Console.WriteLine(_content);
        }
    }
}

