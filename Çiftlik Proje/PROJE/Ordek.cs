using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE
{
    class Ordek : Hayvan, IHayvan
    {
        public Ordek()
        {

        }
        public int OYumurtaAdet = 0;

       // public int SaniyeAl { get { return saniyeAl; } set { saniyeAl = value; } }
        //public int Cani { get { return cani; } set { cani = value; } }
        //public int urunAdet { get { return OYumurtaAdet; } set { OYumurtaAdet = value; } }
        //public int ToplamPara { get { return toplamPara; } set { toplamPara = value; } }

        public int Oldur()
        {
            if (cani > 3)
            {
                cani -= 3;
            }
            else cani = 0;
            return cani;
        }

        public int UrunAdet()
        {
            if (cani > 0 && saniyeAl > 0 && saniyeAl % 5 == 0)
            {
                OYumurtaAdet++;
            }
            return OYumurtaAdet;
        }


        public int Kasa()
        {
            toplamPara += OYumurtaAdet * 3;
            OYumurtaAdet = 0;
            return toplamPara;
        }

        
    }
}
