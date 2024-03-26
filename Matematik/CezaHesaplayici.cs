using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    public class CezaHesaplayici
    {
        
        
        private const int hizSiniri=65;
        private const int MaxHiz=300;
        public int hesaplaCeza(int mevcutHiz)
        {
            const int CezaPuaniSabiti = 5;
            if (mevcutHiz < 0 || mevcutHiz > 300)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
               return mevcutHiz <=hizSiniri ? 0 :(mevcutHiz - hizSiniri) / CezaPuaniSabiti;
            }
        }
    }
}
