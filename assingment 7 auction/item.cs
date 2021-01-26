using System;
using System.Collections.Generic;
using System.Text;

namespace assingment_7_auction
{
    class Item
    {
        private string desc;
        private double resprice;
        private int IDnum;
        private double highestbid;

        public Item(string desc, double resprice)
        {
            this.desc = desc;
            this.resprice = resprice;
        }

        public string Getdescription()
        {
            return desc;
        }

        public double Getreserveprice()
        {
            return resprice;
        }

        public double Gethighestbid()
        {
            return highestbid;
        }

        public int GetbidderID()
        {
            return IDnum;
        }

        public bool Sethighestbid(double newbid)
        {
            if (newbid > highestbid && newbid > resprice)
            {
                highestbid = newbid;
                return true;
            }
            else
            {
                Console.WriteLine("That is lower than the highest bid");
                return false;
            }
        }

        public void SetbidderID(int newID)
        {
            IDnum = newID;
        }
    }
}
