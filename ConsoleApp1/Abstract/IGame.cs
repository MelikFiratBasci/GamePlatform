using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Abstract
{
    public interface IGame
    {
        public string GameName { get; set; }
        public double GamePrice { get; set; }
        public double DiscountPercent { get; set; }
        public bool Purchased { get; set; }
        public int GameId { get; set; }


    }
}
