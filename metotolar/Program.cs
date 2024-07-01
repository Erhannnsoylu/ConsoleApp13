using metotolar;
using System;
    namespace Metotlar
{
    class program
    {
        static void Main(string[] args)
        {
           Urun urun1= new Urun();
            urun1.Adi = "elma";
            urun1.Fiyatı = "15";
            urun1.Aciklama = "amasya elması";
            Urun urun2 = new Urun();
            urun1.Adi = "elmaA";
            urun1.Fiyatı = "155";
            urun1.Aciklama = "amasya elmasAAı";

            Urun[] urunler = new Urun[] { urun1,urun2 };


            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine(urun.Aciklama);
            }

            Console.WriteLine("------------METOTLAR-------------")
            SepetManager  sepetManager= new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut","yesil","12",10);
        }
        
    }
}
