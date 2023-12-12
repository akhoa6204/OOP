class DoanhNghiep 
{
    public string TenDN;
    public string Diachi;
    public int MST;
}
class DanhsachDN
{
    public static int size=0;
    DoanhNghiep DN = new DoanhNghiep();
    public DanhsachDN()
    {   
        size++;
        Array.Resize(ref Index.DSDN, size);
        Console.Write("TenDN: ");
        DN.TenDN = Console.ReadLine();
        Console.Write("Diachi: ");
        DN.Diachi = Console.ReadLine();
        Console.Write("MST: ");
        DN.MST = int.Parse(Console.ReadLine());
        Index.DSDN[size-1]=DN.TenDN+" "+DN.Diachi+" "+DN.MST;
    }
    public static void Xuat(string a,string b , int c)
    {
        Console.WriteLine(a+" "+b+" "+c);
    }
}
class Index
{
    public static string [] DSDN = new string [DanhsachDN.size];
    public string this[string tendn]
    {
        get
        {
            for (int i = 0; i < DanhsachDN.size; i++)
            {
                string[] parts = DSDN[i].Split();
                if (parts[0] == tendn)
                {
                    return parts[2];
                }
                
            }
            return "";
        }
    }
    public string this [int mst]
    {
        get
        {
            for (int i=0; i<DanhsachDN.size;i++) 
            {
                string[] parts = DSDN[i].Split();
                if(parts[2]==mst.ToString())
                {
                    return parts[0]+" "+parts[1]; 
                }
            }
            return "";
        }
    }
}
class Program
{
    static void Main(string [] args)
    {
        DanhsachDN DN1= new DanhsachDN();
        DanhsachDN DN2= new DanhsachDN();
        DanhsachDN DN3= new DanhsachDN();
        DanhsachDN DN4= new DanhsachDN();
        Index index= new Index();
        Console.Write("TenDN can tim MST: ");
        string tpdn= Console.ReadLine();
        string dn =index[tpdn];
        if(dn != "" )
        {Console.WriteLine(dn);} 
        else {Console.WriteLine($"Doanh nghiep ten {tpdn} khong ton tai");}
        Console.Write("MST cua dn can tim: ");
        tpdn =Console.ReadLine();
        dn=index[int.Parse(tpdn)];  
        if(dn.ToString() != "" ) 
        {Console.WriteLine(dn);}  
        else {Console.WriteLine($"Doanh nghiep co mst {tpdn} khong ton tai");}

    }
}