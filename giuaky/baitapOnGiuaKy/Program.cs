using System;
using System.IO;
using System.Text;
class BatDongSan
{
    public string mabds{get;set;}
    public string tenbds{get;set;}
    public string huong{get;set;}
    public string diachi{get;set;}
    public float giaban{get;set;}
    public float dientich{get;set;}
}
class DanhsachBDS 
{
    public string [,] res = new string [100,6];
    public static int i = 0;
    public DanhsachBDS()
    {
        String input = File.ReadAllText( @"C:\Users\Asus\Downloads\c#.txt" );
        int j = 0;
        foreach (var row in input.Split('\n'))
        {
            j = 0;
            foreach (var col in row.Trim().Split(';'))
            {
                res[i, j] = Convert.ToString(col.Trim());
                j++;
            }
            i++;
        }   
    }
    public void Repair( string mabds)
    {
        for (int j = 0; j < i + 1; j++)
        {
            if (res[j,0]==mabds)
            {   
                while (true)
                {
                    Console.WriteLine("0: Thoát\n1: Sửa mã bds\n2: Sửa Tên bds\n3: Sửa Hướng\n4: Sửa Địa chỉ\n5: Sửa Diện tích\n6: Sửa Giá bán");
                    int n=int.Parse(Console.ReadLine());
                    if (n==0)
                    {break;}
                    else if (n==1)
                    {   Console.Write("Mã bds: ");
                        while (true)
                        {
                            string Mabds = Console.ReadLine();
                            bool found = false; 
                            for (int h = 0; h  < i; h++)
                            {
                                if (res[h,0] == Mabds)
                                {
                                    Console.WriteLine("Mã bất động sản đã tồn tại !!!\nYêu cầu nhập lại mã bất động sản khác");
                                    found = true;
                                    break;
                                } 
                            }
                            if (!found)
                            {   
                                res[j,0] = Mabds;
                                break;
                            }
                        }
                    }
                    else if (n==2)
                    {   Console.Write("Tên bds: ");
                        res[j,1]= Console.ReadLine();}
                    else if (n==3)
                    {   Console.Write("Hướng: ");
                        res[j,2]=Console.ReadLine();}
                    else if (n==4)
                    {   Console.Write("Địa chỉ: ");
                        res[j,3]=Console.ReadLine();}
                    else if (n==5)
                    {   Console.Write("Diện tích: ");
                        float h = float.Parse(Console.ReadLine());
                        res[j,4]=Convert.ToString(h);}
                    else if (n==6)
                    {   Console.Write("Giá bán: ");
                        float h = float.Parse(Console.ReadLine());
                        res[j,5]=Convert.ToString(h);}
                }
            } 
        }
        Console.WriteLine("Đã sửa thông tin)");
    }
    public void Add( BatDongSan bds)
    {
        while (true)
        {
            bool found = false; 
            for (int j = 0; j  < i; j++)
            {
                if (res[j,0] == bds.mabds)
                {
                    Console.WriteLine("Mã bất động sản đã tồn tại !!!\nYêu cầu nhập lại mã bất động sản khác");
                    bds.mabds = Console.ReadLine();
                    found = true;
                    break;
                } 
            }
            if (!found)
            {   
                res[i,0] = bds.mabds;
                break;
            }
        }
        res[i,1]= bds.tenbds;
        res[i,2]= bds.huong;
        res[i,3]= bds.diachi;
        res[i,4]=Convert.ToString(bds.dientich);
        res[i,5]=Convert.ToString(bds.giaban);
        i++;
    }

    public void Xuat()
    {
        for(int h = 0 ; h < i; h++)
        {
            for (int j=0;j<6;j++)
            {
                if(res[h,j] != null)
                {   Console.Write(res[h, j]+" ");}
            }
            Console.WriteLine();
        }
    }
    public void Remove(string mabds)
    {    
        for (int j = 0; j < i + 1 ; j++)
        {
            if (res[j, 0] == mabds)
            {  
                res[j, 0] = null;
                res[j, 1] = null;
                res[j, 2] = null;
                res[j, 3] = null;
                res[j, 4] = null;
                res[j, 5] = null;
            for (int k = j; k < i ; k++)
            {   
                res[k, 0] = res[k + 1, 0];
                res[k, 1] = res[k + 1, 1];
                res[k, 2] = res[k + 1, 2];
                res[k, 3] = res[k + 1, 3];
                res[k, 4] = res[k + 1, 4];
                res[k, 5] = res[k + 1, 5];
            }
            i--;
            break;
            }
        }
        Console.WriteLine("Đã xóa thông tin");
    }
    public void Findname(string tenbds)
    {   
        bool found=false;
        for (int j=0;j<i+1;j++)
        {
            if (res[j, 1] == tenbds)
            {
                Console.WriteLine(res[j, 0]+" "+res[j, 1]+" "+res[j, 2]+" "+res[j, 3]+" "+res[j, 4]+" "+res[j, 5]);
                found = true ;
            }
        }
        if (found==false)
        {Console.WriteLine("Không tìm thấy");}
    }
    public void Findhuong(string huong)
    {
        bool found=false;
        for (int j=0;j<i+1;j++)
        {
            if (res[j, 2] == huong)
            {
                Console.WriteLine(res[j, 0]+" "+res[j, 1]+" "+res[j, 2]+" "+res[j, 3]+" "+res[j, 4]+" "+res[j, 5]);
                found = true ; 
            }
        }
        if (found==false)
        {Console.WriteLine("Không tìm thấy");}
    }
    public void Findprice(float a , float b)
    {
        bool found = false ;
        for (int j = 0; j < i + 1; j++)
        {
            if(a <= Convert.ToSingle(res[j, 5]) & Convert.ToSingle(res[j, 5]) <= b)
            {
                Console.WriteLine(res[j, 0]+" "+res[j, 1]+" "+res[j, 2]+" "+res[j, 3]+" "+res[j, 4]+" "+res[j, 5]);
                found = true;
            } 
        }
        if (found==false)
        {Console.WriteLine("Không tìm thấy");}
    }
}
class Program 
{
    public static void Main(string[] args)
    {
        DanhsachBDS ds= new DanhsachBDS();  
        while (true)
        {   
            Console.WriteLine("------------Menu------------\nBấm 1: Thêm mới danh sách\nBấm 2: Sửa thông tin\nBấm 3: Xóa thông tin\nBấm 4: Xuất danh sách\nBấm 5: Tìm theo Tên\nBấm 6: Tìm theo Hướng\nBấm 7: Tìm theo Giá\nBấm 0: Exit\n------------------------>>>");
            int n =int.Parse(Console.ReadLine());
            if (n==0){break;}
            switch(n){
            case 1:
                BatDongSan bds =new BatDongSan();
                Console.Write("Mã bds: ");
                bds.mabds = Console.ReadLine();
                Console.Write("Tên bds: ");
                bds.tenbds=Console.ReadLine();
                Console.Write("Hướng: ");
                bds.huong = Console.ReadLine();
                Console.Write("Địa chỉ: ");
                bds.diachi=Console.ReadLine();
                Console.Write("Diện tích: ");
                bds.dientich=float.Parse(Console.ReadLine());
                Console.Write("Gía bán: ");
                bds.giaban=float.Parse(Console.ReadLine());
                ds.Add(bds);
                break;
            case 2:
                Console.Write("Nhập mã bds cần sửa thông tin: ");
                string mabds = Console.ReadLine();
                ds.Repair(mabds);
                break;
            case 3:
                Console.Write("Nhập mã bds cần xóa: ");
                mabds = Console.ReadLine();
                ds.Remove(mabds);
                break;
            case 4:
                ds.Xuat();break;
            case 5:
                Console.Write("Nhập tên bds cần tìm: ");
                mabds = Console.ReadLine();
                ds.Findname(mabds);
                break;
            case 6:
                Console.Write("Nhập hướng bds cần tìm: ");
                mabds = Console.ReadLine();
                ds.Findhuong(mabds);
                break;
            case 7:
                Console.WriteLine("Nằm trong khoảng giá: ");
                float a= float.Parse(Console.ReadLine());
                float b= float.Parse(Console.ReadLine());
                ds.Findprice(a ,b);
                break;                
            default: 
                Console.WriteLine("Lựa chọn không hợp lệ!!!");
                break;
            }
        }
    }
}