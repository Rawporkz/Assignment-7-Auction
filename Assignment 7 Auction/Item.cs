using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_Auction
{
    internal class Item
    {
        private string Descripton;
        private double ReservePrice;
        private double HighestBid;
        private int BidderID;

        public Item(string description, double reserveprice)
        {
            Descripton = description;
            ReservePrice = reserveprice;
            HighestBid = 0;
            BidderID = 0;
        }

        public string GetDescription()
        {
            return Descripton;
        }

        public double GetReservePrice()
        {
            return ReservePrice;
        }

        public double GetHighestBid()
        {
            return HighestBid;
        }

        public double GetBidderID()
        {
            return BidderID;
        }
        public bool IsHigherBid(double BidAmount, int bidderid)
        {
            if (BidAmount > HighestBid)
            {
                HighestBid = BidAmount;
                BidderID = bidderid;    
                return true;
            }
            return false;
        }

        public bool IsSold()
        {
            if (HighestBid > ReservePrice)
            {
                return true;
            }
            return false;
        }

    }
}
