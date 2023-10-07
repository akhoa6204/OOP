class NhaphocTKTH
{
    string hoten,ngsinh,gioitinh, chuyennganh;
    public static int [,] hocsinh =new int [3,3]; 
    public NhaphocTKTH()
    {
        Console.Write("Hoten: ");
        hoten = Console.ReadLine().ToUpper();
        Console.Write("Ngaysinh (dd/mm/yy): ");
        ngsinh = Console.ReadLine();
        Console.Write("Gioitinh(NAM,NU): ");
        gioitinh= Console.ReadLine().ToUpper();
        Console.Write("Chuyennganh(Thongke, THQL, QuantriHTTT): ");
        chuyennganh= Console.ReadLine().ToUpper();
    }
    public void LocSV()
    {   
        if (chuyennganh=="THONGKE")
        {hocsinh[0,0]+=1;}
        else if (chuyennganh=="THQL")
        {hocsinh[0,1]+=1;}
        else if (chuyennganh=="QUANTRIHTTT")
        {hocsinh[0,2]+=1;}  
        Console.WriteLine($"hoten: {hoten}, ngsinh: {ngsinh}, gioinh: {gioitinh}, chuyennganh: {chuyennganh}");
    }
    public void  Thongke()
    {   
        if (chuyennganh=="THONGKE")
        {
            if (gioitinh=="NAM")
                {hocsinh[1,0]+=1;}
            else if (gioitinh=="NU")
                {hocsinh[2,0]+=1;}
        }
        else if (chuyennganh=="THQL")
        {
            if (gioitinh=="NAM")
                {hocsinh[1,1]+=1;}
            else if (gioitinh=="NU")
                {hocsinh[2,1]+=1;}
        }
        else if (chuyennganh=="QUANTRIHTTT")
        {
            if (gioitinh=="NAM")
                {hocsinh[1,2]+=1;}
            else if (gioitinh=="NU")
                {hocsinh[2,2]+=1;}
        }
    }               
    ~NhaphocTKTH()
    {}
}
class Programm
{
    static void Main(string [] args)
    {
        NhaphocTKTH hs = new NhaphocTKTH();
        NhaphocTKTH hs1 = new NhaphocTKTH();
        NhaphocTKTH hs2 = new NhaphocTKTH ();
        hs.LocSV();
        hs1.LocSV();
        hs2.LocSV();
        hs.Thongke();
        hs1.Thongke();
        hs2.Thongke();
        Console.WriteLine($"Thong ke: {NhaphocTKTH.hocsinh[0,0]}");
        Console.WriteLine($"Nam: {NhaphocTKTH.hocsinh[1,0]}\nNu: {NhaphocTKTH.hocsinh[2,0]}");
        Console.WriteLine($"THQl: {NhaphocTKTH.hocsinh[0,1]}");
        Console.WriteLine($"Nam: {NhaphocTKTH.hocsinh[1,1]}\nNu: {NhaphocTKTH.hocsinh[2,1]}");
        Console.WriteLine($"QuantriHTTT: {NhaphocTKTH.hocsinh[0,2]}");
        Console.WriteLine($"Nam: {NhaphocTKTH.hocsinh[1,2]}\nNu: {NhaphocTKTH.hocsinh[2,2]}");
    }
}