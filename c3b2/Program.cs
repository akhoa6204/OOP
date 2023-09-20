class Meo 
{
    string Ten,Giong,Gioitinh;
    float Tuoi;
    public Meo(string ten="",string giong="",string gioitinh="",int tuoi=0)
    {
        Ten=ten;
        Giong=giong;
        Gioitinh=gioitinh;
        Tuoi=tuoi;
    }
    // public Meo(string ten,string giong,string gioitinh;int tuoi)
    // {
    //     Ten=ten;
    //     Giong=giong;
    //     Gioitinh=gioitinh;
    //     Tuoi=tuoi;
    // }
    // public  Meo ()
    // {}
    public void Nhap ()
    {
        
            Console.Write("Ten: ");
            Ten=Console.ReadLine().ToUpper();
            Console.Write("Giong: ");
            Giong=Console.ReadLine().ToUpper();
            Console.Write("Gioitinh: ");
            Gioitinh=Console.ReadLine().ToUpper();
            Console.Write("Tuoi: ");
            Tuoi=int.Parse(Console.ReadLine());       
    }
    
    public string Xuat()
    {
        string A="Ten: "+Ten+ " Giong: "+Giong+" Gioitinh: "+Gioitinh+" Tuoi: "+Tuoi;
        return A;
    }
    ~ Meo ()
    {}
}
class programm
{
    static void Main(string[] args)
    {   
        string tieptuc;int dem=0;
        string [] ds =new string[1];
        Meo m=new Meo();
        while (true)
        {
             m.Nhap();
            Console.Write("tieptuc: ");
            tieptuc=Console.ReadLine();
            ds[dem]=m.Xuat();
            if (tieptuc!="t" & tieptuc!="T") 
            {break;}
            dem+=1;
            Array.Resize(ref ds,dem+1);   
        }
        foreach (string i in ds)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Soluong Meo: "+(dem+1));
    }
}
