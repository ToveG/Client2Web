using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client2Web
{
    class Program
    {
        static void Main(string[] args)
        {

            HandelUserInput h = new HandelUserInput();
            foreach (string s in args)
            {
                if (s == "client2web:01")
                {
                    h.respondToUserInput01();
                }
                else if (s == "client2web:02")
                {
                    h.respondToUserInput02();
                }
                else if (s == "client2web:03")
                {
                    h.respondToUserInput03();
                }
                else if (s == "client2web:04")
                {
                    h.respondToUserInput04();
                }

                Console.ReadKey();
            }

        }

















        //HandelUserInput handleInput = new HandelUserInput();

        //string userInput = "0";
        //Console.WriteLine("Välkommern till Client2Web.");
        //Console.WriteLine("Vill du avsluta applikationen vänligen tryck 5.\n");


        //while (userInput != "5")
        //{
        //    Console.WriteLine("Välj ett av följande val: 1, 2 eller 3.");

        //    userInput = Console.ReadLine();

        //    if (userInput == "1")
        //    {
        //        handleInput.respondToUserInput1();
        //    }
        //    else if (userInput == "2")
        //    {
        //        handleInput.respondToUserInput2();
        //    }
        //    else if (userInput == "3")
        //    {
        //        handleInput.respondToUserInput3();
        //    }

        //    else {
        //        Console.WriteLine("Du har gjort ett felaktigt val.");
        //    }

        //}
    }
    }

