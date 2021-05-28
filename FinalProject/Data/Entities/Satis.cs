using FinalProject.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Data.Entities
{
   public class Satis:BaseEntity
    {
        private static int count = 0;
        public double Mebleg { get; set; }
        public DateTime Tarix { get; set; }
        public List<SatisItem> Satisitemlar { get; set; }
        

        public Satis()
        {
            Tarix = DateTime.Now;
            Satisitemlar = new();
            count++;
            Nomre = count;
        }
    }
}
