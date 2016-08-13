using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dueling_Club
{
    class HitMiss
    {
        public bool Hit()
        {
            bool hit = false;
            int range = 100;
            int outcome = 0;

            Random hitOrMiss = new Random();
            outcome = hitOrMiss.Next(range) + 1;

            if(outcome > 33 || outcome == 7)
            {
                hit = true;
            }
            
            return hit;
        }

    }
}
