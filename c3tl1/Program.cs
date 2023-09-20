class NhaphocTKTH
{
    string hoten, ngsinh,gioitinh, chuyennganh;
    int [] dscn =new int[3];
    int [] dsgt =new int[3];
    public NhaphocTKTH()
    {}
    public void Nhap()
    {
        Console.Write("Hoten: ");
        hoten = Console.ReadLine();
        Console.Write("Ngaysinh: ");
        ngsinh = Console.ReadLine();
        Console.Write("Gioitinh(Nam,Nu): ");
        gioitinh= Console.ReadLine();
        Console.Write("Chuyennganh(Thongke, THQL, QuantriHTTT): ");
        chuyennganh= Console.ReadLine();
    }
    public void LocSV()
    {   
        if (chuyennganh=="Thongke")
        {dscn[0]+=1;}
        else if (chuyennganh=="THQL")
        {dscn[1]+=1;}
        else 
        {dscn[2]+=1;}  
    }
    public void ThongKe()
    {    
        if (chuyennganh=="Thongke")
        {
            if (gioitinh=="Nam")
                {dsgt[0]+=1;}
        }
        else if (chuyennganh=="THQL")
        {
            if (gioitinh=="Nam")
                {dsgt[1]+=1;}
        }
        else
        {
            if (gioitinh=="Nam")
                {dsgt[2]+=1;}
        }
    }
    
    public void Xuat()
    {
        if (dscn[0]>0)
            {
                Console.WriteLine($"Thong ke: {dscn[0]}");
                Console.WriteLine($"Nam: {dsgt[0]}\nNu: {dscn[0]-dsgt[0]}");
            }
        if (dscn[1]>0)    
            {
                Console.WriteLine($"THQL: {dscn[1]}"); 
                Console.WriteLine($"Nam: {dsgt[1]}\nNu: {dscn[1]-dsgt[1]}");
            } 
        if (dscn[2]>0)
            {
                Console.WriteLine($"QuantriHTTT: {dscn[2]}");
                Console.WriteLine($"Nam: {dsgt[2]}\nNu: {dscn[2]-dsgt[2]}"); 
            }
    }
}
class programm
{
    static void Main(string [] args)
    {
        string tieptuc ;
        NhaphocTKTH hs = new NhaphocTKTH();
        while (true)
        {
            hs.Nhap();
            Console.WriteLine("tieptuc: ");
            tieptuc=Console.ReadLine();
            hs.LocSV();
            hs.ThongKe(); 
            if (tieptuc != "t" && tieptuc!="T" )
            {break;}
        }  
        hs.Xuat();
    }
}