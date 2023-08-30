// espee https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;

namespace c1b4
{
    class program
    {
        static void Main(string[] args)
        {
            int n;
            n=int.Parse(Console.ReadLine());
            // thêm vào mảng 2 chiều 
            int [,] A =new int [n,n];
            for (int i=0;i<n;i++) /// duyệt theo từng dòng 
            {
                string [] B= Console.ReadLine().Split(); /// tách chuỗi thành mảng 
                for (int j=0;j<n;j++) /// duyệt theo từng cột 
                {
                    A[i,j]=int.Parse(B[j]); /// thêm từng phần tử của mảng 1 chiều vào theo từng dòng của mảng 2 chiều 
                    /// vd  cột 1  cột 2
                    ///     1      2      3       4 (dòng 1)
                    ///     0      0      0       0 (dòng 2)
                    ///xong dòng 1 sẽ tới dòng 2 
                }
            }
            TeamWin(A,n); 
            TeamWinthanLose (A, n);
            TeamNotLose(A,n);
        }
        static void TeamWin (int [,]A, int n)
        {
            int []B=new int [n];
            for (int i=0;i<n;i++)
            {
                int tong =0;
                for (int j=0;j<n;j++)
                {
                    tong +=A[i,j];
                }
                B[i]=tong;
            }
            Console.WriteLine(Array.IndexOf(B,B.Max())+1);
        }
        static void TeamWinthanLose (int [,]A, int n)
        {
            for (int i=0;i<n;i++)
            {
                int win=0, lose=0;
                for (int j=0;j<n;j++)
                {
                    if (A[i,j]==3)
                    {win+=1;}
                    else if (A[i,j]==0)
                    {lose+=1;}
                }
                if (win > lose)
                {Console.WriteLine(i+1);}
            }
        }
        static void TeamNotLose(int [,]A, int n)
        {
            for (int i=0;i<n;i++)
            {
                int lose=0;
                for (int j=0;j<n;j++)
                {
                    if (A[i,j]==0 )
                    {lose+=1;}
                }
                if (lose==1)
                {
                    Console.Write(i+1);
                    Console.Write(' ');
                }
            }
        }
    }
}
