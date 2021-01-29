using ConsoleApp1.Abstract;
using ConsoleApp1.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    class Game : GameManager,IGame
    {
        public string GameName { get; set; }
        public double GamePrice { get; set; }
        public double DiscountPercent { get; set; }
        public bool Purchased { get; set; }
        public int GameId { get; set; }
    }
}
