using System;

namespace assingment_7_auction
{
    class Program
    {
        static void Main(string[] args)
        {
            Item[] items = new Item[5];

            items[0] = new Item("Phone", 5000);
            items[1] = new Item("rc car", 1000);
            items[2] = new Item("lego", 500);
            items[3] = new Item("headset", 500);
            items[4] = new Item("laptop", 10000 );

            for (int i = 1; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    Console.WriteLine("Description: " + items[i].Getdescription() + "  Reserve Price: " + items[i].Getreserveprice());
                }
            }
        }
    }
}