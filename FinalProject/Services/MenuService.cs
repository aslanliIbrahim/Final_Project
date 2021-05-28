using ConsoleTables;
using System;

namespace FinalProject.Services
{
    public class MenuService
    {

        static MarketMenu market = new();
        #region Mehsul
        public static void Umumi_mehsullar()
        {
           
            var table = new ConsoleTable("ad", "kod","qiymet", "kateqoriya", "say");
            
            foreach (var mehsul in market.Mehsullar)
            {
                table.AddRow(mehsul.Ad, mehsul.Kod, mehsul.Qiymet, mehsul.Kateqoriya, mehsul.Say);
            }
            table.Write();
            Console.WriteLine();
        }
        public static void KatiqoriyaGoster()
        {
            Console.WriteLine("Kateqoriya daxil edin");
            var input = Console.ReadLine();
            var table = new ConsoleTable("Ad","Kateqoriya", "Qiymet", "Say");
            foreach (var mehsul in market.Kateqoriyaya_Gore_Mehsul_Tapmaq(input))
            {
                table.AddRow(mehsul.Ad, mehsul.Kateqoriya, mehsul.Qiymet, mehsul.Say);
            }
            table.Write();
            Console.WriteLine(); 
        }

        public static void Qiymet_araliginagore_MehsulTapmaq()
        {
           
            var table = new ConsoleTable("Ad", "Qiymet", "Say");
            Console.WriteLine("Min qiymet daxil edin");
            double BaslangicQiymet = double.Parse(Console.ReadLine());
            Console.WriteLine("Max qiymet daxil edin");
            double SonQiymet = double.Parse(Console.ReadLine());
            foreach (var item in market.Qiymet_Araliginda_Mehsul_Tapilmasi(BaslangicQiymet,SonQiymet))
            {
                table.AddRow(item.Ad, item.Qiymet, item.Say);
            }
                
            table.Write();
            Console.WriteLine();


        }

        public static void Mehsulun_Adagore_Tapilmas()
        {
            var table = new ConsoleTable("Ad","Kod");
            string Ad = Console.ReadLine();
            foreach (var item in market.Mehsulun_Adagore_Tapilmas(Ad))
            {
                table.AddRow(item.Ad, item.Kod);
            }
            table.Write();
            Console.WriteLine();
        }


       


        #endregion

        #region Satis
        public static void Umumi_Satis()
        {
            var table = new ConsoleTable("Nomre", "Mebleg", "Mehsul", "Vaxt");
            foreach (var item in market.Satislarin_Qaytarilmasi())
            {
                table.AddRow(item.Nomre, item.Mebleg, item.Tarix);
            }
            table.Write();
            Console.WriteLine();
        }
        public static void TarixeGore_SatisinQaytarilmasi()
        {
            
            Console.WriteLine("Birinci tarixi elave edin(mm.dd.yyyy)");
            string str1 = Console.ReadLine();
            Console.WriteLine("Ikinci tarixi elave edin(mm.dd.yyyy)");
            string str2 = Console.ReadLine();
            DateTime BaslamaVaxti = DateTime.Parse(str1);
            DateTime BitmeVaxti = DateTime.Parse(str2);
            var table = new ConsoleTable( "Nomresi", "Mebleg", "Zaman");
            foreach (var item in market.Zamana_gore_axdarilan_satislar(BaslamaVaxti, BitmeVaxti))
            {
                table.AddRow(item.Nomre,item.Mebleg, item.Tarix);
            }
            table.Write();
            Console.WriteLine();

        }
        public static void Mebglege_gore_satisin_qaytarilmasi()
        {
            var table = new ConsoleTable("Qiymet");
            Console.WriteLine("Baslangic  qiymeti daxil edin");
            double baslaqiymet = double.Parse(Console.ReadLine());
            Console.WriteLine("Son qiymeti daxil edin");
            double sonqiymet = double.Parse(Console.ReadLine());
            foreach (var item in market.Mebglege_gore_satisin_qaytarilmasi(baslaqiymet, sonqiymet))
            {
                table.AddRow(item.Mebleg);
            }
            table.Write();
            Console.WriteLine();
        }
        public static void Nomreye_esasen_satisqaytarilmasi()
        {
            var table = new ConsoleTable("Nomre");
            int nomre = Convert.ToInt32(Console.ReadLine());
            foreach (var item in market.Nomreye_esasen_satisqaytarilmasi(nomre))
            {
                table.AddRow(item.Nomre);
            }
            table.Write();
            Console.WriteLine();
        }
        public static void Zamana_gore_Satis_Qaytarilmasi()
        {
            var table = new ConsoleTable("Tarix");
            DateTime tarix = DateTime.Parse(Console.ReadLine());
            foreach (var item in market.Zamana_gore_Satis_Qaytarilmasi(tarix))
            {
                table.AddRow(item.Tarix);
            }
            table.Write();
            Console.WriteLine();
        }
        #endregion

        #region 
        public static void Mehsul_elave_olunmasi()
        {
            Console.WriteLine("Ad daxil edin");
            string ad = Console.ReadLine();
            Console.WriteLine("Qiymet daxil edin");
            double qiymet = double.Parse(Console.ReadLine());
            Console.WriteLine("Kateqoriyasini daxil edin");
            string kateqoriya = Console.ReadLine();
            Console.WriteLine("Say daxil edin");
            int say =int.Parse(Console.ReadLine());
            market.Mehsul_Yuklemek(ad,qiymet,kateqoriya,say);
        }
        public static void Mehsul_Deyismek()
        {
            Console.WriteLine("Kod daxil edin");
            int kod = int.Parse(Console.ReadLine());
            Console.WriteLine("Ad daxil edin");
            string ad = Console.ReadLine();
            Console.WriteLine("Qiymet daxil edin");
            double qiymet = double.Parse(Console.ReadLine());
            Console.WriteLine("Kateqoriya daxil edin");
            string kateqoriya = Console.ReadLine();
            Console.WriteLine("Say daxil edin");
            int say = int.Parse(Console.ReadLine());
            market.Mehsul_Deyismek(kod, ad, qiymet,  kateqoriya, say);
        }
        public static void Mehsul_Silmek()
        {
            Console.WriteLine("Ad daxil edin");
            string Ad = Console.ReadLine();
            market.Mehsul_Silmek(Ad);
        }
        #endregion

        #region
        public static void Satis_Elave_Etmek()
        {
            Console.WriteLine("Kod elave edin");
            int kod = int.Parse(Console.ReadLine());
            Console.WriteLine("Say elave edin");
            int say = int.Parse(Console.ReadLine());
            market.Satis_Elave_Etmek(kod, say );
        }
        public static void Satisdan_Mehsulun_Qaytarilmasi()
        {
            Console.WriteLine("Necenci satisdan qayidacaq mehsulun nomresini daxil edin");
            int nomre = int.Parse(Console.ReadLine());
            Console.WriteLine("Ad daxil edin");
            string ad = Console.ReadLine();
            Console.WriteLine("Say daxil edin");
            int say = int.Parse(Console.ReadLine());
            market.Satisdan_Mehsulun_Qaytarilmasi(nomre,ad, say);
            Console.WriteLine("Mehsul silindi...");
        }

        public static void Satislarin_Qaytarilmasi()
        {
            var table =new ConsoleTable("Nomre", "Mebleg","Tarix");
            foreach (var item in market.satislar)
            {
                table.AddRow(item.Nomre, item.Mebleg.ToString("#.00"), item.Tarix);
            }
            table.Write();
            Console.WriteLine();

        }

        public static void Zamana_Gore_Axdarilan_Satislar()
        {
            
            Console.WriteLine("Tarixi daxil edin(dd.mm.yyyy)");
            string str1 = Console.ReadLine();
            DateTime bitmevaxti = DateTime.Parse(str1);
            var table = new ConsoleTable("Nomresi","Mebleg", "Tarix");
            foreach (var item in market.Zamana_gore_Satis_Qaytarilmasi(bitmevaxti))
            {
                
                table.AddRow(item.Nomre,item.Mebleg,item.Tarix);
            }
            table.Write();
            Console.WriteLine();
        }
        public static void Zamana_Gore_Satislarin_Qaytarilmasi()
        {
            DateTime tarix = DateTime.Parse(Console.ReadLine());
            market.Zamana_gore_Satis_Qaytarilmasi(tarix);
        }
        public static void Nomreye_Esasen_Satisqaytarilmasi()
        {
            Console.WriteLine("Satisin nomresini daxil edin");
            int nomre = int.Parse(Console.ReadLine());
            var table = new ConsoleTable("Nomre", "Mebleg","Tarix");
            foreach (var item in market.Nomreye_esasen_satisqaytarilmasi(nomre))
            {
                table.AddRow(item.Nomre, item.Mebleg, item.Tarix);
            }
            table.Write();
            Console.WriteLine();
        }
        public static void Satis_Silinmesi()
        {
            Console.WriteLine("Nomre daxil edin");
            int nomre = int.Parse(Console.ReadLine());
            market.Satislarin_Silinmesi(nomre);
            Console.WriteLine("Satis silindi");
        }
        #endregion
    }

}
