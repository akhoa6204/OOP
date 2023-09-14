// Viết 1 chương trình tính chu vi và diện tích hình chữ nhật
// b1 : khai báo lớp  hình chữ nhật 
// b2 : khai báo thuộc tính: dài rộng
// b3 : khai báo phương thức: Nhap(), Xuat(), chuvi(), dientich()
// b4 : tạo lớp programm để thực hiện chương trình 
using System ;
// class Hinhchunhat 
// {
//     public float Dai;
//     public float Rong;
//     public void Nhap()
//     {
//         Console.Write("Nhap CDai:");
//         Dai=float.Parse(Console.ReadLine());
//         Console.Write("Nhap CRong:");
//         Rong=float.Parse(Console.ReadLine());
//     }
//     public void Xuat()
//     {
//         Console.WriteLine("Hinh chu nhat: CDai = {0}, CRong = {1}",Dai,Rong);
//     }
//     public float Chuvi()
//     {
//         return (Dai+Rong)*2;
//     }
//     public float Dientich()
//     {
//         return Dai*Rong;
//     }
// }
// class programm
// {
//     static void Main(string[] args)
//     {
//     Hinhchunhat h = new Hinhchunhat();
//     h.Nhap();
//     h.Xuat();
//     Console.WriteLine("Chu vi HCN = "+h.Chuvi());
//     Console.WriteLine("DIen tich HCN = "+h.Dientich());
//     }
// }
// public class Time
// {
//     private int Ngay;
//     int Thang;
//     int Nam;
//     int Gio;
//     int Phut;
//     int Giay;
//     public void Hienthithoigian()
//     {
//         Console.WriteLine("Now {0}/{1}/{2} {3}:{4}:{5}", Ngay, Thang, Nam, Gio, Phut,Giay);
//     }
//     public Time (System.DateTime DT)
//     {
//         Ngay = DT.Day;
//         Thang=DT.Month;
//         Nam=DT.Year;
//         Gio=DT.Hour;
//         Phut=DT.Minute;
//         Giay=DT.Second;
//     }
// }
// class Tinhthoigian
// {
//     static void Main ()
//     {
//         System.DateTime Thoigianthuc = System.DateTime.Now;
//         // Tạo đối tượng
//         Time t = new Time (Thoigianthuc);
//         t.Hienthithoigian();
//     }
// }
class HocSinh 
{
    public float Weight ;
    public float Height ;
    public void Info() 
    {
        Console.WriteLine("Hoc sinh co chieu cao {0} va can nang la {1}",Weight,Height);
    }
    public HocSinh()
    {
        Weight = 49;
        Height= 150;
    }
    public HocSinh(float w,float h)
    {
        Weight = w;
        Height = h;
    }
}
class SodoHocSinh
{
    static void Main ()
    {
        HocSinh hs1=new HocSinh();
        hs1.Info();
        HocSinh hs2=new HocSinh(50,135);
        hs2.Info();
    }
}