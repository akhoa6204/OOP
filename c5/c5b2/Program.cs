class People 
{
    protected string Hoten, Tuoi, Diachi;
    protected long ID; 
    public People(long ID = 0,string Hoten = "",string Tuoi = "",string Diachi = "")
    {
        this.ID = ID;
        this.Hoten = Hoten;
        this.Tuoi = Tuoi;
        this.Diachi = Diachi;
    }
    public void Nhap()
    {
        Console.Write("ID: ");
        ID = long.Parse(Console.ReadLine());
        Console.Write("Hoten: ");
        Hoten = Console.ReadLine();
        Console.Write("Tuoi: ");
        Tuoi = Console.ReadLine();
        Console.Write("Diachi: ");
        Diachi = Console.ReadLine();
    }
    public void Xuat()
    {
        Console.WriteLine($"ID: {ID}, Hoten: {Hoten}, Tuoi: {Tuoi}, Diachi: {Diachi}");
    }
}
class Students : People 
{
    float TP1, TP2, TP3;
    string term;
    public Students(long ID = 0,string Hoten = "",string Tuoi = "",string Diachi = "",float TP1 = 0,float TP2 = 0,float TP3 = 0,string term = ""):base(ID,Hoten,Tuoi,Diachi)
    {
        this.TP1 = TP1;
        this.TP2 = TP2;
        this.TP3 = TP3;
        this.term = term;
    }
    public new void Nhap()
    {
        base.Nhap();
        Console.Write("Tên học phần: ");
        term = Console.ReadLine();
        Console.Write("TP1: ");
        TP1 = float.Parse(Console.ReadLine());
        Console.Write("TP2: ");
        TP2 = float.Parse(Console.ReadLine());
        Console.Write("TP3: ");
        TP3 = float.Parse(Console.ReadLine());
    }
    public void GPA()
    {
        float gpa = (TP1 + TP2 + TP3) / 3;
        if (gpa >= 8.5)
        {   Console.WriteLine($"GPA: {gpa}, Xep loai Gioi");}
        else if (gpa >= 7)
        {   Console.WriteLine($"GPA: {gpa}, Xep loai Kha");}
        else if (gpa >= 5.5)
        {   Console.WriteLine($"GPA: {gpa}, Xep loai Trung binh"); }
        else if (gpa >= 4)
        {   Console.WriteLine($"GPA: {gpa}, Xep loai Yeu");}
        else
        {   Console.WriteLine($"GPA: {gpa}, Xep loai Kem");}
    }
    public new void Xuat()
    {
        base.Xuat();
        GPA();
    }
}
class Lecture : People 
{
    int Kinhnghiem;
    string Hocvi,Chucvu;
    public Lecture(long ID = 0,string Hoten = "",string Tuoi = "",string Diachi = "",int Kinhnghiem = 0 , string Hocvi = "", string Chucvu = ""):base(ID,Hoten,Tuoi,Diachi)
    {
        this.Kinhnghiem = Kinhnghiem;
        this.Hocvi = Hocvi;
        this.Chucvu = Chucvu;
    }
    public static int size = 0;
    public static string [] ds = new string[size];
    public new void Nhap()
    {
        base.Nhap();
        Console.Write("Kinh nghiệm: ");
        Kinhnghiem=int.Parse(Console.ReadLine());
        Console.Write("Học vị: ");
        Hocvi=Console.ReadLine();
        Console.Write("Chức vụ: ");
        Chucvu=Console.ReadLine();
        Array.Resize(ref ds, size +1);
        ds[size]=ID.ToString() + " " + Hoten + " " + Tuoi + " " + Diachi + " " + Kinhnghiem.ToString() + " " + Hocvi + " " + Chucvu;
        size++ ;

    }
    public static void Sapxep(string [] ds)
    {
        string [,] kq = new string [size, 7];
        for(int i = 0; i < size; i++) 
        {       
            string [] A = ds[i].Split();
            for(int j = 0; j < 7 ; j++ )
            {
                kq[i,j] = A[j];
            }
        }
        for ( int i = 0; i < size-1; i++)
        {
            for (int j = 0; j < size - i - 1; j++ )
            {
                if (int.Parse(kq[j, 4]) < int.Parse(kq[j + 1, 4]))
                {
                   for (int k = 0; k < 7; k++)
                    {
                        string temp = kq[j, k];
                        kq[j, k] = kq[j + 1, k];
                        kq[j + 1, k] = temp;
                    } 
                }
            }
        }
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < 7; j++ )
            {
                Console.Write(kq[i, j]+" ");
            }
            Console.WriteLine();
        }
    }
}
class Program 
{
    public static void Main(string[] args)
    {
        Students sv = new Students();
        sv.Nhap();
        sv.Xuat();
        Lecture gv = new Lecture();
        gv.Nhap();
        Lecture gv1 = new Lecture();
        gv1.Nhap();
        Lecture gv2= new Lecture();
        gv2.Nhap();
        Lecture gv3 = new Lecture();
        gv3.Nhap();    
        Lecture.Sapxep(Lecture.ds);
    }
}
