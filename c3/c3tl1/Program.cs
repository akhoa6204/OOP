using System.Runtime.InteropServices;
using System.Security;

class NhaphocTKTH
{
    string hoten, ngsinh, gioitinh, chuyennganh;
    public static int [,] hocsinh = new int [3, 3]; 
    public static string [] chitiet = new string [10];
    static int size = 0 ;
    public NhaphocTKTH(string hoten, string ngsinh, string gioitinh, string chuyennganh)
    {
        
        this.hoten = hoten;
        this.ngsinh = ngsinh;
        this.gioitinh = gioitinh;
        this.chuyennganh = chuyennganh; 
        LocSV();
        Thongke();
        chitiet[size] += hoten + " " + ngsinh + " " + gioitinh + " " + chuyennganh;
        size++;
    }
    public void LocSV()
    {   
        if (chuyennganh.ToUpper() == "THONGKE")
        {hocsinh[0,0]+=1;}
        else if (chuyennganh.ToUpper() == "THQL")
        {hocsinh[0,1]+=1;}
        else if (chuyennganh.ToUpper() == "QUANTRIHTTT")
        {hocsinh[0,2]+=1;}  
    }
    public void Thongke()
    {   
        if (chuyennganh.ToUpper() == "THONGKE")
        {
            if (gioitinh.ToUpper() == "NAM")
                {hocsinh[1, 0] += 1;}
            else if (gioitinh.ToUpper() == "NU")
                {hocsinh[2, 0] += 1;}
        }
        else if (chuyennganh.ToUpper() == "THQL")
        {
            if (gioitinh.ToUpper() == "NAM")
                {hocsinh[1, 1] += 1;}
            else if (gioitinh.ToUpper() == "NU")
                {hocsinh[2, 1] += 1;}
        }
        else if (chuyennganh.ToUpper() == "QUANTRIHTTT")
        {
            if (gioitinh.ToUpper() == "NAM")
                {hocsinh[1, 2] += 1;}
            else if (gioitinh.ToUpper() == "NU")
                {hocsinh[2, 2] += 1;}
        }
    }              
    public static void Xuat()
    {
        Console.WriteLine($"Thong ke: {hocsinh[0, 0]}");
        Console.WriteLine($"THQl: {hocsinh[0, 1]}");
        Console.WriteLine($"QuantriHTTT: {hocsinh[0, 2]}");
    } 
    ~NhaphocTKTH()
    {}
}
class Programm
{
    static void Main(string [] args)
    {
        NhaphocTKTH hs  = new NhaphocTKTH  ("khoa","662004","nam","thongke");
        NhaphocTKTH hs1 = new NhaphocTKTH ("akhoa","662004","nam","thongke");
        NhaphocTKTH hs2 = new NhaphocTKTH ("khoaaa","662004","nu","THQL");
        NhaphocTKTH hs3 = new NhaphocTKTH ("Akhoaaa","662004","nu","quantrihttt");
        NhaphocTKTH hs4 = new NhaphocTKTH ("AAkhoaaa","662004","nu","THQL");
        NhaphocTKTH hs5 = new NhaphocTKTH ("kay","662004","nam","quantrihttt");
        NhaphocTKTH hs6 = new NhaphocTKTH ("kayy","662004","nam","THQL");
        NhaphocTKTH hs7 = new NhaphocTKTH ("kayyy","662004","nu","thongke");
        NhaphocTKTH hs8 = new NhaphocTKTH ("akay","662004","nam","quantrihttt");
        NhaphocTKTH hs9 = new NhaphocTKTH ("akayyy","662004","nam","THQL");
        NhaphocTKTH.Xuat();
        while (true)
        {    
            string cn = Console.ReadLine().ToUpper();  
            if (cn == "THONGKE")
            {
                Console.WriteLine($"Nam: {NhaphocTKTH.hocsinh[1, 0]}, Nu: {NhaphocTKTH.hocsinh[2, 0]}");
                for (int i = 0; i < NhaphocTKTH.chitiet.Length; i++)  
                {   string [] part = NhaphocTKTH.chitiet[i].Split();
                    if (part[3].ToUpper() == cn)
                    {
                        Console.WriteLine(part[0] + " " + part[1]+ " " + part[2]);
                    }
                }
            }
            else if (cn == "THQL")
            {
                Console.WriteLine($"Nam: {NhaphocTKTH.hocsinh[1, 1]}, Nu: {NhaphocTKTH.hocsinh[2, 1]}");
                for (int i = 0; i < NhaphocTKTH.chitiet.Length; i++)  
                {   string [] part = NhaphocTKTH.chitiet[i].Split();
                    if (part[3].ToUpper() == cn)
                    {
                        Console.WriteLine(part[0] + " " + part[1]+ " " + part[2]);
                    }
                }
            }
            else if (cn == "QUANTRIHTTT")
            {
                Console.WriteLine($"Nam: {NhaphocTKTH.hocsinh[1, 2]}, Nu: {NhaphocTKTH.hocsinh[2, 2]}");
                for (int i = 0; i < NhaphocTKTH.chitiet.Length; i++)  
                {   string [] part = NhaphocTKTH.chitiet[i].Split();
                    if (part[3].ToUpper() == cn)
                    {
                        Console.WriteLine(part[0] + " " + part[1]+ " " + part[2]);
                    }
                }
            }
            else {break;}
            
        }
    }
}
