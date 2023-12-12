class Info
{
    long ID;
    string Hoten,Group;
    public static int slsv=0;
    public static string [] A= new string [1];
    public Info()
    {   
        Console.Write("Nhap ID: ");
        ID=long.Parse(Console.ReadLine());
        Console.Write("Hoten: ");
        Hoten=Console.ReadLine();
        Console.Write("Group: ");
        Group=Console.ReadLine();
        DiemTP bangdiem=new DiemTP();
        A[slsv]=(ID+" "+Hoten+" "+Group+" "+bangdiem.DTB()) ;
        slsv++;
        Array.Resize(ref A,1+slsv);    
    }
}
class DiemTP
{
    float TP1,TP2,TP3;
    public DiemTP()
    {
        Console.Write("Diem TP1: ");
        TP1=Convert.ToSingle(Console.ReadLine()); 
        Console.Write("Diem TP2: ");
        TP2=Convert.ToSingle(Console.ReadLine());
        Console.Write("Diem TP3: ");
        TP3=Convert.ToSingle(Console.ReadLine());
    }
    public float DTB()
    {
        return TP1 * 0.1f + TP2 * 0.3f + TP3 * 0.6f;
    }

}
class Program 
{
    public static void Main(string[] args)
    {
        Info hs1 = new Info();       
        Info hs2 = new Info();
        Info hs3 = new Info();
        Console.WriteLine("So luong sv: "+Info.slsv);
        foreach (string i in Info.A)
        {
            Console.WriteLine(i);
        }
    }
}
