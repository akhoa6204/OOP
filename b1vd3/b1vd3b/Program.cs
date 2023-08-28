// See https://aka.ms/new-console-template for more information
namespace b1vd3b 
{
    class programm
    {
        static void Main(string[] args)
        {
            int a,b,kq=0;
            Console.Write("Nhap so a: "); 
            a=int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: "); 
            b=int.Parse(Console.ReadLine());
            TBP(a,b,kq);
        }
         static void TBP(int a ,int b , int kq)
        {
            kq=a*a+b*b;
            Console.WriteLine("Tong binh phuong {0} va {1} la: {2}",a,b,kq);
        }
    }
}
