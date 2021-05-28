using FinalProject.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Data.Entities
{
    enum Katiqoriya
    {
        Kolbasa,
        Et_memulatlari,
        Sud_mehsullari,
        Terevez,
        Qelyanalti,
        Souslar
    }
    public class Mehsul: BaseEntity
    {
     private static int count = 1000;
        public string Ad { get; set; }
        public double Qiymet { get; set; }
        public string Kateqoriya { get; set; }

       public Mehsul()
        {
            count++;
            Kod = count;
        }

    }
}
