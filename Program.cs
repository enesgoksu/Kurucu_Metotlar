namespace Kurucu_Metotlar.Kurucu_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Ayşe","Kara",34569725,"İnsan Kaynakları");

            calisan1.CalisanBilgileri();

            Console.WriteLine("******************");

            Calisan calisan2 = new Calisan("Deniz","Arda",23614523,"Satın Alma");

            calisan2.CalisanBilgileri();

            Console.WriteLine("*************");

            Calisan calisan3 = new Calisan("Enes","Göksu");
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad,string soyad,int no,string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
            
        }

        public Calisan(string ad,string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan(){}

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın adı:{0}", Ad);
            Console.WriteLine("Çalışanın soyadı:{0}", Soyad);
            Console.WriteLine("Çalışan no:{0}", No);
            Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
        }
    }
}