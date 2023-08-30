// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

namespace b1vd3ab {
    class program  {
        static void Main(string[] args) 
        {
            int a ,b,kq=0 ;
            Console.Write("Nhap a: ");
            a=int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b=int.Parse(Console.ReadLine());
            TBP(a,b);
            TBP(a,b,kq);
        }
        static void TBP(int a,int b )
        {
            Console.WriteLine("Tong binh phuong {0} va {1} la: {2}",a,b,a*a+b*b);
        }
        static void TBP(int a,int b, int kq)
        {   
            kq= a*a+b*b;
            Console.WriteLine("Tong binh phuong {0} va {1} la: {2}",a,b,kq);
        }
        
    }
}
