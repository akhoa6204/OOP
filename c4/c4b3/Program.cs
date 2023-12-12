class Tamgiac
{
    public float a,b,c ;
    public Tamgiac()
    {
        Console.Write("Nhap a: ");
        a=float.Parse(Console.ReadLine());
        Console.Write("Nhap b: ");
        b=float.Parse(Console.ReadLine());
        Console.Write("Nhap c: ");
        c=float.Parse(Console.ReadLine());
    }
    public static string Kiemtra(float a, float b, float c)
    {
        if (a>0 & b>0 & c>0)
        {   
            if (a+b>c||a+c>b||b+c>a)    
            {
                if (a==b & b==c & a==c)
                {return "Tam giac deu";}
                else if ((a==b & b!=c) || (b==c & a!=b) || (a==c & b!=c))
                {
                    if (a*a+b*b==c*c || a*a+c*c==b*b || b*b+c*c==a*a)
                    {return "Tam giac vuong can";}
                    else {return "Tam giac can";} 
                }
                else if (a*a+b*b==c*c || a*a+c*c==b*b || b*b+c*c==a*a)
                {return "Tam giac vuong";}
                else 
                {return "Tam giac thuong";}
            }
            else {return "Khong phai la tam giac";}
        }
        else {return "Khong phai la tam giac"; }
    }
    public static void Xuat(float a, float b, float c)
    {
        Console.WriteLine(Kiemtra(a,b,c));
    }
}
class Program 
{
    static void Main(string[] args)
    {
        Tamgiac tg1 = new Tamgiac();
        Tamgiac tg2 = new Tamgiac();
        Tamgiac.Xuat(tg1.a, tg1.b, tg1.c);
        Tamgiac.Xuat(tg2.a, tg2.b, tg1.c);
    }
}
