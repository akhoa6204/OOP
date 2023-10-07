class DoanhNghiep 
{
    public string TenDN,Diachi;
    public int MST;
}
class DanhsachDN
{
    public static string [] DSDN = new string [50];
    public static int size=0;
    DoanhNghiep DN = new DoanhNghiep();
    public DanhsachDN()
    {
        Array.Resize(ref DSDN, size++);
        Console.Write("TenDN: ");
        DN.TenDN = Console.ReadLine();
        Console.Write("Diachi: ");
        DN.Diachi = Console.ReadLine();
        Console.Write("MST: ");
        DN.MST = int.Parse(Console.ReadLine());
        DSDN[size]=(DN.TenDN+" "+DN.Diachi+" "+DN.MST);
        size++;
        // Array.Resize(ref DSDN,size+1);        
    }
}
class Index    
{   
    public string this[int index]
    {
        get
        {
            string tmp;
            if (index>=0 && index <=DanhsachDN.size-1)
            {
                tmp=DanhsachDN.DSDN[index];
            }
            else 
            {
                tmp="";
            }
            return (tmp);
        }
        set
        {
            if (index >=0 && index <=DanhsachDN.size-1)
            {DanhsachDN.DSDN[index]=value;}
        }
    }
    public static void Xuat(string a,string b , int c)
    {
        Console.WriteLine(a+" "+b+" "+c);
    }

}
class Program
{
    static void Main(string [] args)
    {
        DanhsachDN DN1= new DanhsachDN();
        DanhsachDN DN2= new DanhsachDN();
        DanhsachDN Dn2= new DanhsachDN();
        Index IndexDN =new Index();
        Console.Write("MST can tim: ");
        string MSTfind=Console.ReadLine();
        for (int i=0; i<DanhsachDN.size-1; i++) 
        {
            if (DanhsachDN.DSDN[i].Contains(MSTfind))
            {
                Console.WriteLine(DanhsachDN.DSDN[i]);
            }
        }

    }
}