using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dueling_Club
{
    class opponentSpellSelect
    {
        public int spellSelect(int opponentHealth)
        {
            Random random1 = new Random();
            int selectedSpell = 0;
            int random = 0;

            if(opponentHealth > 90)
            {
                selectedSpell = random1.Next(3);
            }
            else if (opponentHealth > 89 || opponentHealth < 70)
            {
                random = random1.Next(3);
                if(random == 1 || random == 3)
                {
                    selectedSpell = 3;
                }
                else
                {
                    selectedSpell = 2;
                }
            }
            else if (opponentHealth > 69 || opponentHealth < 40)
            {
                selectedSpell = random1.Next(3);
            }
            else if (opponentHealth > 39 || opponentHealth < 30)
            {
                selectedSpell = 3;
            }
            else
            {
                selectedSpell = 1;
            }

            return selectedSpell;
        }

    }
}
