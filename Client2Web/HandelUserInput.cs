using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client2Web
{
    class HandelUserInput : IWeb2Client
    {
        public void respondToUserInput01()
        {
            Console.WriteLine("Kul att du valde nummer 1");
            Console.ReadKey();
        }
        public void respondToUserInput02()
        {
            Console.WriteLine("Yes nr2.");
        }
        public void respondToUserInput03()
        {
            Console.WriteLine("3-it´s a magic number.");
        }
        public void respondToUserInput04()
        {
            Console.WriteLine("Number 4 it is");
        }
    }
}
