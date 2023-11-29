abstract class Edition
{
    protected string title;
    protected string author;
    public Edition (string title, string author)
    {
        this.title = title;
        this.author = author;
    }
    abstract public void CompareTo();
}
class Book : Edition
{   
    public static string [] books = new string[100];
    public static int i = 0; 
    int year;
    string publisher;
    public Book(string title, string author, int year, string publisher) : base(title, author)
    {
        this.year = year; 
        this.publisher = publisher;
        CompareTo();
    }
    public override void CompareTo()
    {   
        books[i] += title + " " + author + " " + year.ToString() + " " + publisher;
        i++;
        Array.Sort(books, 0, i);
    }
}
class Article : Edition
{ 
    public static string [] article = new string[100];
    public static int i = 0; 

    int year;
    string journal;
    public Article(string title, string author, int year, string journal) : base(title, author)
    {
        this.year = year; 
        this.journal = journal;
        CompareTo();
    }
    public override void CompareTo()
    {
        article[i] += title + " " + author + " " + year.ToString() + " " + journal;
        i++;
        Array.Sort(article, 0, i);
    }
}
class OnlineResoure : Edition
{   
    public static string [] onlineresoure = new string[100];
    public static int i = 0; 

    string link;
    string abs;
    public OnlineResoure(string title, string author, string link, string abs) : base(title, author)
    {
        this.link = link;
        this.abs = abs;
        CompareTo();
    }
    public override void CompareTo()
    {
        onlineresoure[i] += title + " " + author + " " + link + " " + abs;
        i++;
        Array.Sort(onlineresoure, 0, i);
    }
}
class programm 
{
    public static void Main(string[] args)
    {
        Edition b1 = new Book("Sun", "banh", 1990, "kim dong"); 
        Edition b2 = new Book("Moon", "anh", 1991, "tu do"); 
        Edition b3 = new Book("Black", "danh", 1992, "truong doi"); 
        Edition b4 = new Book("Red", "manh", 1993, "truong hoc"); 
        Edition b5 = new Book("Gold", "nanh", 1994, "giao duc"); 
        Edition b6 = new OnlineResoure("Fun1", "to huu", "example.com", "quang nam"); 
        Edition b7 = new OnlineResoure("Dun2", "dieu lam", "example.com", "quang nam"); 
        Edition b8 = new OnlineResoure("Aun3", "cong nghia", "example.com", "quang nam"); 
        Edition b9 = new Article("Sun", "bao ngoc", 1258, "ha noi"); 
        Edition b10 = new Article("Bun", "khoa", 1992, "da nang"); 
        Edition b11 = new Book("Hun", "banh", 1992, "kim dong"); 
        Edition b12 = new OnlineResoure("Asun3", "banh", "example.com", "tphcm"); 
        Edition b13 = new Article("Saun", "banh", 1258, "lang son"); 
        while (true)
        {   
            Console.WriteLine("bạn muốn tìm danh mục nào\n0: Thoát\n1: Book\n2: Article\n3: OnlineResoure");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {    
                Console.WriteLine("--------------");
                Console.WriteLine("Danh mục Book");
                Console.WriteLine("--------------");
                for (int j = 0; j < Book.i; j++)
                {
                    Console.WriteLine(Book.books[j]);
                }
            }
            else if (n == 2)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Danh mục Article");
                Console.WriteLine("-----------------");
                for (int j = 0; j < Article.i; j++)
                {
                    Console.WriteLine(Article.article[j]);
                }
            }
            else if (n == 3)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Danh mục OnlineResoure");
                Console.WriteLine("-----------------------");
                for (int j = 0; j < OnlineResoure.i; j++)
                {
                    Console.WriteLine(OnlineResoure.onlineresoure[j]);
                }
            }
            else {break;}
        }
        while (true)
        {    
            Console.Write("Tên tác giả của ấn phẩm cần tìm: ");
            string author = Console.ReadLine();
            if (author == "")
            {
                break;
            }
            else   
            {    
                Console.WriteLine("--------------");
                Console.WriteLine("Danh mục Book");
                Console.WriteLine("--------------");
                for (int j = 0; j < Book.i; j++)
                {
                    string [] part = Book.books[j].Split();
                    if (part[1] == author)
                    {
                        Console.WriteLine(Book.books[j]);
                    }
                }
                Console.WriteLine("-----------------");
                Console.WriteLine("Danh mục Article");
                Console.WriteLine("-----------------");
                for (int j = 0; j < Article.i; j++)
                {
                    string [] part = Article.article[j].Split();
                    if (part[1] == author)
                    {
                        Console.WriteLine(Article.article[j]);
                    }
                }
                Console.WriteLine("-----------------------");
                Console.WriteLine("Danh mục OnlineResoure");
                Console.WriteLine("-----------------------");
                for (int j = 0; j < OnlineResoure.i; j++)
                {
                    string [] part = OnlineResoure.onlineresoure[j].Split();
                    if (part[1] == author)
                    {
                        Console.WriteLine(OnlineResoure.onlineresoure[j]);
                    }
                }
            }
        }
    }
}