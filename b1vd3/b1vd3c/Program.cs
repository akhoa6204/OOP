// See https://aka.ms/new-console-template for more information
namespace b1vvd3c 
{
    class programm 
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.Write("Nhap a: ");
            a=int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b=int.Parse(Console.ReadLine());
            int kq=TBP(a,b);
            Console.Write("Tong binh phuong {0} va {1} la {2}",a,b,kq);
        }
        static int TBP( int a,int b )
        {
            int kq=a*a+b*b;
            return kq ; 
        }
    }
}
