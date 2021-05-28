using FinalProject.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Data.Entities
{
   public  class SatisItem : BaseEntity
    {
        private static int count = 0;
        public Mehsul Mehsul { get; set; }
        public int say { get; set; }
        public SatisItem(Mehsul mehsul)
        {
            Mehsul = mehsul;
            count++;
            Nomre = count;
        }


    }
}
