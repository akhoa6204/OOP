using System.Text.RegularExpressions;

class Phanso
{
    public int tuso,mauso;
    public Phanso()
    {
        Console.Write("tuso: ");
        tuso = int.Parse(Console.ReadLine());
        Console.Write("mauso: ");
        mauso = int.Parse(Console.ReadLine());
    }
    public static string Cong( int a, int b, int c, int d)
    {
        if (b==d)
        {return (a+c)+"/"+d;}
        else 
        {return a*(BCNN(b,d)/b)+c*(BCNN(b,d)/d)+"/"+BCNN(b,d);}
    }
    public static string Tru( int a, int b, int c, int d)
    {
        if (b==d)
        {return (a-c)+"/"+d;}
        else 
        {return a*(BCNN(b,d)/b)-c*(BCNN(b,d)/d)+"/"+BCNN(b,d);}
    }
    public static string Nhan( int a,  int b, int c, int d)
    {
        
        return (a*c)/UCLN(a*c,b*d)+"/"+(b*d)/UCLN(a*c,b*d);
    }
    public static string Chia( int a,  int b, int c, int d)
    {
        return (a*d)/UCLN(a*d,b*c)+"/"+(b*c)/UCLN(a*d,b*c);
    }
    static int UCLN(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    static int BCNN(int a, int b)
    {
        return (a * b) / UCLN(a, b);
    }
    public static void Xuat(int a, int b, int c, int d)
    {
        Console.WriteLine("Cong: "+Phanso.Cong(a,b,c,d));
        Console.WriteLine("Tru: "+Phanso.Tru(a,b,c,d));
        Console.WriteLine("Nhan: "+Phanso.Nhan(a,b,c,d));
        Console.WriteLine("Chia: "+Phanso.Chia(a,b,c,d));}
}
class Program
{
    static void Main(string[] args)
    {
        Phanso a = new Phanso();
        Phanso b= new Phanso();
        Phanso.Xuat(a.tuso,a.mauso,b.tuso,b.mauso);
    }
}