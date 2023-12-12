abstract class Edition
{
    public string title;
    public string author;
    public Edition (string title, string author)
    {
        this.title = title;
        this.author = author;
    }
    abstract public void CompareTo();
}
class Book : Edition
{   
    public static List<Book> BookList = new List<Book>();
    public int year;
    public string publisher;
    public Book(string title, string author, int year, string publisher) : base(title, author)
    {
        this.year = year; 
        this.publisher = publisher;
        CompareTo();
    }
    public override void CompareTo()
    {
        BookList.Add(this);
        BookList.Sort((s1,s2) => s1.author.CompareTo(s2.author));
    }
}
class Article : Edition
{ 
    public static List<Article> ArticleList = new List<Article>();
    public int year;
    public string journal;
    public Article(string title, string author, int year, string journal) : base(title, author)
    {
        this.year = year; 
        this.journal = journal;
        CompareTo();
    }
    public override void CompareTo()
    {
        ArticleList.Add(this);
        ArticleList.Sort((s1,s2) => s1.author.CompareTo(s2.author));
    }
}
class OnlineResoure : Edition
{   
    public static List<OnlineResoure> OnlineResoureList = new List<OnlineResoure>();
    public string link;
    public string abs;
    public OnlineResoure(string title, string author, string link, string abs) : base(title, author)
    {
        this.link = link;
        this.abs = abs;
        CompareTo();
    } 
    public override void CompareTo()
    {
        OnlineResoureList.Add(this);
        OnlineResoureList.Sort((s1,s2) => s1.author.CompareTo(s2.author));
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
            Console.WriteLine("-----Book-----");
            foreach (var s in Book.BookList)
            {
                Console.WriteLine($"{s.title} {s.author} {s.year} {s.publisher}");
            }
            Console.WriteLine("-----Article-----");
            foreach (var s in Article.ArticleList)
            {
                Console.WriteLine($"{s.title} {s.author} {s.year} {s.journal}");
            }
            Console.WriteLine("-----OnlineResoure-----");
            foreach (var s in OnlineResoure.OnlineResoureList)
            {
                Console.WriteLine($"{s.title} {s.author} {s.link} {s.abs}");
            }
            Console.Write("Tên tác giả ấn phẩm cần tìm: ");
            string author = Console.ReadLine();
            foreach (var s in Book.BookList)
            {
                if (s.author == author)
                {
                    Console.WriteLine($"{s.title} {s.author} {s.year} {s.publisher}");
                }
            }
            foreach (var s in Article.ArticleList)
            {
                if (s.author == author)
                {
                    Console.WriteLine($"{s.title} {s.author} {s.year} {s.journal}");
                }
            }
            foreach (var s in OnlineResoure.OnlineResoureList)
            {
                if (s.author == author)
                {
                    Console.WriteLine($"{s.title} {s.author} {s.link} {s.abs}");
                }
            }
    }
}