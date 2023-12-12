namespace tinhtienhanggiamgia
{
    class programm 
    {
        static void Main(string[] args)
        {
            
            Console.Write("n= ");
            int n=int.Parse(Console.ReadLine());
            Console.Write("Gia tri lan luot cua cac mat hang la: ");
            string []s=Console.ReadLine().Split();
            int []A=new int[s.Length];
            for (int i=0; i<s.Length; i++)
            {
                A[i]=int.Parse(s[i]);
            }
            int slx=(int)A.Length/3;
            Array.Sort(A);
            for (int i=0; i<slx; i++)
            {   
                A[i]= 0; 
            }
            int tong=0;
            foreach (int i in A)
            {
                tong+=i;
            }
            Console.Write("Tong so tien phai tra la: {0}",tong);
        }
    }
}