interface hinhhoc
{
    void chuvi();
    void dientich();
}
class hinhchunhat : hinhhoc
{
    float dai, rong; 
    public float Dai
    {
        get{return dai;}
        set{dai = value;}
    }
    public float Rong
    {
        get{return rong;}
        set{rong = value;}
    }
    public void chuvi()
    {
        Console.WriteLine((dai + rong) * 2);
    }
    public void dientich()
    {
        Console.WriteLine(dai * rong); 
    }
}
class hinhvuong : hinhhoc
{
    float canh; 
    public float Canh
    {
        get{return canh;}
        set{canh = value;}
    }
    public void chuvi()
    {
        Console.WriteLine(canh * 4);
    }
    public void dientich()
    {
        Console.WriteLine(canh * canh);
    }
}
class hinhtamgiac : hinhhoc
{
    float a, b, c; 
    public float A
    {
        get{return a;}
        set{a = value;}
    }
    public float B
    {
        get{return b;}
        set{b = value;}
    }
    public float C 
    {
        get{return c;}
        set{c = value;}
    }
    public void chuvi()
    {
        Console.WriteLine(a + b + c);
    }
    public void dientich()
    {
        if( a == b & b == c)
        {Console.WriteLine((Math.Sqrt(3) / 4) * a * a);}
        else if (a == b & a * a + b * b == c)
        {Console.WriteLine(0.5 * a * b);}
        else if (a == c & a * a + c * c == b * b)
        {Console.WriteLine(0.5 * a * c);}
        else if ( b == c & b * b + c *c == a * a)
        {Console.WriteLine(0.5 * b * c);}
        else if (a == b)
        {Console.WriteLine(0.25 * Math.Sqrt(4 * a * a - c * c) * c * c);}
        else if (a == c)
        {Console.WriteLine(0.25 * Math.Sqrt(4 * a * a - b * b) * b * b);}
        else if (b == c)
        {Console.WriteLine(0.25 * Math.Sqrt(4 * b * b - a * a)* a * a);}
        else
        {   float s = (a + b + c) / 2; 
            Console.WriteLine(0.5 * Math.Sqrt(s * (s - a) * (s - b) * (s - c)) * a);}
    }
}
class hinhtron : hinhhoc
{
    float bk; 
    public float BK
    {
        get{return bk;}
        set{bk = value;}
    }
    public void chuvi()
    {
        Console.WriteLine(2 * Math.PI * bk);
    }
    public void dientich()
    {
        Console.WriteLine(Math.PI * bk * bk);
    }
}
class programm 
{
    public static void Main(string[] args)
    {
        hinhchunhat h1 = new hinhchunhat(); 
        h1.Dai = 2;
        h1.Rong = 1;
        h1.chuvi();
        h1.dientich();
        hinhtamgiac h2 = new hinhtamgiac();
        h2.A = 3;
        h2.B = 4;
        h2.C = 5;
        h2.chuvi();
        h2.dientich();
    }
}