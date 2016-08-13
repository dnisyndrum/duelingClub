using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dueling_Club
{
    class youSpellSelect
    {

        public int Select()
        {
            int spellCast = 0;
            bool goodToGo = false;

            while (goodToGo == false)
            {
                //ask for user inpot to select spell
                Console.WriteLine("Select a spell to use (1, 2, 3)");
                Console.WriteLine("1 - Rictusempra");
                Console.WriteLine("2 - Mimblewimble");
                Console.WriteLine("3 - Stupify");

                //user can only select 1, 2, or 3, else the loop continues
                try
                {
                    spellCast = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    //if the input cannot be converted to an int, set spellCast to 0
                    spellCast = 0;
                }
                finally
                {
                    //if the spellCast does not equal one of the three spells, loop around and inform user
                    if (spellCast == 1 || spellCast == 2 || spellCast == 3)
                    {
                        Console.WriteLine();
                        //goodToGo is set to true to break out of the loop
                        goodToGo = true;
                    }
                    else
                    {
                        //Thread.Sleep(1000);
                        Console.WriteLine("Invalid spell selection!");
                        Console.WriteLine();
                    }
                }

            }
            goodToGo = false;

            return spellCast;

        }
    }
}