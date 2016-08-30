using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Dueling_Club
{
    class DuelingClub
    {

        static void Main(string[] args)
        {
            int beansLeft = 100;
            int beansToWager = 0;
            bool duelAgain = true;
            bool duelWon = false;
            FrontEnd Logo = new FrontEnd();

            //play opening music
            //System.Media.SoundPlayer dueling = new System.Media.SoundPlayer();
            //dueling.SoundLocation = "dueling.wav";
            //System.Media.SoundPlayer intro = new System.Media.SoundPlayer();
            //intro.SoundLocation = "intro.wav";
            //System.Media.SoundPlayer win = new System.Media.SoundPlayer();
            //win.SoundLocation = "win.wav";
            //System.Media.SoundPlayer lose = new System.Media.SoundPlayer();
            //lose.SoundLocation = "lose.wav";
            
            //intro.PlayLooping();

            //show harry potter logo screen
            Console.WriteLine("       __     __        __        _________    _________    ___    ___       ");
            Thread.Sleep(100);
            Console.WriteLine("      |  |   |  |      |  |      |   ___   |  |   ___   |  |   |  |   |      ");
            Thread.Sleep(100);
            Console.WriteLine("      |  |   |  |     |    |     |  |   |  |  |  |   |  |  |   |  |   |      ");
            Thread.Sleep(100);
            Console.WriteLine("      |  |___|  |    |  __  |    |  |___|  |  |  |___|  |  |   |__|   |      ");
            Thread.Sleep(100);
            Console.WriteLine("      |   ___   |   |  |__|  |   |       __|  |       __|  |___    ___|      ");
            Thread.Sleep(100);
            Console.WriteLine("      |  |   |  |  |   ____   |  |   _  |     |   _  |         |  |          ");
            Thread.Sleep(100);
            Console.WriteLine("      |  |   |  |  |  |    |  |  |  | |  |_   |  | |  |_       |  |          ");
            Thread.Sleep(100);
            Console.WriteLine("      |__|   |__|  |__|    |__|  |__|  |___|  |__|  |___|      |__|          ");
            Thread.Sleep(100);
            Console.WriteLine("   _________   __________   __________   __________   _________    __________");
            Thread.Sleep(100);
            Console.WriteLine("  |   ___   | |   ____   | |___    ___| |___    ___| |   ______|  |   ____   |");
            Thread.Sleep(100);
            Console.WriteLine("  |  |   |  | |  |    |  |     |  |         |  |     |  |         |  |    |  |");
            Thread.Sleep(100);
            Console.WriteLine("  |  |___|  | |  |    |  |     |  |         |  |     |  |_____    |  |____|  |");
            Thread.Sleep(100);
            Console.WriteLine("  |   ______| |  |    |  |     |  |         |  |     |   _____|   |   __   __|");
            Thread.Sleep(100);
            Console.WriteLine("  |  |        |  |    |  |     |  |         |  |     |  |         |  |  | |   ");
            Thread.Sleep(100);
            Console.WriteLine("  |  |        |  |____|  |     |  |         |  |     |  |_____    |  |   | |_ ");
            Thread.Sleep(100);
            Console.WriteLine("  |__|        |__________|     |__|         |__|     |________|   |__|    |__|");
            Thread.Sleep(100);
            Console.WriteLine();
            Console.WriteLine("                                 DUELING CLUB                                  ");


            Thread.Sleep(5000);
            Console.Clear();

            Console.WriteLine("Can you all see me? Can you all hear me? Excellent!");
            Console.WriteLine();
            Thread.Sleep(1500);
            Console.WriteLine("Welcome to Dueling Club. Dueling Club meets each Saturday at noon in");
            Console.WriteLine("the anti-chamber just outside the Great Hall. Each duelist will have 100");
            Console.WriteLine("health points at the start of each duel. Each witch or wizard must"); 
            Console.WriteLine("successfully deplete their opponent's health points to win the duel.");
            Console.WriteLine();
            Thread.Sleep(1500);
            Console.WriteLine("You may use three spells during a duel:");
            Console.WriteLine("-Rictusempra- To inflict direct damage to your opponent's health points");
            Console.WriteLine("-Mimblewinble- To twist your opponent's tongue on their next spell");
            Console.WriteLine("-Stupify- To stun your opponent and soften the blow of their next spell ");
            Console.WriteLine();
            Thread.Sleep(1500);
            Console.WriteLine("Jumping and potion drinking are prohibited.");
            Console.WriteLine();
            Thread.Sleep(1500);
            Console.WriteLine("Each round you may wager up to as many Berty Bott's Every-Flavor beans as you");
            Console.WriteLine("have remaining. Your opponent will wager the same number of beans. Winner takes");
            Console.WriteLine("the entire pot!");

            Thread.Sleep(3000);

            do
            {
                //prompt wizard to wager a number of beans
                beansToWager = Wager(beansLeft);

                Console.WriteLine("Ready?");
                Thread.Sleep(1000);
                Console.WriteLine("1...");
                Thread.Sleep(1000);
                Console.WriteLine("2...");
                Thread.Sleep(1000);
                Console.WriteLine("3...");
                Thread.Sleep(1000);
                Console.WriteLine("Duel!");
                Thread.Sleep(1000);
                Console.WriteLine();

                //intro.Stop();
                //dueling.PlayLooping();

                //if the duel is won, true is returned, else false is returned
                duelWon = Duel();
                //dueling.Stop();

                //if you won the duel
                if(duelWon == true)
                {
                    //add the number of beans you wagered to the total number of beans left
                    //win.Play();
                    beansLeft += beansToWager;
                    Console.WriteLine("Congratulations! You won the duel!");
                    Console.WriteLine("You added " + beansToWager + " to your bean collection.");
                    Console.WriteLine("You now have " + beansLeft + " Berty Bott's Every Flavor Beans.");
                }
                else
                {
                    //else subtract that amount
                    //lose.Play();
                    beansLeft -= beansToWager;
                    if(beansLeft < 0)
                    {
                        beansLeft = 0;
                    }
                    Console.WriteLine("Sorry, you lost the duel.");
                    Console.WriteLine(beansToWager + " were deducted from your bean collection.");
                    Console.WriteLine("You now have " + beansLeft + " Berty Bott's Every Flavor Beans.");
                }

                if(beansLeft > 0)
                {
                    //ask wizard if he wants to duel again
                    duelAgain = playAgain();
                }
                else
                {
                    Console.WriteLine("You are out of beans to wager. \nCome back with more beans next time Dueling Club meets!");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadLine();                             //user may press any key to exit program
                    Exit();                                         //runs exit method
                }

            }
            //if wizard wants to duel again, duelAgain is set to "true"
            while (duelAgain == true);

        }

        public static bool Duel()
        {
            int yourHealth = 100;
            int opponentHealth = 100;
            const bool duelWon = true;
            const bool duelLost = false;
            int spellSelected = 1;
            int spellCast = 1;
            int damage = 1;
            bool yourHit = false;
            bool opponentHit = false;
            bool mimbleOpponent = false;
            bool mimbleYou = false;
            bool stupiYou = false;
            bool stupiOpponent = false;
            bool keepGoing = true;
            String yourSpellCast = null;
            Spell duel = new Spell();
            HitMiss hitOrMiss = new HitMiss();
            opponentSpellSelect opponentSelect = new opponentSpellSelect();
            youSpellSelect youSelect = new youSpellSelect();

            do
            {
                //your cast
                if(yourHealth > 0 && opponentHealth > 0)
                {

                    //ask user to select a spell, returns 1, 2, or 3
                    Thread.Sleep(1500);
                    spellSelected = youSelect.Select();
                    spellCast = spellSelected;
 
                    //if opponent used mimblewinble, mimbleYou is set to true and overrides user spell selection
                    if (mimbleYou == true && opponentHit == true)
                    {
                        spellCast = 4;
                    }

                    //a different spell is selected depending on 
                    switch (spellCast)
                    {
                        case 1:
                            damage = duel.Rictusempra();            //returns randomized damage amount from Spell class
                            yourSpellCast = "Rictusempra";          //to inform user of the spell they selected
                            break;
                        case 2:
                            damage = duel.Mimblewimble();
                            yourSpellCast = "Mimblewimble";
                            
                            break;
                        case 3:
                            damage = duel.Expelliarmus();
                            yourSpellCast = "Stupify";
                            stupiOpponent = true;
                            break;
                        case 4:
                            yourSpellCast = duel.TongueTwist(spellSelected);
                            damage = 0;                             //no damage is done when user is tongue-tied
                            break;
                    }

                    //inform user of the spell selected
                    Thread.Sleep(1500);
                    Console.WriteLine("Your spell cast: " + yourSpellCast);

                    //randomly determine whether your spell cast was a hit or miss
                    if (mimbleYou == true)
                    {
                        yourHit = false;
                    }
                    else
                    {
                        yourHit = hitOrMiss.Hit();
                        if (yourHit == true && spellCast == 2)
                        {
                            mimbleOpponent = true;                  //when mimblewimble is selected, your opponent is tongue-tied
                        }
                        else
                        {
                            mimbleOpponent = false;
                        }
                    }

                    if(stupiYou == true && opponentHit == true)
                    {
                        damage = damage / 2;
                        Thread.Sleep(1500);
                        Console.WriteLine("Because you were stunned by stupify, your spell damage was decreased.");
                    }

                    //if the spell is a hit, damage is deducted from opponent health, else damage is 0 due to a miss
                    if (mimbleYou != true)
                    {
                        if (yourHit == true)
                        {
                            Thread.Sleep(1500);
                            Console.WriteLine("Your spell hit!");
                            Console.WriteLine();
                            opponentHealth -= damage;
                        }
                        else
                        {
                            Thread.Sleep(1500);
                            Console.WriteLine("Your spell missed...");
                            Console.WriteLine();
                            damage = 0;
                        }

                        if(yourHealth < 0)
                        {
                            yourHealth = 0;
                        }
                        else if(opponentHealth < 0)
                        {
                            opponentHealth = 0;
                        }

                    }
                    else if (mimbleYou == true)
                    {
                        Thread.Sleep(1500);
                        Console.WriteLine("You tried to cast a spell while tongue-tied.");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    else
                    {
                         if(yourHit == true)
                         {
                             Thread.Sleep(1500);
                             Console.WriteLine("Your spell was a hit!");
                             Console.WriteLine();
                             Console.WriteLine();
                         }
                         else
                         {
                             Thread.Sleep(1500);
                             Console.WriteLine("Your spell was a miss...");
                             Console.WriteLine();
                             Console.WriteLine();
                         }
                    }

                    //reset fields at end of each cast
                    spellCast = 1;
                    damage = 1;
                    mimbleYou = false;
                    opponentHit = false;
                    stupiYou = false;
                    
                }

                //opponent cast
                if(opponentHealth > 0 && yourHealth > 0)
                {

                    //allow opponent to select a spell
                    spellSelected = opponentSelect.spellSelect(opponentHealth);
                    spellCast = spellSelected;

                    //if user used mimblewimble and is a hit, mimbleopponent is set to true
                    if (mimbleOpponent == true && yourHit == true)
                    {
                        spellCast = 4;
                    }

                    //spell is selected depending on opponents choice
                    switch (spellCast)
                    {
                        case 1:
                            damage = duel.Rictusempra();            //returns randomized damage amount from Spell class
                            yourSpellCast = "Rictusempra";          //to inform user of the spell they selected
                            break;
                        case 2:
                            damage = duel.Mimblewimble();
                            yourSpellCast = "Mimblewimble";
                            
                            break;
                        case 3:
                            damage = duel.Expelliarmus();
                            yourSpellCast = "Stupify";
                            stupiYou = true;
                            break;
                        case 4:
                            yourSpellCast = duel.TongueTwist(spellSelected);
                            damage = 0;                             //no damage is done when user is tongue-tied
                            break;
                    }

                    //inform user of the spell selected
                    Thread.Sleep(1500);
                    Console.WriteLine("Opponent's spell cast: " + yourSpellCast);

                    //use HitMiss class too determine if the spell was a hit or miss
                    if (mimbleOpponent == true)
                    {
                        opponentHit = false;
                    }
                    else
                    {
                        opponentHit = hitOrMiss.Hit();
                        if(opponentHit == true && spellCast == 2)
                        {
                            mimbleYou = true;                  //when mimblewimble is selected, your opponent is tongue-tied
                        }
                        else
                        {
                            mimbleYou = false;
                        }
                    }

                    if (stupiOpponent == true && yourHit == true)
                    {
                        damage = damage / 2;
                        Thread.Sleep(1500);
                        Console.WriteLine("Because opponent was stunned by stupify, opponent's spell damage was decreased.");
                    }

                    //if the spell is a hit, damage is deducted from opponent health, else damage is 0 due to a miss
                    if (mimbleOpponent != true)
                    {
                        if (opponentHit == true)
                        {
                            Thread.Sleep(1500);
                            Console.WriteLine("Opponent's spell hit! Ouch!");
                            Console.WriteLine();
                            Console.WriteLine();
                            yourHealth -= damage;
                        }
                        else
                        {
                            Thread.Sleep(1500);
                            Console.WriteLine("Opponent's spell missed!");
                            Console.WriteLine();
                            Console.WriteLine();
                            damage = 0;
                        }
                    }
                    else
                    {
                        Thread.Sleep(1500);
                        Console.WriteLine("Opponent tried to cast a spell while tongue-tied.");
                        Console.WriteLine();
                        Console.WriteLine();
                    }

                    if (yourHealth < 0)
                    {
                        yourHealth = 0;
                    }
                    else if (opponentHealth < 0)
                    {
                        opponentHealth = 0;
                    }

                    //inform user of current health and opponent health
                    Thread.Sleep(1500);
                    Console.WriteLine("Your health:       " + yourHealth);
                    Console.WriteLine("Opponent's health: " + opponentHealth);
                    Console.WriteLine();
                    Console.WriteLine();

                    //reset fields at end of each cast
                    spellCast = 1;
                    damage = 1;
                    mimbleOpponent = false;
                    yourHit = false;
                    stupiOpponent = false;
                }

                if(opponentHealth == 0 || yourHealth == 0)
                {
                    keepGoing = false;
                }

            }
            while (keepGoing == true);

            //if your health is less than or equal to 0, return duelLost, else return duelWon
            if(yourHealth == 0)
            {
                return duelLost;
            }
            else
            {
                return duelWon;
            }

        }

        public static int Wager(int beansLeft)
        {
            int beansToWager = 0;
            bool goodToGo = false;

            while(!goodToGo)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("You have " + beansLeft + " beans left.");
                    Console.WriteLine("Please enter a number of beans you wish to wager for this duel:");
                    beansToWager = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("That is not a valid number of beans to wager. \nPlease enter how many means you would like to wager: ");
                    Console.WriteLine();
                    beansToWager = -1;
                }

                if (beansToWager > beansLeft)
                {
                    Console.WriteLine("You do not have that many Berty Bott's beans left.");
                    Console.WriteLine();
                }
                else if ((beansToWager <= beansLeft) && (beansToWager > 0))
                {
                    Console.WriteLine("You have wagered " + beansToWager + " Berty Bott's beans.");
                    goodToGo = true;
                    Console.WriteLine();
                }
                
            }

            return beansToWager;

        }

        public static bool playAgain()
        {
            bool goodToGo = false;
            bool duelAgain = true;
            const char play = 'y';
            char answer = 'y';

            while (goodToGo == false)
            {
                Console.WriteLine("Would you like to duel again (y/n)?");
                try
                {
                    answer = Convert.ToChar(Console.ReadLine().ToLower());
                }
                catch
                {
                    Console.WriteLine("Please enter 'y' to play again or 'n' to leave Dueling Club.");
                }

                if (answer.Equals(play))
                {
                    duelAgain = true;
                    goodToGo = true;
                }
                else
                {
                    goodToGo = true;
                    duelAgain = false;
                }
            }
            return duelAgain;
        }

        public static void Exit()
        {
            System.Environment.Exit(1);
        }

    }

    

}
