// See https://aka.ms/new-console-template for more information
namespace c1b1 
{
    class Programm
    {
        static void Main(string[] args)
        {
            string s,c ;
            float qth,htttql,cslt,triet;
            Console.Write("Ho va ten: "); s=Console.ReadLine();
            s=s.ToUpper();
            Console.Write("Lop : "); c=Console.ReadLine();
            Console.Write("Diem_QTH: "); qth=float.Parse(Console.ReadLine());
            Console.Write("Diem_HTTQL: ");htttql=float.Parse(Console.ReadLine());
            Console.Write("Diem_CSLT: "); cslt=float.Parse(Console.ReadLine()); 
            Console.Write("Diem_Triet: "); triet=float.Parse(Console.ReadLine()); 
        Xeploai(s,c,qth,htttql,cslt,triet);
        }
        static void Xeploai( string s, string c , float qth ,float htttql ,float cslt, float triet )
        {
            float kq=0;
            string loai;
            float [] Diem = {qth , htttql , cslt, triet};
            foreach ( float i in Diem )
            {
                if (i>=8.5) 
                {kq+=4;}
                else if (i>=7) 
                {kq+=3;}
                else if (i>=5.5) 
                {kq+=2;}
                else if (i>=4) 
                {kq+=1;}
                else 
                {kq+=0;}
            }
            kq=kq/4;
            if (kq>=3.6)
            {loai="Xuat sac";}
            else if (kq>3.2)
            {loai="Gioi";}
            else if (kq>2.5)
            {loai="Kha";}
            else if (kq>2)
            {loai="Trung binh";}
            else 
            {loai="Yeu";}
            Console.WriteLine("Sinh vien "+s+", Lop "+c+", Dat GPA "+kq+", Xep loai "+loai);
        }
    }
}
