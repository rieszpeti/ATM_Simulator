using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            ATM atm = new ATM(5);
            while (loop)
            {
                Console.WriteLine("Hello, it is the Shibacoin2x ATM");
                Console.WriteLine("Please, insert your card.");
                Console.WriteLine();

                atm.PrintAllUsers();

                Console.WriteLine("Give me your cardnumber and your pin:");
                Console.WriteLine();
                int cardnumber = int.Parse(Console.ReadLine());
                int pin = int.Parse(Console.ReadLine());

                Console.WriteLine();

                if (atm.Search(cardnumber, pin))
                {
                    Console.WriteLine("Choose option: ");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdrawal");
                    Console.WriteLine("3. Change PIN");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine();

                    int respond = int.Parse(Console.ReadLine());

                    if (respond == 1)
                    {
                        Console.WriteLine("Deposit:");
                        double depos = Double.Parse(Console.ReadLine());
                        atm.Deposit(depos, cardnumber);
                    }
                    if (respond == 2)
                    {

                        Console.WriteLine("Withdrawal:");
                        double withdraw = Double.Parse(Console.ReadLine());
                        atm.WithDraw(withdraw, cardnumber);
                    }
                    if (respond == 3)
                    {

                        Console.WriteLine("New PIN:");
                        int changePinVar = int.Parse(Console.ReadLine());
                        atm.ChangePin(changePinVar, cardnumber);
                    }
                    if (respond == 4)
                    {
                        Console.WriteLine("Thank you, see you later.");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, there is something wrong with your card.");
                }

                atm.PrintAllUsers();

                Console.WriteLine();
                Console.WriteLine("Would you like to user our services again?");
                Console.WriteLine("Press 'y' if yes or 'n' if not.");
                string choose = Console.ReadLine();
                bool cont = true;
                while (cont)
                {
                    if (choose == "y")
                    {
                        cont = false;
                        break;
                    }
                    else if (choose == "n")
                    {
                        loop = false;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input. Try it again.");
                    }
                }
                Console.Clear();
            }
            Console.WriteLine("See you later.");
        }
    }
}
