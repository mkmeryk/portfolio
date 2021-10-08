using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fd87_MK_final
{
    class Program
    {
        static void Main(string[] args)
        { //omg im gonna start:|
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            
            //show money
            int money = 200;
            //firsti m gonna talk about what is the game, actually somthing funny and then that
            //Introduction
            Console.WriteLine("Punisher: ey, atta Code!, I'm gonna say this only one time in a loop, :| , Here is the situation," +
                "theres no way around, I need you to win this game, so that I fid my next targets. ");
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.WriteLine(" just press any key to open the options");
            
            Console.ReadKey();
            Console.Clear();



            //ask if wanna play or not
            while ( money > 0 && money < 100000 )
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("your money amount is: " + money);
                
                ShowMenu();
                string menuoption = Console.ReadLine();
                if (menuoption == "D" || menuoption == "d")
                {
                    Console.WriteLine("Discription:");
                    Console.WriteLine("Big: The total score will be between 11 and 17(inclusive) with the exeption of a triple");
                    Console.WriteLine("Small:The total score will be between 4 and 10(inclusive) with the exeption of a triple ");
                    Console.WriteLine("Odd:The total score will be and odd number with the exeption of a triple");
                    Console.WriteLine("Even:The total score will be and even number with the exeption of a triple");
                    Console.WriteLine("Triple: any of the tripels will appear");
                    Console.WriteLine("Now press any key to go back to menu");


                }
                else if (menuoption == "A" || menuoption == "a" || menuoption == "B" || menuoption == "b")
                {
                    Console.Clear();
                    //type of bet
                    Console.WriteLine("So here are your types of bets");
                    Console.WriteLine("Bet 1:Big");
                    Console.WriteLine("Bet 2:Small");
                    Console.WriteLine("Bet 3:Odd");
                    Console.WriteLine("Bet 4:Even");
                    Console.WriteLine("Bet 5:Triple");
                    Console.WriteLine("What type of Bet you wanna go with?");

                    int betType = int.Parse(Console.ReadLine());
                    while (true)
                    {
                        try
                        {
                            betType = int.Parse(Console.ReadLine());

                            //Check betAmount is valid
                            if (betType > 0 && betType <= 5)
                            {
                                Console.WriteLine("allrigt, lets see whats gonna happen");
                                break;
                            }
                            else
                            {
                                Console.WriteLine(" Oops, not sure what kind is that");
                            }
                        }
                        catch
                        {
                            //handle errors
                            Console.WriteLine("there was an error!, please try again");
                        }
                    }






                    //how much you wanna bet
                    Console.WriteLine("Now, enter yout bet value in numbers, otherwise it is not going to work");

                    int betValue = 0;

                    
                    while (true)
                    {
                        try
                        {
                            betValue = int.Parse(Console.ReadLine());

                            //Check betAmount is valid
                            if (betValue > 0 && betValue <= money)
                            {
                                Console.WriteLine("allrigt");
                                break;
                            }
                            else
                            {
                                Console.WriteLine(" Oops, Invalid amount. it should be bigger than 0 and less than the money you have, its not a bank here!!, okay?");
                            }
                        }
                        catch
                        {
                            //handle errors
                            Console.WriteLine("there was an error!, please try again");
                        }
                    }

                    Console.Clear();


                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    
                    Console.ForegroundColor = ConsoleColor.Black;

                    //creating a randomiser, lol if that's what's it's called n roll them
                    Random randomiser = new Random();
                    int dice1 = randomiser.Next(1, 7);
                    int dice2 = randomiser.Next(1, 7);
                    int dice3 = randomiser.Next(1, 7);
                    // printing the dices
                    Console.WriteLine(dice1);
                    Console.WriteLine(dice2);
                    Console.WriteLine(dice3);

                    //the game checker for wining
                    //1 is big
                    //2 is small
                    //3 is odd
                    //4 is even
                    //5 triple


                    int DiceTotal = dice1 + dice2 + dice3;
                    Console.WriteLine("your dice total is: " + DiceTotal);
                    //which one is it?
                    //is it big?
                    if ((betType == 1) && (DiceTotal >= 11 && DiceTotal <= 17))
                    {
                        // big
                        money = money + betValue;
                        Console.WriteLine("you won!, Play more!");
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                       
                        Console.ForegroundColor = ConsoleColor.Black;

                    }
                    //is it small?
                    else if ((betType == 2) && (DiceTotal >= 4 && DiceTotal <= 10))

                    {
                        // small
                        money = money + betValue;
                        Console.WriteLine("you won!, Play more!");
                        Console.BackgroundColor = ConsoleColor.DarkGray;

                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    // is it odd?
                    else if ((betType == 3) && (DiceTotal % 2 == 1))


                    {
                        // odd
                        money = money + betValue;
                        Console.WriteLine("you won!, Play more!");
                        Console.BackgroundColor = ConsoleColor.DarkBlue;

                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    // is it even?
                    else if ((betType == 4) && (DiceTotal % 2 == 0))

                    {
                        //even
                        money = money + betValue;
                        Console.WriteLine("you won!, Play more!");
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;

                        Console.ForegroundColor = ConsoleColor.Black;
                    }


                    else if
                        ((betType == 5) && (dice1 == dice2 && dice2 == dice3))
                    {
                        //tripple
                        //money *30
                        money = money + (30 * betValue);
                        Console.WriteLine("you won!, Play more!");

                    }
                    else
                    {
                        // lost 
                        Console.WriteLine("you lost! so now we gonna go down to gether :(");
                        //take money
                        money = money - betValue;
                    }

                    Console.WriteLine("you money is now" + money);


                    //if no money
                    if (money <= 0)
                    {
                        Console.WriteLine("Your money is now all gone, there is an ATM in right behind you, if you wanna play more, you know , I can get the money for you... " );
                        Console.WriteLine(" just say, 'yeah', 'sure', or 'yeah'");
                        
                        string Gameendingoprion = Console.ReadLine();

                      
                        if (Gameendingoprion == "yes" || Gameendingoprion == "yeah" || Gameendingoprion == "sure")
                        {
                            money = 200;
                            Console.WriteLine("nice, boosted up!!! let's get going");

                        }
                    }

                    //ask if play again
                    // if yes, reset money


                    // get the bet type
                    //ask how much they gonna bet
                    //check bet tybe is valid or not
                    //if its valid it's gonna ask you to enter it again
                    //put the bet type
                    //check bet  is valid or not
                    //if its valid it's gonna ask you to enter it again
                    //enter amount
                    //role 3 roundome dices
                    // show the asnwers and tootal
                    //check win or lost
                    //back to start if there is still money, morethan0<money >100,00
                    //ask wanna play again or not

                }

                else if (menuoption == "C" || menuoption == "c")
                {
                    // exit
                    Environment.Exit(0);
                }
                else
                {
                    //wrong input
                    Console.WriteLine("wrong optionnnnn.... try again");
                }
                Console.ReadKey();

            }



            Console.WriteLine("The game has ended!");



            Console.ReadKey();


        }

        //showing the opions
        static void ShowMenu()
        {
            Console.WriteLine("--------------- Options ------------------");
            Console.WriteLine("A.Play n Help");
            Console.WriteLine("A.Play n help");
            Console.WriteLine("A.Play and help");
            Console.WriteLine("B.Re-Play and Re-help");
            Console.WriteLine("C.Play and help, but if you want you can exit the game");
            Console.WriteLine("D.If you wanna learn about the roles and bets");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("So now choose A: (0.0) Watchin' you");

        }



    }
}
