using System;

namespace Assignment_7_Auction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item[] items =
            {
                new Item("Lamp",50),
                new Item("Teddy Bear",150),
                new Item("Gun",250),
                new Item("Old Coffee",550),
                new Item("Iphone 1",600)
            };

            while (true)
            {
                PrintItems(items);
                PlaceBid(items);
                PrintSoldItems(items);
            }
        }

        static void PrintItems(Item[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{i + " Description:" +  items[i].GetDescription(),-30} {"Highest Bid:" +items[i].GetHighestBid(),10}");
            }
        }

        static void PlaceBid(Item[] items)
        {
            int Choice = -1;
            while (Choice > items.Length || Choice < 0)
            {
                Console.WriteLine("Which item number would you like to bid on?");
                Choice = Convert.ToInt32(Console.ReadLine());
            }
            
            
            double BidAmount;
            Console.WriteLine("Enter Bid amount");
            BidAmount = Convert.ToDouble(Console.ReadLine());

            int BidderID;
            Console.WriteLine("Enter your bidder ID");
            BidderID = Convert.ToInt32(Console.ReadLine());

            items[Choice].IsHigherBid(BidAmount, BidderID);

        }

        static void PrintSoldItems(Item[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].IsSold())
                {
                    Console.WriteLine(items[i].GetDescription() + " is sold  to Bidder ID:" + items[i].GetBidderID() + " for:" + items[i].GetReservePrice() + " baht" );
                }
            }
        }
    }
}
