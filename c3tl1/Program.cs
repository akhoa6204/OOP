class NhaphocTKTH
{
    string hoten,ngsinh,gioitinh, chuyennganh;
    public static int [] hs =new int [3]; 
    public static int [] hsn =new int [3];
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
        {hs[0]+=1;}
        else if (chuyennganh=="THQL")
        {hs[1]+=1;}
        else if (chuyennganh=="QUANTRIHTTT")
        {hs[2]+=1;}  
        Console.WriteLine($"hoten: {hoten}, ngsinh: {ngsinh}, gioinh: {gioitinh}, chuyennganh: {chuyennganh}");
    }
    public void Thongke()
    {   
        if (chuyennganh=="THONGKE")
        {
            if (gioitinh=="NAM")
                {hsn[0]+=1;}
        }
        else if (chuyennganh=="THQL")
        {
            if (gioitinh=="NAM")
                {hsn[1]+=1;}
        }
        else if (chuyennganh=="QUANTRIHTTT")
        {
            if (gioitinh=="NAM")
                {hsn[2]+=1;}
        }
    }               
    ~NhaphocTKTH()
    {}
}
class programm
{
    static void Main(string [] args)
    {
        NhaphocTKTH hs = new NhaphocTKTH();
        NhaphocTKTH hs1 = new NhaphocTKTH();
        NhaphocTKTH hs2 = new NhaphocTKTH ();
        hs.LocSV();
        hs1.LocSV();
        hs2.LocSV();
        Console.WriteLine($"Thong ke: {NhaphocTKTH.hs[0]}");
        Console.WriteLine($"Nam: {NhaphocTKTH.hsn[0]}\nNu: {NhaphocTKTH.hs[0]-NhaphocTKTH.hsn[0]}");
        Console.WriteLine($"THQl: {NhaphocTKTH.hs[1]}");
        Console.WriteLine($"Nam: {NhaphocTKTH.hsn[1]}\nNu: {NhaphocTKTH.hs[1]-NhaphocTKTH.hsn[1]}");
        Console.WriteLine($"QuantriHTTT: {NhaphocTKTH.hs[2]}");
        Console.WriteLine($"Nam: {NhaphocTKTH.hsn[2]}\nNu: {NhaphocTKTH.hs[2]-NhaphocTKTH.hsn[2]}");
    }
}