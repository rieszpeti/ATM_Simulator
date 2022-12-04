using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simulator
{
    class CardHolder
    {
        int userNumber;
        int userCardNumber;
        int pin;
        double balance;
        public CardHolder(int userNumber, int userCardNumber, int pin, double balance)
        {
            this.userNumber = userNumber;
            this.userCardNumber = userCardNumber;
            this.pin = pin;
            this.balance = balance;
        }

        public override string ToString() // for test
        {
            return $"{userNumber} {userCardNumber} {pin} {balance}";
        }

        public int UserNumber { get { return userNumber; } }
        public int UserCardNumber { get { return userCardNumber; } }
        public int Pin { get { return pin; } set { pin = value; } }
        public double Balance { get { return balance; } set { balance = value; } }
    }
}
