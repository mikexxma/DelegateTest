using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DelegateTest
{

    class MissChen
    {
        public static void buyTicket()
        {
            Console.WriteLine("MissChen need to buy tickets");
        }

        public static void buyFood(int i)
        {
            Console.WriteLine("MissChen need to buy " + i + " food");
        }

        public static void buyPhone(int i)
        {
            Console.WriteLine("MissChen need to buy " + i + " phone");
        }

        public static int addFood(int i)
        {
            Console.WriteLine("MissChen need to add some food");
            return i++;
        }


    }


    class MrMike
    {
        public delegate void BuyTicketEvent();
        public delegate void BuySomeEvent(int i);
        public delegate int AddFoodEvent(int i);

        public static void askMissChenToBuySomeThings(BuySomeEvent bs,int i)
        {
            bs(i);
        }
        static void Main(string[] args)
        {
            BuyTicketEvent bt = new BuyTicketEvent(MissChen.buyTicket);
            bt();

            //same type of paramater and return value can be declear as a same delegate
            BuySomeEvent bf = new BuySomeEvent(MissChen.buyFood);
            BuySomeEvent bp = new BuySomeEvent(MissChen.buyPhone);

            AddFoodEvent af = new AddFoodEvent(MissChen.addFood);
            int i = af(5);

            askMissChenToBuySomeThings(bf, 10);
            askMissChenToBuySomeThings(bp, 1);
            Console.ReadLine();
        }
       
    }
}
