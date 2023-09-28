using System.Reflection.Metadata;

class Meo 
{
    string Ten,Giong,Gioitinh;
    int Tuoi;
    public Meo(string ten="",string giong="",string gioitinh="",int tuoi=0)
    {
        Ten=ten;
        Giong=giong;
        Gioitinh=gioitinh;
        Tuoi=tuoi;
    }
    public static int Dem=0;
    public Meo()
    {
        
            Console.Write("Ten: ");
            Ten=Console.ReadLine().ToUpper();
            Console.Write("Giong: ");
            Giong=Console.ReadLine().ToUpper();
            Console.Write("Gioitinh: ");
            Gioitinh=Console.ReadLine().ToUpper();
            Console.Write("Tuoi: ");
            Tuoi=int.Parse(Console.ReadLine());   
            Dem++;    
    }
    
    public void Xuat()
    {
        Console.WriteLine("Ten: "+Ten+ " Giong: "+Giong+" Gioitinh: "+Gioitinh+" Tuoi: "+Tuoi);
    }
    ~ Meo ()
    {}
}
class programm
{
    static void Main(string[] args)
    {   
        Meo m= new Meo();
        Meo m1= new Meo();
        Meo m2= new Meo();
        m.Xuat();
        m1.Xuat();
        m2.Xuat();
        Console.WriteLine("So luong Meo: "+Meo.Dem);
    }

}
