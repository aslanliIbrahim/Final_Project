using FinalProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Services
{
    public  class MarketMenu 
    {
        static MarketMenu market = new();


       public List<Mehsul> Mehsullar { get; set; }
       public List<Satis> satislar { get; set; }
        public MarketMenu()
        {
            Mehsullar = new();
            satislar = new();
        }

        #region MEHSUL
        public void Mehsul_Yuklemek(string ad, double qiymet,  string kateqoriya, int say)
        {
            Mehsul mehsul = new();
            mehsul.Ad = ad;
            mehsul.Qiymet = qiymet;          
            mehsul.Kateqoriya = kateqoriya;
            mehsul.Say = say;
            Mehsullar.Add(mehsul);

        }
        public void Mehsul_Deyismek(int kod, string ad, double qiymet,  string kateqoriya,  int say)
        {
            var Index = Mehsullar.Find(m => m.Kod == kod);
            
            Mehsul mehsul = new();
            Mehsullar.Remove(Index);
            mehsul.Ad = ad;
            mehsul.Qiymet = qiymet;
            
            mehsul.Kateqoriya = kateqoriya;
            mehsul.Say = say;
            Mehsullar.Add(mehsul);

        }
        public void Mehsul_Silmek(string ad)
        {
            var Index = Mehsullar.FindIndex(m => m.Ad == ad);
            Mehsullar.RemoveAt(Index);
        }
        

        public List<Mehsul> Qiymet_Araliginda_Mehsul_Tapilmasi(double ilkqiymet, double sonqiymet)
        {
            var Index = Mehsullar.FindAll(m => m.Qiymet >= ilkqiymet && m.Qiymet <= sonqiymet);

            return Index;
        }
        public List<Mehsul> Kateqoriyaya_Gore_Mehsul_Tapmaq(string kateqoriya)
        {
            var index = Mehsullar.FindAll(m => m.Kateqoriya == kateqoriya);

            return index.ToList();

        }
        public List<Mehsul> Mehsulun_Adagore_Tapilmas(string ad)
        {
            var index = Mehsullar.FindAll(m => m.Ad == ad);
            return index;

        }
        #endregion

        
        #region SATIS
        public void Satis_Elave_Etmek( int kod, int say)
        {
             
            int option = 0;
            Satis satis = new();
            Mehsul mehsul = Mehsullar.FirstOrDefault(s => s.Kod == kod);
            SatisItem satisItem = new(mehsul);
            mehsul.Say = mehsul.Say - say;
            satis.Mebleg += mehsul.Qiymet * say;
            satisItem.say += say;
            satis.Satisitemlar.Add(satisItem);



            do
            {
                Console.WriteLine("Basqa bir sey arzuluyursuz?");
                Console.WriteLine("1.He");
                Console.WriteLine("2.Yox");
                Console.WriteLine("Secim daxil edin");
                string optionstr = Console.ReadLine();
                while (!int.TryParse(optionstr, out option))
                {
                    Console.WriteLine("Reqem daxil edin");
                    optionstr = Console.ReadLine();
                }
                switch (option)
                {
                    case 1:
                        kod = int.Parse(Console.ReadLine());
                        say = int.Parse(Console.ReadLine());
                        mehsul = Mehsullar.FirstOrDefault(s => s.Kod ==kod);
                        satisItem = new(mehsul);
                        mehsul.Say = mehsul.Say - say;
                        satis.Mebleg += mehsul.Qiymet * say;
                        satis.Satisitemlar.Add(satisItem);
                        break;
                    case 2:
                        Console.WriteLine("satis elave olundu");
                        satislar.Add(satis);
                        break;
                }
            } while (option != 2);
        }

        public void Satisdan_Mehsulun_Qaytarilmasi(int nomre ,string ad, int say)
        {
            Mehsul mehsul = Mehsullar.FirstOrDefault(m => m.Ad == ad);
            Satis satis = satislar.FirstOrDefault(m => m.Nomre == nomre);
            SatisItem satisitem = satis.Satisitemlar.FirstOrDefault(m => m.say >= say);
            satislar.Remove(satis);
            satis.Satisitemlar.Remove(satisitem);
            mehsul.Say = mehsul.Say + say;
            satis.Mebleg -= mehsul.Qiymet * say;
            satisitem.say -= say;
        }

        public List<Satis> Satislarin_Qaytarilmasi()
        {
            
            return satislar;

        }

        public List<Satis> Zamana_gore_axdarilan_satislar(DateTime baslamavaxti, DateTime bitmevaxti)
        {
            var zaman = satislar.Where(m => m.Tarix >= baslamavaxti && m.Tarix <= bitmevaxti);
            return zaman.ToList();
        }

        public List<Satis> Mebglege_gore_satisin_qaytarilmasi(double baslaqiymet, double sonqiymet)
        {
            var index = satislar.FindAll(m => m.Mebleg >= baslaqiymet && m.Mebleg <= sonqiymet);
            return index;
        }

        public List<Satis> Zamana_gore_Satis_Qaytarilmasi(DateTime tarix)
        {
            var index = satislar.Where(m => m.Tarix.Month == tarix.Month && m.Tarix.Day == tarix.Day  && m.Tarix.Year == tarix.Year);
            return index.ToList();


        }

        public List<Satis> Nomreye_esasen_satisqaytarilmasi(int nomre)
        {
            var index = satislar.FindAll(m => m.Nomre == nomre);
            return index;
        }

        public void Satislarin_Silinmesi(int nomre)
        {
            Satis satis = new();
            int index = satislar.FindIndex(m => m.Nomre == nomre);
            satislar.RemoveAt(index);

        }


        #endregion

    }
}
