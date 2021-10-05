using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE
{
    class Tavuk : Hayvan, IHayvan
    {
        public Tavuk()
        {

        }
        public int YumurtaAdet = 0;

        public int Oldur()
        {
            if (cani > 2)
            {
                cani -= 2;
            }
            else cani = 0;
            return cani;
        }

        public int UrunAdet()
        {
            if (cani > 0 && saniyeAl > 0 && saniyeAl % 3 == 0)
            {
                YumurtaAdet++;
            }
            return YumurtaAdet;
        }

        public int Kasa()
        {
            toplamPara += YumurtaAdet * 1;
            YumurtaAdet = 0;
            return toplamPara;

        }

    }
}
