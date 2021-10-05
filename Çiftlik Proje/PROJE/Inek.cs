using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE
{
    class Inek : Hayvan,IHayvan
    {
        public Inek()
        {

        }
        
        public int SutKg = 0;

        //public int SaniyeAl { get { return saniyeAl; } set { saniyeAl = value; } }
        //public int Cani { get { return cani; } set { cani = value; } }
        //public int urunAdet { get { return SutKg; } set { SutKg = value; } }
        //public int ToplamPara { get { return toplamPara; } set { toplamPara = value; } }

        public int Oldur()
        {
            if (cani > 4)
            {
                cani -= 8;
            }
            else cani = 0;
            return cani;
        }

        public int UrunAdet()
        {
            if (cani > 0 && saniyeAl > 0 && saniyeAl % 8 == 0)
            {
                SutKg++;
            }
            return SutKg;
        }

        public int Kasa()
        {
            toplamPara += SutKg * 5;
            SutKg = 0;
            return toplamPara;
        }

        
    }
}
