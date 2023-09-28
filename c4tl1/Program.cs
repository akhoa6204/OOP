class sinhvien
{
    private string MaSV;
    private int SoTC;
    private float Giamtru;
    private float hocphi;
    public string masv
    {
        set{MaSV = value;}
    }
    public int sotc
    {
        set {SoTC = value;}
    }
    public float giamtru
    {
        set {Giamtru = value;}
    }
    public float gethocphi()
    {
        return SoTC*450000-(Giamtru/100)*(SoTC*450000);
    }
}
class program 
{
    static void Main(string[] args)
    {
        sinhvien sv=new sinhvien();
        sv.masv="221121514115";
        sv.sotc=22;
        sv.giamtru=2;
        sv.gethocphi();
        Console.WriteLine($"Sinh vien co ma so {sv.masv}, hoc {sv.sotc} tin chi, Giam tru {sv.giamtru}% phai dong hoc phi la {sv.gethocphi()}");
    }
}
