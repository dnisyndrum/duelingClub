using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dueling_Club
{
    class Spell
    {
        const int rictusRange = 50;
        const int mimbleRange = 40;
        const int stupiRange = 60;

        public int Rictusempra()
        {
            Random rictusRandom = new Random();
            return rictusRandom.Next(rictusRange) + 1;
        }

        public int Mimblewimble()
        {
            Random mimbleRandom = new Random();
            return mimbleRandom.Next(mimbleRange) + 1;
        }

        public int Expelliarmus()
        {
            Random stupiRandom = new Random();
            return stupiRandom.Next(stupiRange) + 1;
        }

        public String TongueTwist(int selection)
        {
        
            int spell = 0;
            String badSpell = null;
            Random twisted = new Random();

            spell = twisted.Next(5) + 1;
            
        
                if(selection == 1)
                {
                    switch (spell)
                    {
                        case 1:
                            badSpell = "Rictusrictus!";
                            break;
                        case 2:
                            badSpell = "Emprarictus!";
                            break;
                        case 3:
                            badSpell = "Roctusompra!";
                            break;
                        case 4:
                            badSpell = "Rictus...something?";
                            break;
                        case 5:
                            badSpell = "Brictusempra!";
                            break;
                        case 6:
                            badSpell = "Ructusrumpra!";
                            break;
                    }
                }
                else if(selection == 2)
                {
                    switch (spell)
                    {
                        case 1:
                            badSpell = "MimblyWimbly!";
                            break;
                        case 2:
                            badSpell = "Midwib!";
                            break;
                        case 3:
                            badSpell = "Mibslywibsly!";
                            break;
                        case 4:
                            badSpell = "Wimblemimble!";
                            break;
                        case 5:
                            badSpell = "Wimble...eh, something?";
                            break;
                        case 6:
                            badSpell = "Womblemomble!";
                            break;
                    }
                }
                else if(selection == 3)
                {
                    switch (spell)
                    {
                        case 1:
                            badSpell = "Stupis Poopis!";
                            break;
                        case 2:
                            badSpell = "Stupifilio!";
                            break;
                        case 3:
                            badSpell = "Stupi...eh, I don't remember...";
                            break;
                        case 4:
                            badSpell = "Stupidstoop!";
                            break;
                        case 5:
                            badSpell = "Stompify!";
                            break;
                        case 6:
                            badSpell = "Stupisomething!";
                            break;
                    }
                }
          
                return badSpell;
            }


            

            
        }

    }

