using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE
{
    class Hayvan
    {
        protected int saniyeAl = 0;
        protected int cani = 0;
        protected int toplamPara = 0;
        public bool Canlilik = true;

        public int SaniyeAl { get { return saniyeAl; } set { saniyeAl = value; } }
        public int Cani { get { return cani; } set { cani = value; } }
        public int ToplamPara { get { return toplamPara; } set { toplamPara = value; } }
    }
}
