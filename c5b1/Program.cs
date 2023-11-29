    using System;
    class htron
    {
        public float bk;
        public float dk
        {
            get{return bk * 2;}
        }
        public double dt
        {
            get{return Math.PI * bk * bk;}
        } 
        public htron(float bk = 0)
        {
            this.bk = bk; 
        }
        public void Xuat()
        {
            Console.Write($"bk {bk} dk {dk} dt {dt} ");
        }
    }
    class hcau : htron 
    {
        public hcau(float bk = 0):base(bk)
        {}
        public new double dt
        {
            get{return Math.PI * bk * bk ;}
        }
        public double thetich
        {
            get{return (4/3) * Math.PI * bk * bk * bk;}
        }
        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"the tich {thetich}");
        }
    }
    class htru : htron 
    {   
        float chieucao;
        public float Chieucao
        {
            get{return chieucao;}
            set{chieucao = value;}
        }
        public htru(float bk=0,float chieucao=0):base(bk)
        {
            this.chieucao=chieucao;
        }
        public double cvday
        {
            get{return 2 * Math.PI * bk;}
        }
        public new double dt
        {
            get{return Math.PI * bk * bk;}
        }
        public double dtxq
        {
            get{return cvday * chieucao;}
        }
        public double dttp
        {
            get{return dtxq + 2 * dt;}
        }
        public double thetich
        {
            get{return dt * chieucao;}
        }
        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"chieu cao {chieucao} dtxq {dtxq} dttp {dttp} thetich {thetich}");
        }
    }
    class program 
    {
        public static void Main(string[] args)
        {
            htron h = new htron();
            h.bk = 10;
            h.Xuat();
            Console.WriteLine();
            hcau h1 =new hcau();
            h1.bk = 2; 
            h1.Xuat();
            htru h2 =new htru();
            h2.bk = 10;
            h2.Chieucao = 5;
            h2.Xuat();
        }
    }