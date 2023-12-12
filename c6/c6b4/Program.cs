abstract class khachhang 
{
    public static string [] ds = new string [1];
    public static int [] phong = new int [3];
    public static int i = 0; 
    protected string tenkh; 
    protected long cmnd; 
    protected int songaythue; 
    public khachhang(string tenkh, long cmnd, int songaythue)
    {
        this.tenkh = tenkh;
        this.cmnd = cmnd;
        this.songaythue = songaythue;
    }
    abstract public void loc();
}

class standard : khachhang
{

    public standard(string tenkh, long cmnd, int songaythue) : base(tenkh, cmnd, songaythue)
    {   
        loc();
    }
    public override void loc()
    {
        if(songaythue < 6)
        {
            phong[0] += (songaythue * 500);
            ds[i] += tenkh + " " + cmnd.ToString() + " " + songaythue.ToString() + " " + "Standard" + " " + (songaythue * 500).ToString();
            i++; Array.Resize(ref ds, i + 1);
        }
        else 
        {
            phong[0] += ((5 * 500) + (songaythue - 5) * 400);
            ds[i] += tenkh + " " + cmnd.ToString() + " " + songaythue.ToString() + " " + "Standard" + " " + ((5 * 500) + (songaythue - 5) * 400).ToString();
            i++; Array.Resize(ref ds, i + 1);
        }
    }
}
class vip : khachhang
{
    string loaiphong; 
    public vip(string tenkh, long cmnd, int songaythue, string loaiphong) : base(tenkh, cmnd, songaythue)
    {
        this.loaiphong = loaiphong;
        loc();
    }
    public override void loc()
    {
        if(songaythue < 6)
        {
            if(loaiphong == "Luxury")
            {
                phong[1] += (songaythue * 1100);
                ds[i] += tenkh + " " + cmnd.ToString() + " " + songaythue.ToString() + " " + loaiphong + " " + (songaythue * 1100).ToString();
                i++; Array.Resize(ref ds, i + 1);
            }
            else if (loaiphong == "President")
            {
                phong[2] += (songaythue * 1300);
                ds[i] += tenkh + " " + cmnd.ToString() + " " + songaythue.ToString() + " " + loaiphong + " " + (songaythue * 1300).ToString();
                i++; Array.Resize(ref ds, i + 1);
            }
        }
        else 
        {
            if(loaiphong == "Luxury")
            {
                phong[1] += ((5 * 1100) + (songaythue - 5) * 1000);
                ds[i] += tenkh + " " + cmnd.ToString() + " " + songaythue.ToString() + " " + loaiphong + " " + ((5 * 1100) + (songaythue - 5) * 1000).ToString();
                i++; Array.Resize(ref ds, i + 1);
            }
            else if (loaiphong == "President")
            {
                phong[2] += ((5 * 1300) + (songaythue - 5) * 1000);
                ds[i] += tenkh + " " + cmnd.ToString() + " " + songaythue.ToString() + " " + loaiphong + " " + ((5 * 1300) + (songaythue - 5) * 1000).ToString();
                i++; Array.Resize(ref ds, i + 1);
            }
        }
    }
}
class programm 
{
    public static void Main(string[] args)
    {
        khachhang k1 = new standard("khoa", 048204000216, 10);
        khachhang k2 = new vip("akhoa", 048204000215, 2, "Luxury");
        khachhang k3 = new vip("ngoc", 048204000214, 5, "President");
        khachhang k4 = new vip("bo", 048204000213, 12, "Luxury");
        khachhang k5 = new standard("co", 048204000218, 9);
        // 1 
        Console.WriteLine("--------------------------------------------");
        foreach (var kh in khachhang.ds)
        {
            if (kh != null)
            {
                Console.WriteLine(kh);
            }
        }
        // 2
        Console.WriteLine("--------------------------------------------");
        int tong = 0;
        Console.Write("Doanh thu: ");
        foreach (var doanhthu in khachhang.phong)
        {
            tong += doanhthu;
        }
        Console.WriteLine(tong);
        // 3
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Thông tin thuê phòng Standard");
        foreach (var kh in khachhang.ds)
        {   
            if(kh != null)
            {    
                string [] part = kh.Split();
                if (part[3] == "Standard")
                {
                    Console.WriteLine(kh);
                }
            }
        }
        // 4
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Tổng tiền cho thuê phòng Luxury là: " + khachhang.phong[1]);
    }
}