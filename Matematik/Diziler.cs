using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    public class Diziler
    {
        public IEnumerable<int> tekSayi(int limit)
        {
            for (int i = 0; i <= limit; i++) if(i%2!=0) yield return i;
        }
    }
}
