namespace sodongian
{
    class programm
    {
        static void Main(string[] args)
        {
            int n,tinhtong=0,kq=0;
            n=int.Parse(Console.ReadLine());
            while (n>0)
            {
                tinhtong += n%10;
                n=n/10;
            }
            while (tinhtong>0)
            {   
                kq+=tinhtong%10;
                tinhtong =tinhtong/10;
            }
            Console.WriteLine(kq);
        }
    }
}
