// See https://aka.ms/new-console-template for more information
namespace c1b2
{
    class programm 
    {
        static void Main(string[] args)
        {   
            float a,b;
            string toantu,tieptuc;
            
            while (true)
            {
                Nhap(out a, out b, out toantu);
                float kq= Thuchien(a,ref b , ref toantu);
                InKQ(ref toantu,b,kq );
                Console.Write("Tiep tuc: ");         
                tieptuc=Console.ReadLine();
                if (tieptuc=="T" || tieptuc=="t")
                {break;}
            }
        }   
        static void Nhap(out float a ,out float b,out string toantu)
        {
            Console.Write("a= ");a=float.Parse(Console.ReadLine());
            Console.Write("b= ");b=float.Parse(Console.ReadLine());
            Console.Write("Toan tu: ");toantu=Console.ReadLine();
        }
        static float Thuchien( float a, ref float b, ref string toantu)
        {
            float kq=0;
            if (toantu=="+")
            {kq=a+b;}
            else if (toantu=="-")
            {kq=a-b;}
            else if (toantu=="*")
            {kq=a*b;}
            else if (toantu=="/" & b!=0)
            {kq=a/b;}
            return kq;
        }
        static void InKQ(ref string toantu,float b ,float kq)
        {
            if(toantu=="+")
            {Console.WriteLine("a+b= "+kq);}
            else if (toantu=="-")
            {Console.WriteLine("a-b= "+kq);}
            else if (toantu=="*")
            {Console.WriteLine("a*b= "+kq);}
            else if ((toantu=="/") & (b!=0))
            {Console.WriteLine("a/b= "+kq);}
            else if ((toantu=="/") & (b==0)) 
            {Console.WriteLine("Loi phep tinh");}
        }
    }
}
