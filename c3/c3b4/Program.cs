using System;
class Triangle
{
    int a,b,c;
    public Triangle(int A=0, int B=0,int C=0)
    {
        a = A;
        b = B;
        c = C;
    }
    public void Nhap()
    {
        Console.Write("a= ");
        a=int.Parse(Console.ReadLine());
        Console.Write("b= ");
        b=int.Parse(Console.ReadLine());
        Console.Write("c= ");
        c=int.Parse(Console.ReadLine());
    }
    public bool Kiemtra()
    {
        if (a>0 &b>0 &c>0)
        {
            if (a+b>c && a+c>b && b+c>a)
                {return true;}
        }
        return false;
    }
    public int chuvi()
    {
        return a+b+c;
    }
    public float dientich()
    {   
        float s=(a+b+c)/2;
        return (float)Math.Sqrt(s*(s-a)*(s-b)*(s-c));
    }
    public void Xuat()
    {
        Console.WriteLine($"a= {a} b= {b} c= {c}");
    }
    ~Triangle()
    {}
}
class programm
{
    static void Main(string[] args)
    {
        Triangle tg = new Triangle();
        int bam;
        while (true)
        {
            Console.Write("Bam(0-3): ");
            bam=int.Parse(Console.ReadLine());
            if (bam==1)
            {
                tg.Nhap();
                if (!tg.Kiemtra())
                {
                    Console.WriteLine("Khong hop le");
                    break;
                }
                continue;
            }
            else if (bam==2)
            {
                Console.WriteLine($"Chu vi {tg.chuvi()}\nDien tich {tg.dientich()}");
                continue;
            }
            else if (bam==3)
            {
                tg.Xuat();continue;
            }
            else if (bam==0)
            {break;}
        }
    }
}