using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udvidet_Random
{
    class UdvidetRandom : Random
    {
        public bool NextBool()
        {
            return this.Next(1, 1002) < 500;
        }

    }
}
