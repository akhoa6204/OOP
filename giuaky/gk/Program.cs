// Để quản lý sức khỏe người dân, yêu cầu xây dựng một chương trình quản lý bệnh tật như sau:
// Xây dựng lớp SUCKHOE (Sức khỏe) gồm các thuộc tính: CCCD (Căn cước công dân), TenBN(tên bệnh nhân), GioiTinh (Giới tính), Benh (Bệnh), Khuvuc (Khu vực), Mucdo (Mức độ).
// Từ đó xây dựng một chương trình quản lý dịch tễ, trong đó:
// 1. Xây dựng lớp SUCKHOE (Sức khỏe) với các thuộc tính ở phạm vi truy cập private (2 điểm)
// 2. Xây dựng lớp QuanlySuckhoe, là danh sách các bệnh nhân được nhập từ file .txt (2 điểm)
// 3. Tạo các phương thức quản lý bệnh nhân theo Menu sau:
// Bấm 1: Thêm (Thêm mới danh sách) (2 điểm)
// Bấm 2: Cách ly (Kiểm tra và xuất ra danh sách bệnh nhân cần được cách ly. Biết rằng, các bệnh cần cách ly là bệnh Lao và Covid) (2 điểm)
// Bấm 3: Sắp xếp (Sắp xếp bệnh nhân theo mức độ Bệnh) (2 điểm)
// Bấm 0: Exit
using System.ComponentModel;
using System.Globalization;
using System.Threading.Channels;
using System.Text;
class SUCKHOE
{
    long CCCD;
    string TenBN,GioiTinh,Benh,Khuvuc,Mucdo;
    public long cccd
    {
        get{return CCCD;}
        set{CCCD = value;}
    }
    public string tenbn
    {
        get{return TenBN;}
        set{TenBN = value;}
    }
    public string gioitinh
    {
        get{return GioiTinh;}
        set{GioiTinh = value;}
    }
    public string benh
    {
        get{return Benh;}
        set{Benh = value;}
    }
    public string mucdo
    {
        get{return Mucdo;}
        set{Mucdo = value;}
    }
}
class QuanLySucKhoe 
{
    public static string [,] res = new string [30,5];
    string [,] ds = new string [30,5];
    public static int i = 0;
    public static  int bd = 0;
    public static bool find = false ; 
    public QuanLySucKhoe()
    {
        string input = File.ReadAllText(@"D:\OOP\SucKhoe.txt");
        foreach(var row in input.Split('\n'))
        {
            int j = 0;
            foreach(var col in  row.Trim().Split(';'))
            {
                res[i,j] = Convert.ToString(col.Trim()); 
                j++;
            }
            i++;
        }
    }
    public void add(SUCKHOE bn)
    {
            while (true)
            {
                bool subfind = false;
                for (int j = 0; j < 30; j++)
                {
                    if (res[j,0] == Convert.ToString(bn.cccd)) 
                    {
                        subfind = true;
                    }
                }
                if (subfind)
                {
                    Console.Write("Nhập lại CCCD: ");
                    bn.cccd = long.Parse(Console.ReadLine());
                }
                else 
                {break;}
            }
            res[i, 0] = Convert.ToString(bn.cccd);
            res[i, 1] = bn.tenbn;
            res[i, 2] = bn.gioitinh;
            res[i, 3] = bn.benh;
            res[i, 4] = bn.mucdo;
            i++;
    }
    public void kiemtra()
    {
        for (int j= 0; j < 30; j++)
        {
            if (res[j, 3] == "Covid" | res[j, 3] == "Lao")
            { Console.WriteLine(res[j, 0] + " " + res[j, 1] + " " + res[j, 2] + " " + res[j, 3] + " " + res[j, 4]);}
        }
    }
    public void Sapxep()
    {
        find = true;
        int nhe = 0 ;
        for (int j = 0; j < 30; j++)
        {
            if (res[j, 4] == "Nhe")
            {
                ds[nhe, 0] = res[j, 0];
                ds[nhe, 1] = res[j, 1];
                ds[nhe, 2] = res[j, 2];
                ds[nhe, 3] = res[j, 3];
                ds[nhe, 4] = res[j, 4];
                nhe++;
            }
        }
        for (int j = 0; j < 30; j++)
        {
            if (res[j, 4] == "Trung binh")
            {
                ds[nhe, 0] = res[j, 0];
                ds[nhe, 1] = res[j, 1];
                ds[nhe, 2] = res[j, 2];
                ds[nhe, 3] = res[j, 3];
                ds[nhe, 4] = res[j, 4];
                nhe++;
            }
        }
        for (int j = 0; j < 30; j++)
        {
            if (res[j, 4] == "Nang")
            {
                ds[nhe, 0] = res[j, 0];
                ds[nhe, 1] = res[j, 1];
                ds[nhe, 2] = res[j, 2];
                ds[nhe, 3] = res[j, 3];
                ds[nhe, 4] = res[j, 4];
                nhe++;
            }
        }
    }
    public void Xuat()
    {
        if (find)
        {
            for(int j = 0; j < i; j++)
            {
                if (ds[j,0] != null)
                {Console.WriteLine(ds[j, 0]+ " " + ds[j, 1] + " " + ds[j, 2] + " " + ds[j, 3] + " " + ds[j, 4]);}
            }
        }
        else
        {
            for (int j = 0; j < i; j++)
            {
                if (res[j,0] != null)
                Console.WriteLine(res[j, 0]+ " " + res[j, 1] + " " + res[j, 2] + " " + res[j, 3] + " " + res[j, 4]);
            }
        }
    }

}
class programm 
{
    public static void Main(string[] args)
    {
        QuanLySucKhoe ds = new QuanLySucKhoe();
        while(true)
        {
            Console.WriteLine("******Menu******\n0: Dừng\n1: Thêm\n2: Kiểm tra\n3: Sắp xếp\n4: Xuất danh sách");
            int i = int.Parse(Console.ReadLine());
            if (i == 1 )
            {
                SUCKHOE bn = new SUCKHOE();
                Console.Write("Nhập CCCD: ");
                bn.cccd = long.Parse(Console.ReadLine());
                Console.Write("Nhập Tên bệnh nhân: ");  
                bn.tenbn = Console.ReadLine();   
                Console.Write("Nhập giới tính bệnh nhân: ");   
                bn.gioitinh = Console.ReadLine();
                Console.Write("Nhập tên bệnh: ");  
                bn.benh = Console.ReadLine();
                Console.Write("Nhập mức độ bệnh nhân: ");  
                bn.mucdo = Console.ReadLine();
                ds.add(bn);  
            }
            else if (i == 2)
            {
                ds.kiemtra();
            }
            else if (i == 3)
            {
                ds.Sapxep();
            }
            else if (i == 0)
            {
                break;
            }
            else if (i == 4)
            {
                ds.Xuat();
            }

        }

    }
}