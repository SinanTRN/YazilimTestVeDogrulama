using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    public class SinavSorusu
    {
        public string yazdir(int a)
        {
            if (a % 15 == 0) return "Gumushane";
            else
            {
                if (a % 3 == 0) return "Gumus";
                else
                {
                    if (a % 5 == 0) return "hane";
                    else return a+"";
                }
            }
        }
    }
}
