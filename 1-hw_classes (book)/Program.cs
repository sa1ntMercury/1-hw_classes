using _1_hw_classes__book_;

Console.WriteLine("Iput book title:");
string title = Console.ReadLine();

Console.WriteLine("Iput book author:");
string author = Console.ReadLine();

Console.WriteLine("Iput book content:");
string content = Console.ReadLine();


Book book = new Book(title, author, content);

book.Show();