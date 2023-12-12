using System;
using System.Collections.Generic;

class PhuongTienGiaoThong 
{
    public string hsx, ten;
    public double nsx, vt;

    public PhuongTienGiaoThong(string hsx, string ten, double nsx, double vt)
    {
        this.hsx = hsx; 
        this.ten = ten;
        this.nsx = nsx;
        this.vt = vt;
    }

    public void Xuat()
    {
        Console.WriteLine($"Hãng sản xuất: {hsx}\nTên phương tiện: {ten}\nNhà sản xuất: {nsx}\nVận tốc tối đa: {vt}");
    }
}

class OTo : PhuongTienGiaoThong
{
    public int socho;
    public string kieudongco;

    public OTo(string hsx, string ten, double nsx, double vt, int socho, string kieudongco) : base(hsx, ten, nsx, vt)
    {
        this.socho = socho;
        this.kieudongco = kieudongco;
    }

    public new void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"Số chỗ: {socho}\nKiểu động cơ: {kieudongco}\nVận tốc cơ bản {VTCS()}");
    }

    public double VTCS()
    {
        return vt / socho; 
    }
}

class Program 
{
    public static void Main(string[] args)
    {
        List<OTo> ds = new List<OTo>
        {
            new OTo("Vinfast", "kLuxA", 2019, 200, 4, "nặng"),
            new OTo("Vinfast", "jLuxA", 2019, 220, 4, "trung bình"),
            new OTo("Vinfast", "hLuxA", 2019, 250, 8, "nhẹ"),
            new OTo("Vinfast", "gLuxA", 2019, 270, 6, "nhẹ"),
            new OTo("Vinfast", "fLuxA", 2019, 3200, 4, "nhẹ"),
            new OTo("Vinfast", "eLuxA", 2019, 1200, 4, "trung bình"),
            new OTo("Vinfast", "dLuxA", 2019, 1000, 4, "nặng"),
            new OTo("Vinfast", "cLuxA", 2019, 600, 4, "nhẹ"),
            new OTo("Vinfast", "bLuxA", 2019, 300, 4, "trung bình"),
            new OTo("Vinfast", "aLuxA", 2019, 180, 4, "nhẹ")
        };
        ds.Sort((oto1, oto2) => oto1.kieudongco.CompareTo(oto2.kieudongco));
        ds.Sort((oto1, oto2) =>
        {
            if (oto1.kieudongco == "nhẹ" && oto2.kieudongco == "nhẹ")
                return 0;
            else if (oto1.kieudongco == "nhẹ")
                return -1;
            else if (oto2.kieudongco == "nhẹ")
                return 1;
            else if (oto1.kieudongco == "trung bình" && oto2.kieudongco == "trung bình")
                return 0;
            else if (oto1.kieudongco == "trung bình")
                return -1;
            else
                return 1;
        });

        foreach (var oto in ds)
        {
            oto.Xuat();
        }
        foreach (var oto in ds)
        {
            Console.WriteLine($"{oto.hsx} {oto.ten} {oto.nsx} {oto.vt} {oto.socho} {oto.kieudongco} {oto.VTCS()}");
        }
    }
}
