using ConsoleApp1.Abstract;
using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Concrete
{
    public abstract class GameManager
    {
        public List<IGame> games = new List<IGame>();

        public void Add(IGame game)
        {
            games.Add(game);

        }
        public void Delete(IGame game)
        {
            if (games.Contains(game))
            {
                games.Remove(game);
            }
            else
            {
                Console.WriteLine("hatali islem   ");
            }
        }
        public void Update(IGame game1, IGame game2)
        {
            if (games.Contains(game1))
            {
                
                games.Remove(game1);
                games.Add(game2);
            }
            else
            {
                Console.WriteLine("hatali islem   ");
            }
        }
        public void List()
        {


            foreach (var game in games)
            {
                if (game.DiscountPercent>0)
                {
                    Console.WriteLine("IndirimliOyun");
                }

                game.GamePrice = (game.GamePrice) - (((game.DiscountPercent) * (game.GamePrice) / 100));
                
                Console.WriteLine("     " + game.GameName + "   " + game.GamePrice + "   " + game.DiscountPercent + "   " + game.GameId);
                Console.WriteLine();
                Console.WriteLine();

            }
        }


    }
}
