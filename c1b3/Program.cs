// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;

namespace c1b3
{
    class programm 
    {
        static void Main(string[] args)
        {
            int n ;
            Console.Write("n= "); n=int.Parse(Console.ReadLine());
            Console.Write("A = [");
            string nhap=Console.ReadLine();
            nhap=nhap.Trim(']');
            //xóa các kí tự đầu cuối khi là ]
            string [] bd= nhap.Split(new string[] {", "},StringSplitOptions.RemoveEmptyEntries);
            float []A = new float [n];
            for (int i = 0; i <n; i++) 
            {
                A[i] = float.Parse(bd[i]);
            }

            //tinh tong
            float tong=0;
            foreach (float i in A)
            {
                if (i<0)
                {tong-=i;}
            }
            Console.WriteLine("Tong= "+tong);
            //tinh tich
            // code tay
            // float tich=1;
            // float max=A[0],min=A[0];
            // int mx=0,mn=0;
            // for (int i = 0; i < n; i++)
            // {
            //     if (A[i]<min)
            //     {min=A[i];}
            //     if (A[i]>max)
            //     {max=A[i];}
            // }   
            // for (int i = 0; i < n;i++)
            // {
            //     if (A[i]==max)
            //     {mx=i;}
            //     if (A[i]==min)
            //     {mn=i;}
            // }
            // if(mx>mn)
            // {   mn+=1;
            //     for (int i =mn;i<mx;i++)
            //     {tich*=A[i];}
            // }
            // else 
            // {   mx+=1;
            //     for (int i =mx;i<mn;i++)
            //     {tich*=A[i];}
            // }
            // Console.WriteLine("Tich " + tich);
            // dùng thư viện 
            float tich=1;
            float maxA=A.Max(),minA=A.Min();
            int imaxA=Array.IndexOf(A,maxA),iminA=Array.IndexOf(A,minA);
            if (imaxA>iminA)
            {   iminA+=1;
                for (int i=iminA;i<imaxA;i++)
                {tich*=A[i];}
            }
            else 
            {   imaxA+=1;
                for (int i=imaxA;i<iminA;i++)
                {tich*=A[i];}
            }
            Console.WriteLine("Tich " + tich);            
            // sắp xếp phần tử tăng dần 
            // sắp xếp phần tử giảm dần Array.Sort(A, (x, y) => y.CompareTo(x));
            Array.Sort(A);
            // Array.Sort(A, (x, y) => y.CompareTo(x));
            Console.Write("A_tang = [");
            for (int i=0;i<n;i++) 
            {
               if (i==A.Length-1)
                {Console.WriteLine(A[i]+"]");}
               else
                {Console.Write(A[i]+", ");}
            }
            // sắp xếp chẵn lẻ 
            int [] intA = new int[n];
            for (int i=0;i<n;i++)
            {
                intA[i]=(int) A[i];
                // ép kiểu int với từng phần tử trong A 
            }
            int iB=0,demchan=0;
            foreach (int i in A)
            {
                if (i%2==0)
                {demchan+=1;}
            }
            int [] B=new int [demchan]; 
            for (int i=0;i<n;i++)
            {
                if (intA[i]%2==0)
                {
                    B[iB]=intA[i];iB+=1;
                }
            }
            Array.Resize(ref B,n);
            foreach (int i in intA)
            {
                if (i%2!=0)
                {B[demchan]=i;demchan+=1;}
            } 
            Console.Write("A_biendoi = [");
            for (int i=0;i<n;i++)
            {
                if (B[i]%2==0)
                {Console.Write(B[i]+", ");}
                else 
                {
                    if (i==n-1)
                    {Console.Write(B[i]+"]");}
                    else 
                    {Console.Write(B[i]+", ");}
                }
            } 
            


            
            
        }
    }
}
