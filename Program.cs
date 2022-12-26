using System;

namespace tipDonusumleri
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("operatorDonusumleri");

            int xx = 6;
            string yy = Convert.ToString(xx);
            Console.WriteLine(yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz :"+zz);


            string s1 = "10" , s2 = "20";
            int sayi1 , sayi2 , toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;

            Console.WriteLine("Sonuc : " + toplam);

            Console.WriteLine("****** Parse ******");
            ParseMethod();

        }

        public static void ParseMethod() //Parse string ifadeleri dönüştürmek için kullanır Her zaman string ifadeleri alır.
        {
            string metin1 = "99";
            string metin2 = "64,37";
            double sayi2;
            
            int sayi1 = Int32.Parse(metin1);
            sayi2 = Double.Parse(metin2);

            Console.WriteLine("Sayi 1 :" + sayi1);
            Console.WriteLine("Sayi 2 :" + sayi2);
                    
        }
    }
}