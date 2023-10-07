
namespace BTLop
{
    class Programm
    {
        public static void Main(string[] args)
        {
            Chitieu t10 = new Chitieu(700,500);
            t10.Kiemtra();
        }
    }
    class Chitieu
    {
        private double Income,Outcome,Balance,Cost;
        public Chitieu(double Income, double Outcome)
        {
            this.Income = Income;
            this.Outcome = Outcome;
        }
        public double BALANCE
        {
            get
            {
                return Income - Outcome;
            }
        }
        public double COST 
        {
            get{return (Outcome/Income)*100;}
        }
        public void Kiemtra()
        {
            if (BALANCE <= 10 || COST >=90)
            {
                Console.WriteLine("Thang nay da tieu het {0}%, con lai {1}$",COST,BALANCE);
                Console.WriteLine("Het tien roi");
            }
            else 
            {
                Console.WriteLine("Thang nay da tieu het {0}%, con lai {1}$",COST,BALANCE);
                Console.WriteLine("Con tien");
            }
        }
    }
}