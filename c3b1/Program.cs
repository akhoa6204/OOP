class Sach 
{
    string Tensach, Tacgia;
    int NamXB, Soluong;
    public Sach(string tensach="" , string tacgia ="" , int namxb=0, int soluong=0)
    {
        Tensach=tensach;
        Tacgia=tacgia; 
        NamXB=namxb;
        Soluong=soluong;
    }
    // public Sach ()
    // {}
    public void Nhap()
    { 
        Console.Write("Tensach: ");
        Tensach = Console.ReadLine();
        Console.Write("Tacgia: ");
        Tacgia = Console.ReadLine();
        Console.Write("NamXB: ");
        NamXB = int.Parse(Console.ReadLine());
        Console.Write("Soluong: ");
        Soluong = int.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.Write("Ten sach: {0}\nTac gia: {1}\nNamXB: {2}\nSoluong: {3}",Tensach,Tacgia,NamXB,Soluong);
    }
    ~Sach()
    {
        Console.WriteLine("Doi tuong Sach da huy");
    }
}
class programm 
{
    static void Main(string[] args)
    {
        Sach book = new Sach();
        book.Nhap();
        book.Xuat();
    }
}