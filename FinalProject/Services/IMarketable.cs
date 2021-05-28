using FinalProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Services
{
   public interface  IMarketable
    {

       

        #region MEHSUL
        public static void Mehsul_Yuklemek(string ad, double qiymet, int kod, string kateqoriya, int say)
        {
            

        }
        public static void Mehsul_Deyismek(string ad, double qiymet, int kod, string kateqoriya, int say)
        {
           

        }
        public static void Mehsul_Silmek(int kod)
        {
            
        }
         
       
        public static void Qiymet_Araliginda_Mehsul_Tapilmasi(double ilkqiymet, double sonqiymet)
        {
           
        }
        public static void Kateqoriyaya_Gore_Mehsul_Tapmaq( string kateqoriya)
        {
           

        }
        public static void Mehsulun_Adagore_Tapilmas(string ad)
        {
            

        }
        #endregion

        #region SATIS
        public void Satis_Elave_Etmek(string ad, int say, double mebleg)
        {

        }

        public void Satisdan_Mehsulun_Qaytarilmasi(string ad, int say)
        {
            
        }

        public void Satislarin_Qaytarilmasi()
        {
           

        }

        public void Zamana_gore_axdarilan_satislar(DateTime baslamavaxti, DateTime bitmevaxti)
        {
            
        }

        public void Mebglege_gore_satisin_qaytarilmasi(double baslaqiymet, double sonqiymet)
        {
           
        }

        public void Nomreye_esasen_satisqaytarilmasi(int nomre)
        {
            
        }

        public void  Zamana_gore_Satis_Qaytarilmasi(DateTime tarix)
        {

        }
        #endregion


    }
}   
