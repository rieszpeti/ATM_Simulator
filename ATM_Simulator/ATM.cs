using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simulator
{
    class ATM
    {
        CardHolder[] cardHolders;
        public ATM(int userCount)
        {
            cardHolders = new CardHolder[userCount];
            for (int i = 0; i < cardHolders.Length; i++)
            {
                cardHolders[i] = new CardHolder(
                    RandomGenerator.RandUserNumber(), 
                    RandomGenerator.RandCardNumber(),
                    RandomGenerator.RandPin(),
                    RandomGenerator.RandBalance());
            }
        }
        public void Deposit(double deposit, int cardNumber)
        {
            CardHolder currentUser = CurrentUser(cardNumber);
            currentUser.Balance += deposit;
            Console.WriteLine("Thank you, your balance is updated.");
        }
        public void WithDraw(double withDraw, int cardNumber)
        {
            CardHolder currentUser = CurrentUser(cardNumber);
            if (currentUser.Balance < withDraw)
            {
                Console.WriteLine("Insufficent balance.");
            }
            else
            {
                currentUser.Balance -= withDraw;
                Console.WriteLine("Withdrawal succsessful.");
            }
        }
        public void ChangePin(int newPin, int cardNumber)
        {
            CardHolder currentUser = CurrentUser(cardNumber);
            currentUser.Pin = newPin;
            Console.WriteLine("Thank you, your PIN code is updated.");
        }
        public bool Search(int cardNumber, int pin)
        {
            CardHolder cardHolder = CurrentUser(cardNumber);
            if (cardHolder == null)
            {
                Console.WriteLine("User not found.");
                return false;
            }
            int counter = 1;
            while (counter < 3 && cardHolder.Pin != pin)
            {
                Console.WriteLine("Wrong PIN.");
                Console.WriteLine($"You can try to log in {3 - counter} more time.");
                Console.WriteLine("Enter your PIN number: ");
                pin = int.Parse(Console.ReadLine());
                counter++;
            }
            if (counter < 3)
            {
                return true;
            }
            return false;
        }
        public CardHolder CurrentUser(int cardNumber)
        {
            for (int i = 0; i < cardHolders.Length; i++)
            {
                if (cardHolders[i].UserCardNumber == cardNumber)
                {
                    return cardHolders[i];
                }
            }
            return null;
        }
        public void PrintAllUsers()
        {
            for (int i = 0; i < cardHolders.Length; i++)
            {
                Console.WriteLine($"{i}   {cardHolders[i].ToString()}");
            }
        }
    }
}
