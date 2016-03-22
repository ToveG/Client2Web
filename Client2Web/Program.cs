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
            HandelUserInput handleInput = new HandelUserInput();

            string userInput = "0";
            Console.WriteLine("Hej och välkommen.");
            Console.WriteLine("Vill du avsluta applikationen vänligen tryck 4.");

            while (userInput != "4")
            {
                Console.WriteLine("Välj ett av följande val: 1, 2 eller 3.");

                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    handleInput.respondToUserInput1();
                }
                else if (userInput == "2")
                {
                    handleInput.respondToUserInput2();
                }
                else if (userInput == "3")
                {
                    handleInput.respondToUserInput3();
                }

                else {
                    Console.WriteLine("Du har gjort ett felaktigt val.");
                }

            }
        }
    }
}
