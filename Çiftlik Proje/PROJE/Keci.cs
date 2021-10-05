using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE
{
    class Keci : Hayvan, IHayvan
    {
        public Keci()
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
                cani -= 6;
            }
            else cani = 0;
            return cani;
        }

        public int UrunAdet()
        {
            if (cani > 0 && saniyeAl > 0 && saniyeAl % 7 == 0)
            {
                SutKg++;
            }
            return SutKg;
        }

        public int Kasa()
        {
            toplamPara += SutKg * 8;
            SutKg = 0;
            return toplamPara;
        }

        
    }
}
