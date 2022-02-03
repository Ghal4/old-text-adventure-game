using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//the english here is a little wanky though, since I approximately made this program about a few years ago

namespace ConsoleApp4
{
    class Program
    {
        static string UserInput;
        static string CharcterGender_he_she;
        static string CharcterGender_him_her;
        static string CharcterName;
        static string CharcterRace;
        //
        static string DayNightCycle = "day";
        //
        static int JailWarning1 = 0;
        static int Hunger = 50;
        static int GameAdventureNumber;
        static int Gold;
        static int BigFood;
        static int SmallFood;
        static int knife;
        static int unknown_berrys;
        static int map;
        static bool Bag;


        //**
        static int X20;
        static int X4;
        //**

        static void inventory()
        {
            while (true)
            {
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("gold: " + Gold);
                Console.WriteLine("big food: " + BigFood);
                Console.WriteLine("small food: " + SmallFood);
                Console.WriteLine("hunger: " + Hunger + " out of 50");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("write a specific item for more info / back");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                UserInput = Console.ReadLine();
                Console.BackgroundColor = ConsoleColor.Black;
                switch (UserInput)
                {
                    case "gold":
                        Console.WriteLine("gold is like money. it have diffrent value and you can buy and trade things with in or for it.");
                        break;

                    case "big food":
                        Console.WriteLine("big sorce of food. chicken, big amount of rice. you wont be hungry after eating one.");
                        Console.WriteLine("eat big food?                  [yes/no]");
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        UserInput = Console.ReadLine();
                        Console.BackgroundColor = ConsoleColor.Black;
                        if (UserInput == "yes")
                        {
                            if (BigFood > 0)
                            {
                                Hunger += 20;
                                BigFood -= 1;
                                Console.WriteLine("yum! your hunger is now: " + Hunger + " out of 50");
                                Console.WriteLine("and you have " + BigFood + " big food left");


                            }
                            else
                            {
                                Console.WriteLine("you don't have any more big food");

                            }
                        }
                        break;

                    case "small food":

                        Console.WriteLine("more like snack, some berrys, apple or a bit of dry meat. good for filling you for a short time untill you find big food");
                        Console.WriteLine("eat small food?                  [yes/no]");
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        UserInput = Console.ReadLine();
                        Console.BackgroundColor = ConsoleColor.Black;

                        if (UserInput == "yes")
                        {
                            if (SmallFood > 0)
                            {
                                Hunger += 5;
                                SmallFood -= 1;
                                Console.WriteLine("yum! your hunger is now: " + Hunger + " out of 50");

                            }
                            else
                            {
                                Console.WriteLine("you don't have any more small food");

                            }
                        }
                        break;



                    case "hunger":

                        Console.WriteLine("well, its not an item but sure something you'd like to know. if you are too hungry you will no be able to " +
                            "to hard phisical work. you will lose some hunger apon phisical actions and waiting time. your maximus hinger is 50.");
                        break;
                    case "back":
                        return;
                        
                    default:
                        Console.WriteLine("this is not an option");
                        break;
                }
            }


        }
        static void Main(string[] args)            //////start///////
        {
            Console.WriteLine("Hello and welcome to ______");
            Console.WriteLine("you'll now create a new charcter");
            Console.WriteLine("will it be a boy or a girl?             [boy/girl]");
            
            
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                UserInput = Console.ReadLine();
                Console.BackgroundColor = ConsoleColor.Black;
                if (UserInput == "boy")
                {
                    CharcterGender_he_she = "he";
                    CharcterGender_him_her = "him";
                    break;
                }
                else if (UserInput == "girl")
                {
                    CharcterGender_he_she = "she";
                    CharcterGender_him_her = "her";
                    break;
                }
                else
                {
                    Console.WriteLine("sorry that is not an option");

                }
            }
            Console.WriteLine("now you will need to choose a race for " + CharcterGender_him_her);
            while (true)
            {
                Console.WriteLine("your option's are: human, elf, dwarf or *other*");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                UserInput = Console.ReadLine();
                Console.BackgroundColor = ConsoleColor.Black;
                if (UserInput == "human")
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("humans are the youngest of the common races, late to arrive on the world scene" +
                        " and short-lived in comparison to dwarves and elves. Perhaps it is because of their shorter lives that they strive to" +
                        " achieve as much as they can in the years they are given. Or maybe they feel they have something to prove to the elder races." +
                        "Whatever drives them," +
                        " humans are the innovators, the achievers, and the pioneers of the worlds.");
                    Console.BackgroundColor = ConsoleColor.Black;
                Race1:
                    Console.WriteLine("does this sound good to you?                 [yes = pick /no = back");
                    UserInput = Console.ReadLine();
                    if (UserInput == "no")
                    {
                        ;
                    }
                    else if (UserInput == "yes")
                    {
                        CharcterRace = "human";

                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("With their penchant for migration and conquest, humans are more physically diverse than other common races. " +
                            "There is no typical human. An individual can stand from 5 feet to a little over 6 feet tall and weigh from 125 to 250 pounds. " +
                            "Human skin shades range from nearly black to very pale, and hair colors from black to blond " +
                            "(curly, kinky, or straight); males might sport facial hair that is sparse or thick. A lot of humans have a dash of nonhuman blood, " +
                            "revealing hints of elf, orc, or other lineages. Humans reach adulthood in their late teens and rarely live even a single century.");
                        Console.BackgroundColor = ConsoleColor.Black;

                        break;
                    }
                    else
                    {
                        Console.WriteLine("sorry that is not an option");
                        goto Race1;
                    }
                }
                else if (UserInput == "elf")
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Elves are a magical people of otherworldly grace, living in the world but not entirely part of it. " +
                        "They live in places of ethereal beauty, in the midst of ancient forests or in silvery spires glittering with faerie light, " +
                        "where soft music drifts through the air and gentle fragrances waft on the breeze. " +
                        "Elves love nature and magic, art and artistry, music and poetry, and the good things of the world.");
                    Console.BackgroundColor = ConsoleColor.Black;
                Race2:
                    Console.WriteLine("does this sound good to you?                 [yes = pick /no = back");
                    UserInput = Console.ReadLine();
                    if (UserInput == "no")
                    {
                        ;
                    }
                    else if (UserInput == "yes")
                    {
                        CharcterRace = "elf";

                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("With their unearthly grace and fine features, elves appear hauntingly beautiful to humans and members of many other races. " +
                            "They are slightly shorter than humans on average, ranging from well under 5 feet tall to just over 6 feet. " +
                            "They are more slender than humans, weighing only 100 to 145 pounds. " +
                            "Males and females are about the same height, and males are only marginally heavier than females.");
                        Console.WriteLine();
                        Console.WriteLine("Elves’ coloration encompasses the normal human range and also includes skin in shades of copper, " +
                            "bronze, and almost bluish - white, hair of green or blue, " +
                            "and eyes like pools of liquid gold or silver.Elves have no facial and little body hair. " +
                            "They favor elegant clothing in bright colors, and they enjoy simple yet lovely jewelry.");
                        Console.BackgroundColor = ConsoleColor.Black;

                        break;
                    }
                    else
                    {
                        Console.WriteLine("sorry that is not an option");
                        goto Race2;
                    }
                }


                else if (UserInput == "dwarf")
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Kingdoms rich in ancient grandeur, halls carved into the roots of mountains, the echoing of picks and hammers " +
                        "in deep mines and blazing forges, a commitment to clan and tradition, and a burning hatred of goblins and orcs—these common threads " +
                        "unite all dwarves.");
                    Console.BackgroundColor = ConsoleColor.Black;
                Race3:
                    Console.WriteLine("does this sound good to you?                 [yes = pick /no = back");
                    UserInput = Console.ReadLine();
                    if (UserInput == "no")
                    {
                        ;
                    }
                    else if (UserInput == "yes")
                    {
                        CharcterRace = "dwarf";

                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Bold and hardy, dwarves are known as skilled warriors, miners, and workers of stone and metal. " +
                            "Though they stand well under 5 feet tall, dwarves are so broad and compact that they can weigh as much as a human standing nearly two feet taller. " +
                            "Their courage and endurance are also easily a match for any of the larger folk.");
                        Console.WriteLine();
                        Console.WriteLine("Dwarven skin ranges from deep brown to a paler hue tinged with red, but the most common shades are light brown or deep tan, " +
                            "like certain tones of earth.Their hair, worn long but in simple styles, is usually black, gray, or brown, " +
                            "though paler dwarves often have red hair.Male dwarves value their beards highly and groom them carefully.");
                        Console.BackgroundColor = ConsoleColor.Black;

                        break;
                    }
                    else
                    {
                        Console.WriteLine("sorry that is not an option");
                        goto Race3;
                    }
                }

                else if (UserInput == "other")
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("worning: 'other' is unstable. its random and you may get one of the three other options or other races not mentioned");
                    Console.WriteLine(" above. could be both good and bad. only for the expert");
                    Console.BackgroundColor = ConsoleColor.Black;
                Race4:
                    Console.WriteLine("does this sound good to you?                 [yes = pick /no = back]");
                    UserInput = Console.ReadLine();
                    if (UserInput == "no")
                    {
                        ;
                    }
                    else if (UserInput == "yes")
                    {

                        //random ---->
                        Random rnd = new Random();
                        string[] charcterRaceRandom = { "human", "elf", "dwarf", "dragonborn", "aarakocra" };
                        int CRR_Index = rnd.Next(charcterRaceRandom.Length);
                        CharcterRace = charcterRaceRandom[CRR_Index];
                        //random <----

                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("");
                        Console.BackgroundColor = ConsoleColor.Black;

                        break;
                    }
                    else
                    {
                        Console.WriteLine("sorry this is not an option");
                        goto Race4;
                    }
                }

                else
                {
                    Console.WriteLine("sorry that is not an option");

                }
            }
            while (true)
            {
                Console.WriteLine("choose a name for your " + CharcterRace + ". choose wisely as it can't be changed later and remember to" +
                " use capital letter");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                CharcterName = Console.ReadLine();

                Console.BackgroundColor = ConsoleColor.DarkCyan;
            do_you_want_to_keep:
                Console.WriteLine("you chose: " + CharcterName + " - do you want to keep the name?                 [yes/no]");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                UserInput = Console.ReadLine();
                Console.BackgroundColor = ConsoleColor.Black;
                if (UserInput == "no")
                {
                    ;
                }
                else if (UserInput == "yes")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("sorry that is not an option");
                    goto do_you_want_to_keep;
                }
            }
            Console.WriteLine("wait a moment...      generating inventory");

            System.Threading.Thread.Sleep(2000);
            //random numbers
            Random rand = new Random();
            GameAdventureNumber = rand.Next(1, 1);

            System.Threading.Thread.Sleep(1000);   //sleep 1 sec

            Console.BackgroundColor = ConsoleColor.DarkYellow;

            Gold = rand.Next(5, 18);
            Console.WriteLine("gold: " + Gold);

            System.Threading.Thread.Sleep(1000);

            BigFood = rand.Next(0, 4);
            Console.WriteLine("big food:" + BigFood);

            System.Threading.Thread.Sleep(1000);

            SmallFood = rand.Next(0, 4);
            Console.WriteLine("small food:" + SmallFood);

            Hunger = rand.Next(15, 45);
            Console.WriteLine("hunger:" + Hunger + " out of 50");

            //later tools jail escape run away////
            knife = rand.Next(0, 1);
            unknown_berrys = rand.Next(0, 8);
            map = rand.Next(0, 1);
            //////////////////////////////////////

            System.Threading.Thread.Sleep(1000);


            X20 = rand.Next(0, 20);

            X4 = rand.Next(0, 4);

            Console.BackgroundColor = ConsoleColor.Black;

            System.Threading.Thread.Sleep(1000);
            //random numbers

            //START
            //OF
            //GAME

            //game1
            if (GameAdventureNumber == 1)

            {
                Console.WriteLine("Wellcome " + CharcterName + " to _____ !!");
                Console.WriteLine("you wake up dizzy, laying on a wooden bed. not remembering much from the past on how and when you got here.");
                while (true)      //////while - jail cell ///////
                {
                    Console.WriteLine("you look around... and see nothing but a desk with a sheet of paper on it, a chair and heavy metal bars filling one wall in this room");

                    Console.WriteLine(" [wait,look at, sleep, inventory]");

                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    UserInput = Console.ReadLine();
                    Console.BackgroundColor = ConsoleColor.Black;
                    if (UserInput == "look at paper" || UserInput == "look at papers")
                    {
                        Console.WriteLine("you take the paper and see a drawing of you and on the bottom of the page '' " + CharcterName + "  -  criminal 00713");
                    }
                    else if (UserInput == "look at desk")

                    {
                        Console.WriteLine("you see a paper on the desk");
                    }
                    else if (UserInput == "look at bars" || UserInput == "look at door")
                    {
                        Console.WriteLine("you see another metal bars door in front of after the hall between them. nothing more than that");
                    }
                    else if (UserInput == "sleep")
                    {
                        Console.WriteLine("you slept well. although not for a long time since you hear footsteps! there is a guard coming in to your cell");
                        Hunger -= 5;
                        Console.WriteLine("your hunger is now " + Hunger + " out of 50   (-5 lower than before)");
                        Console.WriteLine("");
                        break;
                    }

                    else if (UserInput == "inventory")   ////inventory. copy>?/////
                    {
                        inventory();
                    }


                    else if (UserInput == "wait")
                    {
                        Console.WriteLine("you wait for about half an hour untill suddenly you hear foot steps");
                        break;
                    }
                }


                while (true)    //////while - jail escape /////////
                {
                    
                    Console.WriteLine("you see a human guard opening the metal bar door with a heavy and big key, wich make a very loud unpleasing noise.");
                    Console.WriteLine("the door is now open. the guard is standing in a way that may let you a little chance to run away but since there are other guards " +
                        "outside you decided that it would be better not to. especially because you are alone.");
                    Console.WriteLine("the guard is looking at you with angry face while giving you handcuffs waiting for you to put you hands inside");
                    Console.WriteLine("what should you do?                             [run away / give hands / use the handcuff on him]");

                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    UserInput = Console.ReadLine();
                    Console.BackgroundColor = ConsoleColor.Black;
                    if (UserInput == "run away")
                    {
                        Console.WriteLine("you pass quickly through the metal door. luckyly the guard wasnt ready and now you are inside the hall, ");
                    runaway: Console.WriteLine("while having only two seconds to decide, will you go left or right?");
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        UserInput = Console.ReadLine();
                        Console.BackgroundColor = ConsoleColor.Black;

                        if (UserInput == "left")
                        {
                            JailWarning1 += 1;
                            Console.WriteLine("you turned left and started running. the way turns right while the gurd is after you - forcing you to run right.");
                            Console.WriteLine("");
                            Console.WriteLine("this is a dead end. the way have been cut down by a wall while there are other 5 guards around you. " +
                                " they have warned you. you have " + JailWarning1 + " warnings out of 5");
                        }
                        else if (UserInput == "right")
                        {
                            Console.WriteLine("you see a big door made of wood, the guard is right after you. you try to open the wooden door.");
                            Console.WriteLine("now you are inside a big dining room. you see several wooden tables and chairs with some other criminals around them, eating. " +
                                "there is a big long table with some sort of low quality food. on the other wall of the dining room you see another door that is " +
                                "guarded by two other guards. the door is open");
                        runawayRight: Console.WriteLine("[run to the door / steal food / integrate with the criminals]");
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            UserInput = Console.ReadLine();
                            Console.BackgroundColor = ConsoleColor.Black;


                            if (UserInput == "run to the door")
                            {
                                Console.WriteLine("the guards see you running towards them. they both grab your arms before you could do anything and they give you to the guard " +
                                    "that was after you. no food for today." +
                                " they have warned you. you have " + JailWarning1 + " warnings out of 5");
                            }
                            else if (UserInput == "integrate with the criminals")
                            {
                                Console.WriteLine("you sit with a bunch of criminals you dont know. they look at you with surprise on their face.");
                                Console.WriteLine("the guard that was running after you spot you quickly and take you back to the cell.");
                                JailWarning1 += 1;
                                Console.WriteLine("he have warned you. you know have " + JailWarning1 + " out of 5");
                            }
                            else if (UserInput == "steal food")
                            {

                                Console.WriteLine("you see some big food and some small food. what would you take?");
                                Console.WriteLine("[small food / big food / both]");
                                Console.BackgroundColor = ConsoleColor.DarkGreen;
                                UserInput = Console.ReadLine();
                                Console.BackgroundColor = ConsoleColor.Black;
                                if (UserInput == "big food" || UserInput == "both")
                                {
                                    Gold -= 2;
                                    JailWarning1 += 1;
                                    Console.WriteLine("you took as much as you can, you realise taht you dont have enough time to take big amount of food but could not do " +
                                        "anything about it. its too late - that guard is grabbing you arm and warn you. you have "
                                        + JailWarning1 + " warning out of 5. they took the food you took and forced you to pay for what you took. you now have " + Gold + " gold");
                                }
                                else if (UserInput == "small food")
                                {
                                    SmallFood += 2;
                                    Console.WriteLine("you took some small food quickly. the gurads guarding the door are walking to the guard after you to ask whats wrong");
                                    Console.WriteLine("leaving the door open and easy to pass. you cross the dining room and go through the door. you now have " + SmallFood + "small food");
                                    Console.WriteLine("");
                                    Console.WriteLine("now you are inside a hall. you see daylight at the end of the hall. the guards after you, leaving you no choice " +
                                        "but to run to the exit. after 10 foot steps you realise there are 2 guards guarding the exit gate. they start running towards you");
                                    Console.WriteLine("you have to roll a cube. 20 cube. the only chance to go through the gurads is to roll a number greater than 8.");
                                    Console.WriteLine("[roll cube]");
                                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                                    UserInput = Console.ReadLine();
                                    Console.BackgroundColor = ConsoleColor.Black;


                                    Console.WriteLine("rolling...");

                                    System.Threading.Thread.Sleep(1000);

                                    Console.BackgroundColor = ConsoleColor.DarkYellow;

                                    X20 = rand.Next(0, 20);
                                    Console.WriteLine("you got " + X20);

                                    Console.BackgroundColor = ConsoleColor.Black;

                                    if (X20 < 8)
                                    {
                                        JailWarning1 += 2;
                                        Console.WriteLine("too sad, you were so close. the guards warn you 2X. you now have " + JailWarning1 + " out of 5.");
                                    }
                                    else if (X20 > 8)
                                    {
                                        Console.WriteLine("lucky you. you made it. you push one of the guard - he fall down and you continue to run.");
                                        Console.WriteLine("you are now outside. you see you are inside the dangerios magical thick woods ''Kansabal''. you can barely see the road");
                                        Console.WriteLine("suddenly you realise the door is still open. you hear a big ''roarrrrr''. after the unpleasing sound the woods become " +
                                            "silnce. you birds no crickets. the guards are really close. you look at them and they look frightned. they close the door, leaving " +
                                            "you alone outside.");
                                        Console.WriteLine("you are free!!                  are'nt you?");

                                        JailRunawayOutSide:
                                        

                                        Console.WriteLine("[hide / walk on road / beg to come back / search area]");
                                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                                        UserInput = Console.ReadLine();
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        if (UserInput == "beg to come back")
                                        {
                                            Console.WriteLine("you knock on the big gate that has been closed. you cry and ask from them to come back in.");
                                            Console.WriteLine("you hear a guard say: '' we will never open the door! its too dangerious... enjoy your freedom. we will catch " +
                                                "you back sooner or later. fair well " + CharcterRace + ".''");
                                            Console.WriteLine("");
                                            Console.WriteLine("they won't open the door.");
                                            Console.WriteLine("");
                                            goto JailRunawayOutSide;



                                        }
                                        else if (UserInput == "search area")
                                        {
                                            Hunger -= 10;
                                            DayNightCycle = "its getting late";
                                            Console.WriteLine("you search the area for a while, your hunger is now " + Hunger + " out of 50. " + DayNightCycle);
                                            Console.BackgroundColor = ConsoleColor.DarkYellow;

                                            Console.WriteLine("you have found " + unknown_berrys + " unknown berry's");
                                            if (knife == 1)
                                            {
                                                Console.WriteLine("you have found a knife");
                                                if (map == 1)
                                                {
                                                    Console.WriteLine("you have found a small map");
                                                    Console.BackgroundColor = ConsoleColor.Black;
                                                    goto JailRunawayOutSide;
                                                }
                                                else
                                                {
                                                    Console.BackgroundColor = ConsoleColor.Black;
                                                    goto JailRunawayOutSide;

                                                }
                                            }
                                            else
                                            {
                                                if (map == 1)
                                                {
                                                    Console.WriteLine("you have found a small map");
                                                    Console.BackgroundColor = ConsoleColor.Black;
                                                    goto JailRunawayOutSide;
                                                }
                                                else
                                                {
                                                    Console.BackgroundColor = ConsoleColor.Black;
                                                    goto JailRunawayOutSide;
                                                }
                                            }


                                        }
                                        else if (UserInput == "hide")
                                        {
                                            if (DayNightCycle == "its getting late")
                                            {
                                                Console.WriteLine("you wait for a bit...");
                                                System.Threading.Thread.Sleep(500);
                                                Console.WriteLine("suddenly the whole ground and trees are starting to shacke. like a massive earthquake");
                                                Console.WriteLine("you see a huge troll is coming from the dark. you can barly see, its almost dark");
                                                Console.WriteLine("the troll walks to the prison and try to open the door.");
                                                System.Threading.Thread.Sleep(1000);
                                                Console.WriteLine("it won't open");
                                                System.Threading.Thread.Sleep(500);
                                                Console.WriteLine("he starts to smell something... moving his head all around to figure out where's the smell is comming from.");
                                                Console.WriteLine("you are a bit stressed.");
                                                System.Threading.Thread.Sleep(500);
                                                Console.WriteLine("roll a X20 cube");
                                                Console.BackgroundColor = ConsoleColor.DarkGreen;
                                                Console.ReadLine();
                                                X20 = rand.Next(0, 20);
                                                Console.BackgroundColor = ConsoleColor.DarkYellow;
                                                Console.WriteLine("you got " + X20);
                                                Console.BackgroundColor = ConsoleColor.Black;
                                                if (X20 > 10)
                                                {
                                                    Console.WriteLine("the troll suddenly look direactly at you.");
                                                    Console.WriteLine("look like hes trying to see you. after few seconds he walks away.");
                                                    Console.WriteLine("the whole forest have came back to life.");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("too bad.");
                                                    Console.WriteLine("the troll suddenly look direactly at you.");
                                                    Console.WriteLine("he start to walk toward your position. the bushes won't save you now");
                                     trollFight:    Console.WriteLine("[run to the road / run to the pich dark forest / try to fight him]");

                                                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                                                    UserInput = Console.ReadLine();
                                                    Console.BackgroundColor = ConsoleColor.Black;
                                                    if (UserInput == "run to the road")
                                                    {
                                                        Console.WriteLine("you run to the road.");
                                                        Console.WriteLine("even tough the troll is reacting slowly, he is far more large than you");
                                                        Console.WriteLine("with twice as big legs. you run on the road, see a little house made of wood becoming closer.");
                                                        Console.WriteLine("the troll catch you up. look like he is really hungry");
                                                        Console.WriteLine("");
                                                        Console.BackgroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("YOU ARE ABOUT TO DIE");
                                                        Console.WriteLine("you have a chance to live. all you need to do is get more than 16 in the X20 cube");
                                                        Console.BackgroundColor = ConsoleColor.Black;
                                                        Console.WriteLine("roll the cube. good luck");
                                                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                                                        Console.ReadLine();
                                                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                                                        X20 = rand.Next(0, 20);
                                                        Console.WriteLine("you got " + X20);
                                                        Console.BackgroundColor = ConsoleColor.Black;
                                                        if (X20 < 16)
                                                        {
                                                            Console.BackgroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("you died");
                                                            Console.BackgroundColor = ConsoleColor.Black;
                                                            Console.ReadLine();
                                                           
                                                            Environment.Exit(0);
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("wow how lucky. you hear");
                                                            Console.WriteLine("you won't die, but instead time travel back to when the troll saw you with less 9 gold and 10 hunger");
                                                            Gold -= 9;
                                                            Hunger = 10;
                                                            goto trollFight;
                                                        }

                                                    }
                                                    else if (UserInput == "try to fight him")
                                                    {
                                                        if (knife == 1)
                                                        {
                                                            Console.WriteLine("you grab the knife you found. you run towards him with the knife pointing his head.");
                                                            Console.WriteLine("as you continue to run. you realise how big he really is. he is about twice your hight");
                                                            Console.WriteLine("you can't reach his head.");
                                                            Console.WriteLine("he look at you and lough.");
                                                            Console.BackgroundColor = ConsoleColor.Red; 
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("");
                                                        }
                                                    }
                                                    else if (UserInput == "run to the pich dark forest")
                                                    {
                                                        Console.WriteLine("you see nothing. you hear the troll after you");
                                                        Console.WriteLine("suddenly you fall. you try to grab something and you");

                                                    }



                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("you wait for a bit, the whole woods are silnce but nothing is happening");
                                                goto JailRunawayOutSide;
                                            }
                                        }
                                        else if (UserInput == "walk on road")
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                        }
                                        else
                                        {
                                        }
                                        Console.WriteLine("sorry this is not an option");
                                        goto JailRunawayOutSide;

                                    }

                                }

                            }
                            else
                            {
                                Console.WriteLine("sorry this is not an option");
                                goto runawayRight;
                            }

                        }
                        else
                        {
                            Console.WriteLine("sorry this is not an option.");
                            goto runaway;
                        }
                    }

                }

                //Console.WriteLine("you see a village far away. its becoming closer as the time passes. finnaly you arrive and see two guards guarding the open game");
                //Console.WriteLine("they do not look like the guards from the jail.");
                //Console.WriteLine("[...]");
            }

            /// see website how to set Hunger to max 50 and how to be always active?
        }
    }
}    


    

    

        //game2





        


 

