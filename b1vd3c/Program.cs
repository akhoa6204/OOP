namespace b1vd3c {
    class program  {
        static void Main(string[] args) 
        {
            int a ,b;
            Console.Write("Nhap a: ");
            a=int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b=int.Parse(Console.ReadLine());
            int kq=TBP(a,b);
            Console.WriteLine("Tong binh phuong {0} va {1} la: {2}",a,b,kq);
        }
        static int TBP(int a,int b)
        {
            int kq =a*a+b*b;
            return kq ;
        }
    }
}