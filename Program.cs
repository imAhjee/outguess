using System.ComponentModel.Design;
using System.Diagnostics;

namespace Project_while_Johnathan_is_gone {
    internal class Program {
        static void Main(string[] args) {
            

               OutGuessAdd();

        }//main

        static void OutGuess() {

            MakeFancy("WELCOME TO OUTGUESS ;)");

            #region Variables

            int guesses = 7;
            int input = 0;
            var Random = new Random();
            int cpuNum = Random.Next(1, 100);
            int round = 1;
            #endregion

            Thread.Sleep(250);
            Console.WriteLine("You really think you can out guess the matrix?\n\n");


            ColorPrint($"ROUND {round}\n",ConsoleColor.DarkCyan);

            #region BoolWhileLoop

            bool finished = false;
            
            while (!finished) {

                Thread.Sleep(250);
                input = TryPromptInt("Pick a number between 1 and 100 :");

                if (input == cpuNum) {
                    guesses = 0;

                    ColorPrint("You Win!!!", ConsoleColor.DarkGreen);
                    Console.WriteLine("\n\nGood Job kiddo, Lets try it again...\n\n");

                    finished = true;
                    guesses = 7;
                    

                } else if (guesses == 0) {

                    finished = true;

                    Console.WriteLine("\nOUTTA GUESSES.");
                    ColorPrint("\n\n You Lose...", ConsoleColor.DarkRed);
                    Console.WriteLine($"The correct number was {cpuNum}\n\n");
                    

                    guesses = 7;
                    

                } else if (input <= 1) {

                    ColorPrint("ERROR", ConsoleColor.DarkRed);
                    Console.WriteLine("\nENTER A NUMBER BETWEEN 1-100\n\n");

                } else if (input >= 100) {

                    ColorPrint("ERROR", ConsoleColor.DarkRed);
                    Console.WriteLine("\nENTER A NUMBER BETWEEN 1-100 \n\n");

                } else if (input > cpuNum) {
                    ColorPrint("Too high",ConsoleColor.Red);
                    Console.Write($", you have {guesses} guesses remaining\n\n");
                    guesses--;

                } else if (input < cpuNum) {
                    ColorPrint("Too low",ConsoleColor.Blue);
                    Console.Write($", you have {guesses} guesses remaining\n\n");
                    guesses--;
                }
              

                if (finished) {
                    round += 1;
                    cpuNum = Random.Next(1,100);

                    ColorPrint($"ROUND {round}\n", ConsoleColor.DarkCyan);


                    finished = false;
                }


            }
            #endregion
        }//Function



        static void OutGuessAdd() {

            MakeFancy("WELCOME TO OUTGUESS ;)");

            bool finished = false;
            bool gameOver = true;
            bool NotAccepted = false;
            bool done = false;

            while (!finished) {

                int guesses = 0;
                int input = 0;
                var Random = new Random();
                int cpuNum = Random.Next(1, 100);
                int round = 1;
                double TotalMoney = 0.0;
                double wager = 0.0;
                double winPercentage = 0.0;
                


                Thread.Sleep(250);
                Console.WriteLine("You really think you can beat the matrix?\n\n");

                
                while (!NotAccepted) {

                    TotalMoney = TryPromptDouble("How much money you got to put on it? :$");

                    if (TotalMoney <= 0) {

                        ColorPrint("\nERROR\n", ConsoleColor.Red);
                        Console.WriteLine("Please don't try to scam a calculator.\n\n");

                    }else {
                        Console.WriteLine("\n\nLucky we don't ask for proof of income.");

                        NotAccepted = true;
                    }//if

                }//while


                
                while (!done) {

                    ColorPrint($"\n\nROUND {round}\n\n", ConsoleColor.DarkCyan);



                    NotAccepted = false;

                    while (!NotAccepted) {
                    

                        wager = TryPromptDouble("How much do you want on this round?? :$");
                   

                        if (wager > TotalMoney) {

                            ColorPrint("\nERROR\n", ConsoleColor.Red);
                            Console.WriteLine("Please don't try to scam a calculator.\n\n");
                        

                        } else if (wager <= 0) {

                            ColorPrint("\nERROR\n", ConsoleColor.Red);
                            Console.WriteLine("Penny piching I see? I need at least something\n\n");
                        
                        }else {
                            NotAccepted=true;
                        }//if

                    }//while

                    NotAccepted = false;
                    while (!NotAccepted) {

                        guesses = TryPromptInt("\nHow many Guesses you want? The max is 10 :");


                        if (guesses > 10) {

                            ColorPrint("\nERROR\n", ConsoleColor.Red);
                            Console.WriteLine("Dude I said the MAXIMUM is 10\n\n");


                        } else if (guesses < 1) {

                            ColorPrint("\nERROR\n", ConsoleColor.Red);
                            Console.WriteLine("How can you play with no guesses?\n\n");


                        } else {
                            NotAccepted = true;
                            gameOver = false;
                            guesses -= 1;
                        }
                    }//while

                    Thread.Sleep(300);
                    Console.Write("\nGOOD LUCK KID.....\n\n");

                    
                    while (!gameOver) {

                        Thread.Sleep(250);
                        input = TryPromptInt("\nPick a number between 1 and 100 :");

                        if (input == cpuNum) {


                            ColorPrint("You Win!!!", ConsoleColor.DarkGreen);
                            winPercentage += 1;

                            if (guesses == 0) {
                                TotalMoney += (wager * 1);
                                Console.WriteLine("REGULAR PAYOUT");
                            } else if (guesses == 1) {
                                TotalMoney += (wager * 2);
                                Console.WriteLine("PAYOUT X 2");
                            } else if (guesses == 2) {
                                TotalMoney += (wager * 3);
                                Console.WriteLine("PAYOUT X 3");
                            } else if (guesses == 3) {
                                TotalMoney += (wager * 4);
                                Console.WriteLine("PAYOUT X 4");
                            } else if (guesses == 4) {
                                TotalMoney += (wager * 5);
                                Console.WriteLine("PAYOUT X 5");
                            } else if (guesses == 5) {
                                TotalMoney += (wager * 6);
                                Console.WriteLine("PAYOUT X 6");
                            } else if (guesses == 6) {
                                TotalMoney += (wager * 7);
                                Console.WriteLine("PAYOUT X 7");
                            } else if (guesses == 7) {
                                TotalMoney += (wager * 8);
                                Console.WriteLine("PAYOUT X 8");
                            } else if (guesses == 8) {
                                TotalMoney += (wager * 9);
                                Console.WriteLine("PAYOUT X 9");
                            } else if (guesses == 9) {
                                TotalMoney += (wager * 10);
                                Console.WriteLine("PAYOUT X 10");
                            }

                            Console.WriteLine($"New Balance: {TotalMoney:c}");

                            Console.WriteLine("\n\nGood Job kiddo, Lets try it again...\n\n");
                            gameOver = true;







                        } else if (input <= 1) {

                            ColorPrint("ERROR", ConsoleColor.DarkRed);
                            Console.WriteLine("\nENTER A NUMBER BETWEEN 1-100\n\n");

                        } else if (input >= 100) {

                            ColorPrint("ERROR", ConsoleColor.DarkRed);
                            Console.WriteLine("\nENTER A NUMBER BETWEEN 1-100 \n\n");

                        } else if (guesses == 0) {

                            TotalMoney -= wager;

                            Console.WriteLine("\nOUTTA GUESSES.");
                            ColorPrint("\n\n You Lose...", ConsoleColor.DarkRed);
                            Console.WriteLine($"The correct number was {cpuNum}\n");

                            Console.WriteLine($"Ending Balance: {TotalMoney:c}\n\n");

                            gameOver = true;

                        } else if (input > cpuNum) {
                            ColorPrint("Too high", ConsoleColor.Red);
                            Console.Write($", you have {guesses} guesses remaining\n\n");
                            guesses--;

                        } else if (input < cpuNum) {
                            ColorPrint("Too low", ConsoleColor.Blue);
                            Console.Write($", you have {guesses} guesses remaining\n\n");
                            guesses--;
                        }//if


                        if (gameOver) {
                            
                            NotAccepted = false;
                            while (!NotAccepted) {

                                Console.WriteLine("Would you like to play again Y/N?");

                                string answer;
                                char response = ' ';


                                response = Console.ReadKey(false).KeyChar;

                                if (response == 'n') {

                                    winPercentage = winPercentage / round;
                                    winPercentage *= 100;

                                    NotAccepted = true;Thread.Sleep(300);
                                    Console.WriteLine($"\n\nBalance---{TotalMoney:c}\nThanks for playing");

                                    Console.WriteLine($"Win Percentage of {winPercentage}%");

                                    return;


                                } else if (response == 'y') {

                                    NotAccepted = true;

                                    finished = false;

                                } else {
                                    NotAccepted = false ;
                                }//if

                                round += 1;
                                cpuNum = Random.Next(1, 100);



                            }//while





                        }//if
                        
                        
                    }//while game
                }//round while
                
            }//big while

            

        }//function

        #region HelperFunctions

        static void MakeFancy(string text) {




            ColorPrint("1010001101100110110101011010110101010010110101010011010101100101010101010101010011010100101010101000101\n", ConsoleColor.Green);
            ColorPrint("1010001101100110110101001010110101010110110101010011010101100101010101110101010011010101010001011100010\n",ConsoleColor.Green);
            ColorPrint($"----------------------------------> {text} <------------------------------------------\n",ConsoleColor.White);
            ColorPrint("1010001101100110110101011010110101010010110101010011010101100101010101010101010011010100101010101000101\n", ConsoleColor.Green);
            ColorPrint("1010001101100110110101011010110101010010110101010011010101100101010101010101010011010100101010101000101\n\n", ConsoleColor.Green);


        }//function



        
        static void ColorPrint(string text, ConsoleColor color) {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }
        //PROMPT FUNCTION STRINGS
        static string Prompt(string dataRequest) {

            //VARIABLE
            string userInput = "";

            //REQUEST INFO FROM USER
            Console.Write(dataRequest);

            //RECIEVE RESPONSE
            userInput = Console.ReadLine();

            return userInput;
        }//function STRING
  
        //PROMPT FUNCTION INT
        static int PromptInt(string dataRequest) {
            //VARIABLE
            int userInput = 0;
            //CALL FUNCTION IN FUNCTION
            userInput = int.Parse(Prompt(dataRequest));
            //RETUN INFO TO MAIN 
            return userInput;

        }//function int

        static double PromptDouble(string dataRequest) {

            double userInput = 0.0;

            userInput = double.Parse(Prompt(dataRequest));

            return userInput;

        }//function Double
        static int TryPromptInt(string dataRequest) {
            bool vallidInt = false;
            int parsedValue = 0;
            Console.Write(dataRequest);
            vallidInt = int.TryParse(Console.ReadLine(), out parsedValue);

            while (!vallidInt) {
                ColorPrint("ERROR", ConsoleColor.Red);
                Console.WriteLine($"\nYou must enter a valid whole number.\n\n{dataRequest}");
                vallidInt = int.TryParse(Console.ReadLine(), out parsedValue);
            }
            return parsedValue;
        }// end trypromptint
        static double TryPromptDouble(string dataRequest) {
            bool validDouble = false;
            double parsedValue = 0.0;
            Console.Write(dataRequest);
            validDouble = double.TryParse(Console.ReadLine(), out parsedValue);

            while (!validDouble) {
                ColorPrint("ERROR", ConsoleColor.Red);
                Console.WriteLine($"\nYou must enter a valid whole number.\n\n{dataRequest}");
                validDouble = double.TryParse(Console.ReadLine(), out parsedValue);
            }
            return parsedValue;
        }// TRYPROMPTDOUBLE
        #endregion
    }//class


}//namespace
