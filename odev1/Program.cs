    using System;

    class Urun
    {
        public string UrunAdi { get; set; }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Baklava";
            Urun urun2 = new Urun();
            urun2.UrunAdi = "Poğaça";
            Urun urun3 = new Urun();
            urun3.UrunAdi = "Meyve Suyu";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi);
            }

            string x = "Baklava";
            while (x == "Baklava")
            {
                Console.WriteLine(urun1.UrunAdi + " satışı devam ediyor");
                break;

            }
        for (string i = "Baklava"; i <urunler.Length; i++)
        {
            Console.WriteLine("Baklava satışı devamke");
        }
    }
}