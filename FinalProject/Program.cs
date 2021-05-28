using FinalProject.Services;
using System;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;
            int a = 0;
            int b = 0;
            do
            {
                Console.WriteLine("============= IBRAAM MaRkET =============");

                Console.WriteLine("1.Mehsullar uzerinde emelliyat aparmaq");
                Console.WriteLine("2.Satislar uzerinde emelliyat aparmaq");
                Console.WriteLine("3.Sistemden cixmaq");
                Console.WriteLine("Hansi Proses ustunde emelliyat aparilsin?");
                Console.WriteLine("Reqem daxil edin");
                string selectionstr = Console.ReadLine();
                while (!int.TryParse(selectionstr, out selection))
                {
                    Console.WriteLine("Eded daxil edin");
                    selectionstr = Console.ReadLine();
                }

                switch (selection)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("1.Mehsul elave etmek");
                            Console.WriteLine("2.Mehsul uzerinde duzelis etmek");
                            Console.WriteLine("3.Mehsul sil");
                            Console.WriteLine("4.Butun Mehsullari gosterin");
                            Console.WriteLine("5.Kateqoriya gore mehsulu tapmaq");
                            Console.WriteLine("6.Qiymet araligina gore mehsul tapmaq");
                            Console.WriteLine("Mehsullar arasinda ada gore axdaris etmek");
                            Console.WriteLine("0.Sistemden cixis");
                            Console.WriteLine("Hansi emelliyat aparilmalidir?");
                            string str_a = Console.ReadLine();
                            while (!int.TryParse(str_a, out a ))
                            {
                                Console.WriteLine("Duzgun eded daxil edin");
                                str_a = Console.ReadLine();
                            }
                            switch (a)
                            {
                                case 1:
                                    MenuService.Mehsul_elave_olunmasi();
                                    break;
                                case 2:
                                    MenuService.Mehsul_Deyismek();
                                    break;
                                case 3:
                                    MenuService.Mehsul_Silmek();
                                    break;
                                case 4:
                                    MenuService.Umumi_mehsullar();
                                    break;
                                case 5:
                                    MenuService.KatiqoriyaGoster();
                                    break;
                                case 6:
                                    MenuService.Qiymet_araliginagore_MehsulTapmaq();
                                    break;
                                case 7:
                                    break;

                                default:
                                    break;
                            }
                            
                        } while (a != 0);
                        break;

                    case 2:
                        do
                        {
                            Console.WriteLine("1.Yeni satis elave etmek");
                            Console.WriteLine("2.Satisdaki mehsulun geri qaytarilmasi");
                            Console.WriteLine("3.Satisin silinmesi");
                            Console.WriteLine("4.Butun satislarin ekrana cixarilmasi");
                            Console.WriteLine("5.Verilen tarix araligina gore satislarin gosterilmesi");
                            Console.WriteLine("6.Verilen mebleg araligina gore satislarin gosterilmesi");
                            Console.WriteLine("7.Verilmis bir tarixde olan satislarin gosterilmesi");
                            Console.WriteLine("8.Verilmis nomreye esasen hemin nomreli satisin melumatlarin gosterilmesi");
                            Console.WriteLine("0.Sistemden cixis");
                            string str_b = Console.ReadLine();
                            while (!int.TryParse(str_b, out b))
                            {
                                Console.WriteLine("Duzgun eded daxil edin");
                                str_b = Console.ReadLine();
                            }

                            switch (b)
                            {
                                case 1:
                                    MenuService.Satis_Elave_Etmek();
                                    break;
                                case 2:
                                    MenuService.Satisdan_Mehsulun_Qaytarilmasi();
                                    break;
                                case 3:
                                    MenuService.Satis_Silinmesi();
                                    break;
                                case 4:
                                    MenuService.Satislarin_Qaytarilmasi();
                                    break;
                                case 5:
                                    MenuService.TarixeGore_SatisinQaytarilmasi();
                                    break;
                                case 6:
                                    MenuService.Mebglege_gore_satisin_qaytarilmasi();
                                    break;
                                case 7:
                                    MenuService.Zamana_Gore_Axdarilan_Satislar();
                                    break;
                                case 8:
                                    MenuService.Nomreye_Esasen_Satisqaytarilmasi();
                                    break;
                                default:
                                    break;
                            }


                        } while (b !=0);
                        break;
                    default:
                        break;
                }


            } while (selection != 3);

            
           
        }
    }
}
