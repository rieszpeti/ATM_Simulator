using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simulator
{
    static class RandomGenerator
    {
        static Random r = new Random();

        public static int RandCardNumber()
        {
            string cardNumber = "";
            for (int i = 0; i < 8; i++)
            {
                if (i == 0)
                {
                    cardNumber += Convert.ToString(r.Next(1, 10));
                }
                else
                {
                    cardNumber += Convert.ToString(r.Next(0, 10));
                }
            }
            return int.Parse(cardNumber);
        }
        public static int RandPin()
        {
            string pin = "";
            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    pin += Convert.ToString(r.Next(1, 10));
                }
                else
                {
                    pin += Convert.ToString(r.Next(0, 10));
                }
            }
            return Convert.ToInt32(pin);
        }
        public static int RandUserNumber()
        {
            return r.Next(100000, 999999);
        }
        public static double RandBalance()
        {
            return Convert.ToDouble(r.Next(0,5000))+ r.NextDouble();
        }
    }
}
