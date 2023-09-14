// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
namespace uocchunglnla1
{
    class program
    {
        static void Main(string[] args)
        {
            int n,dem=0;
            Console.Write("n= ");
            n=int.Parse(Console.ReadLine());
            string []A=Console.ReadLine().Split();
            int [] intA =new int[A.Length];
            for (int i=0;i<A.Length;i++)
            {
                intA[i]=int.Parse(A[i]);
            }
            for (int i=0;i<(A.Length);i++)
            {
                for (int j=i+1;j<A.Length;j++)
                {
                    if (UCLN(intA[i],intA[j])==1)
                    {
                        dem+=1;
                    }
                }
            }
            Console.Write(dem);
        }
        static int UCLN(int a,int b)
        {
        while (b!=0)
        {
            int UCLN=b;
            b=a%b;
            a=UCLN;
        }
        return a;
        }
    }
}
