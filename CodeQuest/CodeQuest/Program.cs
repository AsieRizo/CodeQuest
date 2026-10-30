using System;

public class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; //Configuring the console to UTF-8 in order to show emojis
        //Main Menu
        const string MenuTitle = "===== MAIN MENU - CODEQUEST =====";
        const string MenuOption1 = "1. Train your wizard";
        const string MenuOption2 = "2. Check the dungeon";
        const string MenuOption3 = "3. Loot the mine";
        const string MenuOptionExit = "0. Exit game";
        const string MenuPrompt = "Choose an option (1-3) - (0) to exit: ";
        const string Chapter_Between_Spacing = "-----------------------------------";

        //Error messages
        const string ErrorNotNumber = "Error: you must type a number, not text.";
        const string ErrorTooBig = "Error: that number is too big.";
        const string ErrorRange = "Error: the option must be between 0 and 3.";
        const string ErrorNoInput = "Error: no input received.";

        //Chapter 1: "The way of the learning mage" is initiated"
        //Text fragment constants assigment
        const string CH1_TEXT_MENU = "========CHAPTER1 MENU=======";
        const string CH1_TEXT_MAGENAME = " 👋 Welcome to CodeQuest,you have selected Chapter 1: The way of the learning mage🧙‍," +
            "please select the name for your character: ";
        const string CH1_TEXT_START = "Now we are going to start your trainment for 5 days 💪";

        //Complete message: Day {day} --> {namemage} has meditated {hours} hours and now your power is {points}
        const string CH1_MSG_STATSPROGRESSION1 = " --> has meditated ";
        const string CH1_MSG_STATSPROGRESSION2 = " hours and now your power is ";
        const string CH1_MSG_STATSPROGRESSION3 = " points ✨";

        //Complete message: {namemage} has leveled up level {level}
        //Messages by evaluation's mark
        const string CH1_MSG_LEVELUP = " has leveled up to level ";
        const string CH1_MSG_EVALUATION_NOTPASS = "😢 You repeat 2nd convocatory";
        const string CH1_MSG_EVALUATION_PASS_ALMOST = "😑 You still confuse the wand with the spurn";
        const string CH1_MSG_EVALUATION_PASS_ENOUGH = "😊 You are a Magical Breeze caster";
        const string CH1_MSG_EVALUATION_PASS_GOOD = " 🐲 WOW. You can cast dragons without burning the lab";
        const string CH1_MSG_EVALUATION_PASS_MASTER = "🤩 You have acomplished the Master of Arcanes rank";

        //Ranks
        const string CH1_TEXT_RANK_OBTAIN = "You obtain the rank: ";
        const string CH1_MSG_RANK_NOTPASS = "Raoden the Elantrian";
        const string CH1_MSG_RANK_PASS_ALMOST = "Zyn the Bugged";
        const string CH1_MSG_RANK_PASS_ENOUGH = "Arka Nullpointer";
        const string CH1_MSG_RANK_PASS_GOOD = "Elantrion of the Embers";
        const string CH1_MSG_RANK_PASS_MASTER = "ITB-Wizard the Gray";
        const string CH1_MSG_RANK_PASS_GOD = "😯Hello, I am Gale of Waterdeep"; //Just an easter-egg ;)

        //Chapter 2: "The Dungeon of the dragon Raymond the Powerful" is initiated"
        //Text fragment constants assigment
        const string CH2_TEXT_BANNER = "==========CHAPTER 2: THE DUNGEON OF DRAGON RAYMOND THE POWERFUL============";
        const string CH2_TEXT_INITIALIZE = "Welcome to Chapter 2 The Dungeon of the dragon Raymond the Powerful.";

        //Game Explain
        const string CH2_TEXT_EXPLAIN_ENTER = "Your mage has entered into the Dungeon of the Dragon Raymond the Powerful in search of its treasure 🐲💎.";
        const string CH2_TEXT_EXPLAIN_DOORS = " In front of you there are 3 doors 🚪🚪🚪, each one is protected with a number between 1 and 5.";
        const string CH2_TEXT_EXPLAIN_GUESS = " In order to overcome the room, you must guess the doors code in less than 3 tryes. 🤔";
        const string CH2_TEXT_EXPLAIN_CONSEQUENCE = " Otherwise, the dragon will detect your presence and you will lose the game 🐲😤😭.";
        const string CH2_TEXT_EXPLAIN_REPEAT = "You must repeat this process with 3 different doors to get the treasure";

        //Game interactions
        const string CH2_TEXT_SELECT = "Select a number in order to open the door (if you lose the door code does not change): ";
        const string CH2_MSG_WARNING = "You have not guessed  the code, you have ";
        const string CH2_MSG_CATCH = "The dregon 🐲😤 has detected your presence and it has expelled you from the dungeon";
        const string CH2_MSG_RESPECT = "The dragon 🐲 👌respects you. You have unlocked the next level";
        const string CH2_MSG_REWARD = "You have unlocked the final level. You can keep the dragons treasure 🐲💎 ";
        const string CH2_MSG_ERROR = "❎ERROR❎: Your input text format is not valid (1,2,3,4 or 5). Please try again ";

        //Chaptewr 3
        // Welcome
        const string CH3_TEXT_MENU = "========CHAPTER3 MENU=======";
        const string CH3_TEXT_WELCOME = " 👋 Welcome to CodeQuest,you have selected Chapter 3: Lot the swag 🪎";
        const string CH3_TEXT_START = "Now it is time to mine⛏️. ";
        const string CH3_TEXT_EXPLAIN_BITS = " Whenever you do an excavation you gain 5 to 50 bits 🪙. Or maybe nothing 🙂 (20% chance of being disgraceful)";
        const string CH3_TEXT_EXCAVATION = "You can only do 5 excavations in total.";
        const string CH3_TEXT_START_DEFINITIVE = " NOW LET'S GO MINING 🤩";

        //Game events
        const string CH3_MSG_GOODLUCK = "You have a lucky day 👌, you have won ";
        const string CH3_MSG_BADLUCK = "😢 Today is not your day, you have found nothing...";
        const string CH3_MSG_TOTAL = "You have earned in these 5 days ";

        //Game rewards
        const string CH3_MSG_SUCCES = " You have unlocked the golden GPU ⚜️! Your spells now go on 120 FPS! ";
        const string CH3_MSG_RETURN = "Yor magical wand is still integrated 🪵.Return to the mine and try again! ";

        //Constant values
        const int MIN_RANDOM = 1;
        const int CH1_MAX_RANDOM_HOURS = 25;
        const int CH1_MAX_RANDOM_POINTS = 11;
        const int CH2_CH3_MAX_RANDOM = 6;
        const int CH2_TRIES = 3;
        const int CH3_MIN_EXCAVATION = 5;
        const int CH3_MAX_EXCAVATION = 51;

        // Valor centinella: -1 NO és una opció vàlida.
        // El necessitem perquè el compilador no garanteix que 'option' s'assigni
        // dins del try (pot saltar una excepció abans d'arribar a l'assignació).
        int option = -1;
        bool isValid;

        do
        {
            isValid = false; // A cada volta suposem que l'entrada NO és vàlida

            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuOption1);
            Console.WriteLine(MenuOption2);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);

            try
            {
                // int.Parse pot llançar: FormatException, OverflowException
                // o ArgumentNullException (si ReadLine retorna null amb Ctrl+Z / Ctrl+D)
                option = int.Parse(Console.ReadLine());

                // Validació de rang: si no es compleix, LLANÇEM nosaltres l'excepció
                if (option < 0 || option > 3)
                {
                    throw new ArgumentOutOfRangeException(nameof(option), ErrorRange);
                }

                // Si arribem aquí no ha saltat cap excepció: entrada vàlida
                isValid = true;
                Console.WriteLine($"You chose: {option}");
                if (option == 1)
                {
                    //Local variables
                    string namemage = "";
                    int day;
                    int points, levelnew, levelreference, hours;
                    var rng = new Random(); // A random number generator

                    //Begin
                    day = 1;
                    points = 0;

                    Console.WriteLine(CH1_TEXT_MENU);
                    Console.Write(CH1_TEXT_MAGENAME);
                    namemage = Console.ReadLine();
                    Console.WriteLine(CH1_TEXT_START);

                    levelnew = 1;
                    levelreference = 1;

                    for (int i = 1; i <= 5; i++)
                    { //The mage trains for 5 days straight
                        Console.WriteLine(Chapter_Between_Spacing);
                        hours = rng.Next(MIN_RANDOM, CH1_MAX_RANDOM_HOURS); //The mage trains a random number of hours between 1 and 24 hours
                        points = points + rng.Next(MIN_RANDOM, CH1_MAX_RANDOM_POINTS);//The mage gains a random number of ponts between 1 and 10
                        levelnew = 1 + points / 10;// The level of the mage increases for each 10 points

                        Console.WriteLine($"{day++} {namemage}{CH1_MSG_STATSPROGRESSION1}{hours}{CH1_MSG_STATSPROGRESSION2}{points}{CH1_MSG_STATSPROGRESSION3}");

                        //Compares the new level with the level of the day before, is the first one is bigger the mage has leveled up
                        if (levelnew > levelreference)
                        {
                            Console.WriteLine($"🔼{namemage}{CH1_MSG_LEVELUP}{levelnew}");
                            Console.WriteLine(Chapter_Between_Spacing);
                        }

                        levelreference = levelnew;

                    }
                    Console.WriteLine(Chapter_Between_Spacing);
                    //Assign a mage title and a evaluation according to the gained points
                    if (points < 20)
                    {
                        Console.WriteLine($"{CH1_MSG_EVALUATION_NOTPASS}");
                        Console.WriteLine($"{CH1_TEXT_RANK_OBTAIN}{CH1_MSG_RANK_NOTPASS}");
                    }
                    else if ((points >= 20) && (points < 30))
                    {
                        Console.WriteLine($"{CH1_MSG_EVALUATION_PASS_ALMOST}");
                        Console.WriteLine($"{CH1_TEXT_RANK_OBTAIN}{CH1_MSG_RANK_PASS_ALMOST}");
                    }
                    else if ((points >= 30) && (points < 35))
                    {
                        Console.WriteLine($"{CH1_MSG_EVALUATION_PASS_ENOUGH}");
                        Console.WriteLine($"{CH1_TEXT_RANK_OBTAIN}{CH1_MSG_RANK_PASS_ENOUGH}");
                    }
                    else if ((points >= 35) && (points < 40))
                    {
                        Console.WriteLine($"{CH1_MSG_EVALUATION_PASS_GOOD}");
                        Console.WriteLine($"{CH1_TEXT_RANK_OBTAIN}{CH1_MSG_RANK_PASS_GOOD}");
                    }
                    else if ((points >= 40) && (points < 50))
                    {
                        Console.WriteLine($"{CH1_MSG_EVALUATION_PASS_MASTER}");
                        Console.WriteLine($"{CH1_TEXT_RANK_OBTAIN}{CH1_MSG_RANK_PASS_MASTER}");
                    }
                    else if (points == 50)
                    {
                        Console.WriteLine($"{CH1_TEXT_RANK_OBTAIN}{CH1_MSG_RANK_PASS_GOD}");
                    }
                }


                else if (option == 2)
                {
                    //Variables
                    int input_code, door_code, tries;
                    var rng = new Random(); //A random number generator
                    string input;

                    //Begin
                    //Game explain
                    Console.WriteLine(CH2_TEXT_BANNER);
                    Console.WriteLine(CH2_TEXT_INITIALIZE);
                    Console.WriteLine(CH2_TEXT_EXPLAIN_ENTER);
                    Console.WriteLine(CH2_TEXT_EXPLAIN_DOORS);
                    Console.WriteLine(CH2_TEXT_EXPLAIN_GUESS);
                    Console.WriteLine(CH2_TEXT_EXPLAIN_CONSEQUENCE);
                    Console.WriteLine(CH2_TEXT_EXPLAIN_REPEAT);
                    //The game has 3 iterations
                    for (int i = 1; i <= 3; i++)
                    {
                        tries = CH2_TRIES; //c
                        door_code = rng.Next(MIN_RANDOM, CH2_CH3_MAX_RANDOM); //Generates a random door code constatntes

                        while (tries > 0) // For each door/iteration you can guess the code as long your do not have 0 tries left
                        {
                            do
                            {
                                Console.Write(CH2_TEXT_SELECT); //The player introduces a number 
                                input = Console.ReadLine();

                                if ((int.TryParse(input, out input_code) != true) || input_code > 5 || input_code < 1)
                                { //Control of errors, it checks the format from the users input and forces it to introduce a valid format of number
                                    Console.WriteLine(CH2_MSG_ERROR);
                                    Console.WriteLine(Chapter_Between_Spacing);
                                }

                            } while (int.TryParse(input, out input_code) != true);


                            if (input_code == door_code) //If the player guesses the number he passes to the next level
                            {

                                tries = 0;

                                if (i == 3)
                                { // if the player is in the last door he will directly win the game when guessing the code
                                    Console.WriteLine(CH2_MSG_REWARD);
                                }
                                else
                                {
                                    Console.WriteLine(CH2_MSG_RESPECT);
                                }

                            }
                            else if (input_code != door_code && input_code >= 1 && input_code <= 5)
                            {
                                --tries; //Whenever the player does not guess the code the number of tries left is decreased by 1

                                if (tries > 0) //If the player does not get the code but he has 1 or more tries left the game will continue
                                {
                                    Console.WriteLine($"{CH2_MSG_WARNING}{tries} tries left");
                                }
                                else //If the player does not get the code the game will end directly
                                {
                                    Console.WriteLine(CH2_MSG_CATCH);
                                    i = 4;
                                }
                            }
                            Console.WriteLine(Chapter_Between_Spacing);
                        }
                    }
                }
                 else {
                        int bit, bit_total, chance;
                        var rng = new Random(); // A random number generator

                        //Begin
                        //Game Explain
                        bit = 0;
                        bit_total = 0;

                        Console.WriteLine(CH3_TEXT_MENU);
                        Console.WriteLine(CH3_TEXT_WELCOME);
                        Console.WriteLine(CH3_TEXT_START);
                        Console.WriteLine(CH3_TEXT_EXPLAIN_BITS);
                        Console.WriteLine(CH3_TEXT_EXCAVATION);
                        Console.WriteLine(CH3_TEXT_START_DEFINITIVE);

                        for (int i = 1; i <= 5; i++) //5 excavations are realized constantes
                        {
                            chance = rng.Next(MIN_RANDOM, CH2_CH3_MAX_RANDOM); //The program decides if the player will get nothing 

                            if (chance == 1)
                            { //Select 1 of 5 numbers (20%) and this will determine if player gets something
                                Console.WriteLine($"{i} day --> {CH3_MSG_BADLUCK}");
                            }
                            else //Player gains a random amount of bits from 5 to 50 if the game decides that it gains bits
                            {
                                bit = rng.Next(CH3_MIN_EXCAVATION, CH3_MAX_EXCAVATION);
                                Console.WriteLine($"{i} day --> {CH3_MSG_GOODLUCK}{bit} bits");
                                bit_total += bit;
                            }
                        }
                        Console.WriteLine($"{CH3_MSG_TOTAL} {bit_total} bits");
                        //Assign a buf depending of the amournt of bits
                        if (bit_total > 200)
                        {
                            Console.WriteLine(CH3_MSG_SUCCES);

                        }
                        else
                        {
                            Console.WriteLine(CH3_MSG_RETURN);
                        }


                        Console.WriteLine("----------------------------");
                    }
            
            } //Global error control
            catch (FormatException)              // Not number text: "abc", "3.5", ""
            {
                Console.WriteLine(ErrorNotNumber);
            }
            catch (OverflowException)            // Number that does not fit in inside the int: "99999999999"
            {
                Console.WriteLine(ErrorTooBig);
            }
            catch (ArgumentNullException)        // ReadLine returns null
            {
                Console.WriteLine(ErrorNoInput);
            }
            catch (ArgumentOutOfRangeException)  // The one that we have trwon by the range
            {
                Console.WriteLine(ErrorRange);
            }
            finally
            {
                // It is always executed
                Console.WriteLine("----------------------------");
            }

            // Repeat if the input is not valid or is has not been asked to get out.
            // First it is checked !is valid because, with error, it can worth 0 from a previous roll

        } while (!isValid || option != 0);
    }
}