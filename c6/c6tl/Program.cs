abstract class CanHo 
{
    public static string [] ds = new string [100]; 
    public static int i = 0;
    protected long id;
    protected double area, price;
    protected int floor;
    public CanHo(long id, float area, int floor)
    {
        this.id = id; 
        this.area = area; 
        this.floor = floor;  
    }
    public abstract void gia();
    
}
class basic : CanHo 
{
    public basic(long id, float area, int floor) : base(id, area, floor)
    {
        gia();
    }
    public override void gia()
    {
        price = 500 * area;
        ds[i] += id+ " " + area+ " " + floor + " " + price;
        i++; 
    }
}
class condo : CanHo
{
    string view; 
    public condo(long id, float area, int floor, string view) : base(id, area, floor)
    {
        this.view = view;
        gia();
    }
    public override void gia()
    {
        if(view == "bien")
        {
            price = 700 * area * 1.4;
        }
        else if(view == "ho boi")
        {
            price = 700 * area * 1.1;
        }
        else if(view == "thanh pho")
        {
            price = 700 * area * 1.2;
        }
        else if(view == "khac")
        {
            price = 700 * area * 1;
        }
        ds[i] += id+ " " + area+ " " + floor + " " + price + " " + view;
        i++;
    }
}
class programm 
{ 
    public static void Main(string [] args)
    {
        basic ch1 = new basic(1, 100, 2);
        basic ch2 = new basic(2, 120, 3);
        basic ch3 = new basic(3, 120, 6);
        condo ch4 = new condo(4, 100, 5, "bien");
        condo ch5 = new condo(5, 140, 7, "thanh pho");
        condo ch6 = new condo(6, 180, 10, "ho boi");
        condo ch7 = new condo(7, 90, 2, "khac");
        double max = 0; 
        for(int j = 0; j < CanHo.i; j++)
        {
            Console.WriteLine(CanHo.ds[j]);
            string [] part = CanHo.ds[j].Split();
            if(max < double.Parse(part[3]))
            {
                max = double.Parse(part[3]); 
            }
        }
        Console.WriteLine("Can ho gia cao nhat");
        for(int j = 0; j < CanHo.i; j++)
        {
            string [] part = CanHo.ds[j].Split();
            if(max == double.Parse(part[3]))
            {
                Console.WriteLine(CanHo.ds[j]);
                break;
            }
        }
    }
}