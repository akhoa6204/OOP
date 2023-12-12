// See https://aka.ms/new-console-template for more information
namespace tongsolenghichdao
{
    class program
    {
        static void Main(string[] args)
        {
            float tong=0 ;
            int n ; 
            Console.Write("n= "); n=int.Parse(Console.ReadLine());
            for (float i = 1; i < 2*n; i+=2)
            {
                tong+=(1/i);
            }
            Console.Write(tong);
        }
    }
}
