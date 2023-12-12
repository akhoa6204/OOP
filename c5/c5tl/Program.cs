abstract class KhachHang 
{
    public static int tong = 0;
    protected int giave;
    protected string tenkh; 
    public KhachHang(string tenkh)
    {
        this.tenkh = tenkh;
    }
    abstract public void the();
} 
class NguoiLon : KhachHang
{
    long cmnd;
    public NguoiLon(string tenkh, long cmnd):base(tenkh)
    {
        this.cmnd = cmnd;
        tong += 250;
    }
        public override void the()
    {
        Console.WriteLine(tenkh +" " + "the xanh");
    }
}
class TreEm : KhachHang
{
    float chieucao;
    public TreEm(string tenkh, float chieucao):base(tenkh)
    {
        this.chieucao = chieucao;
        if (chieucao >= 130)
        {
            giave = 130;
        }
        else
        {
            giave = 0;
        }
        tong += giave;
    }
    public override void the()
    {
        Console.WriteLine(tenkh +" " + "the do");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        TreEm n1 = new TreEm("k", 120);
        n1.the();
        TreEm n2 = new TreEm("h", 140);
        n2.the();
        NguoiLon n3 = new NguoiLon("khoa", 123);
        n3.the();
        NguoiLon n4 = new NguoiLon("ngoc", 456);
        n4.the();
        Console.WriteLine("tong tien: " + KhachHang.tong);
    }
}
