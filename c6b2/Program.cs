interface thietbi 
{
    void ison();
    void isoff();
}
class mayquat : thietbi 
{ 
    public void ison()
    {
        Console.WriteLine("Mayquat dang bat");
    }
    public void isoff()
    {
        Console.WriteLine("Mayquat dang tat");
    }
}
class dieuhoa : thietbi
{ 
    public void ison()
    {
        Console.WriteLine("dieuhoa dang bat");
    }
    public void isoff()
    {
        Console.WriteLine("dieuhoa dang tat");
    }
}
class tv : thietbi
{
    public void ison()
    {
        Console.WriteLine("tv dang bat");
    }
    public void isoff()
    {
        Console.WriteLine("tv dang tat");
    }
}
class programm
{
    public static void Main(string[] args)
    {
        thietbi quat = new mayquat();
        quat.isoff();
        thietbi tv = new tv();
        tv.ison();
        thietbi dieuhoa = new dieuhoa();
        dieuhoa.isoff();
        dieuhoa.ison();
    }
}
