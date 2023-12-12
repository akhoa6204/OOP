class SoPhuc 
{
    public double phanthuc,phanao;
    public SoPhuc()
    {
        Console.Write("phanthuc: ");
        phanthuc=double.Parse(Console.ReadLine());
        Console.Write("phanao: ");
        phanao=double.Parse(Console.ReadLine());
    }
    public static string Cong(double a,double b,double c,double d) 
    {
        return (a+c)+" + "+(b+d)+"i";
    }
    public static string Tru(double a,double b,double c,double d) 
    {
        return (a-c)+" + "+(b-d)+"i";
    }
    public static string Nhan(double a,double b,double c,double d) 
    {
        return (a*c-b*d)+" + "+(a*d+b*c)+"i";
    }
    public static string Chia(double a,double b,double c,double d) 
    {
        return ((a*c+b*d)/(a*a+b*b))+" + "+((a*d-b*c)/(a*a+b*b))+"i";
    }
    public static void Xuat(double a,double b,double c,double d)
    {
        Console.WriteLine(Cong(a,b,c,d));
        Console.WriteLine(Tru(a,b,c,d));
        Console.WriteLine(Nhan(a,b,c,d));
        Console.WriteLine(Chia(a,b,c,d));
    }
    
}
class Program 
{
    static void Main(string[] args)
    {
        SoPhuc a = new SoPhuc();
        SoPhuc b = new SoPhuc();
        SoPhuc.Xuat(a.phanthuc, a.phanao, b.phanthuc, b.phanao);
    }
}