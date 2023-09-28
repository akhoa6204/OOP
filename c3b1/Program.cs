class Sach 
{
    string Tensach, Tacgia;
    int NamXB, Soluong;
    // 3 kiểu hàm khởi tạo  
    // số 1 
    // public Sach(string tensach="" , string tacgia ="" , int namxb=0, int soluong=0)
    // {
    //     Tensach=tensach;
    //     Tacgia=tacgia; 
    //     NamXB=namxb;
    //     Soluong=soluong;
    // }
    // số 2
    public Sach(string tensach,string tacgia,int namxb,int soluong)
    {
        Tensach=tensach;
        Tacgia=tacgia;
        NamXB=namxb; 
        Soluong=soluong;
    }
    // số 3 
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
        Console.Write("Ten sach: {0} Tac gia: {1} NamXB: {2} Soluong: {3}",Tensach,Tacgia,NamXB,Soluong);
    }
    ~Sach()
    {}
}
class programm 
{
    static void Main(string[] args)
    {
        // dùng kiểu số 1
        // Sach book = new Sach();
        // dùng kiểu số 2 
        Sach book = new Sach("","",0,0);
        // dùng kiểu số 3
        // Sach book = new Sach();
        book.Nhap();
        book.Xuat();
    }
}