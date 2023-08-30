// See https://aka.ms/new-console-template for more information
using System ;
namespace XOR
{
    class program 
    {
        static void Main(string[] args)
        {
            string a,b;
            Console.Write("A=");
            a=Console.ReadLine();
            Console.Write("B=");
            b=Console.ReadLine();
            string [] A=new string [a.Length];
            for (int i=0; i<A.Length; i++)
            {
                A[i]=a[i].ToString();
            }
            string [] B=new string [b.Length];
            for (int i=0; i<B.Length; i++)
            {
                B[i]=b[i].ToString();
            }
            for (int i=0; i<A.Length; i++)
            {
                if (A[i]==B[i])
                {Console.Write(0);}
                else 
                {Console.Write(1);}
            }
        }
    }
}

