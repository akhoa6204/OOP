// See https://aka.ms/new-console-template for more information
namespace demsonguyento
{
    class program 
    {
        static void Main(string[] args)
        {
            int a,b,dem=0;
            Console.Write("a=");
            a=int.Parse(Console.ReadLine());
            Console.Write("b=");
            b=int.Parse(Console.ReadLine()); 
        for (int i=a; i<b+1; i++)
        {
            int n=0;
            for (int j=a; j<i; j++)
                {
                    if (i%j==0)
                    {n+=1;}
                }
            if (n==0)
            {
                dem+=1;
            }
        }
        Console.Write(dem);
            
        }
    }
}

