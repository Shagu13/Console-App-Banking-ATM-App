using System;

namespace FinalProjectATM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*----------  REGISTER ACCOUNT  ----------*/
            //var storedData = new RegisterNewClient().Register();
            //Console.WriteLine(storedData);

            var path = new Path().GetPath();
            var brain = new Brain(path: path);
            if (brain.CheckData())
            {
                if (brain.VerifyPin())
                {
                    Console.Clear();
                    brain.DisplayMenu();
                }
            }

        }
    }
}
