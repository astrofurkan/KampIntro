using System;

namespace derdiniopeyim
{
    class Program
    {
        static void Main(string[] args)
        {

            Dert dert1 = new Dert();
            dert1.Adi = "Kadın meselesi";
            dert1.Aciklama = "Hocam bizi barıştır pls";

            Dert dert2 = new Dert();
            dert2.Adi = "Allah başka dert vermesin karşim";
        
            Dert[] dertler = new Dert[] { dert1, dert2 };

            foreach (var dert in dertler)
            {
                Console.WriteLine(dert.Adi);
                Console.WriteLine(dert.Aciklama);
                Console.WriteLine("-----------");
            }

            Console.WriteLine("------------Çekmediğim Dertler Çile Kalmadı--------------");

            DerdiniOpeyimManager dertManager = new DerdiniOpeyimManager();
            dertManager.DerdiniOpeyimButonu(dert1);
            






        }
    }
}


// Don't repeat yourself as dry 
// Clean Code - Best Practice 

