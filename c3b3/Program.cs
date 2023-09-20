class Organization
{
    string Name, Country, City, Address,Telephone ;
    public Organization(string name="", string country="", string city="",string address="", string telephone="")
    {
        Name = name;
        Country = country;
        City = city;
        Address = address;
        Telephone = telephone;
    } 
    public void Nhap()
    {
        Console.Write("Ten Doanh nghiep: ");
        Name=Console.ReadLine();
        Console.Write("Quoc gia: ");
        Country = Console.ReadLine();
        Console.Write("Thanh pho: ");
        City = Console.ReadLine();
        Console.Write("Dia chi: ");
        Address = Console.ReadLine();
        Console.Write("SDT: ");
        Telephone=Console.ReadLine();        
    }
    public bool Kiemtra()
    {
        
        if (Name!="" &&Country !=""&&City!=""&&Address!="")
        {
            if (Telephone.Length==10 )
            {   foreach (char c in Telephone)
                {
                    if (!char.IsDigit(c))
                    {return false ;}
                }
                return true;
            }
        }
        return false;
    }
    public void Xuat()
    {
        if (Kiemtra())
        {
            Console.Write("DN: {0} QG: {1} TP: {2} DC: {3} SDT: {4}", Name,Country,City,Address,Telephone);
        }
        else 
        {
            Console.Write("Nhap thong tin loi va Dung lai");
        }
    }
    ~Organization()
    {}
}
class programm
{
    public static void Main(string[] args)
    {
        Organization DN = new Organization();
        DN.Nhap();
        DN.Kiemtra();
        DN.Xuat();
    }
}