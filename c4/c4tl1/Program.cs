﻿class sinhvien
{
    private long MaSV;
    private int SoTC;
    private float Giamtru;
    private float hocphi;
    public long masv
    {
        get{return MaSV;}
        set{MaSV = value;}
    }
    public int sotc
    {
        get{return SoTC;}
        set {SoTC = value;}
    }
    public float giamtru
    {
        get{return Giamtru;}
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
        sinhvien sv = new sinhvien();
        sv.masv = 221121514115;
        sv.sotc = 22;
        sv.giamtru = 2;
        sv.gethocphi();
        Console.WriteLine($"Sinh vien co ma so {sv.masv}, hoc {sv.sotc} tin chi, Giam tru {sv.giamtru}% phai dong hoc phi la {sv.gethocphi()}");
    }
}
