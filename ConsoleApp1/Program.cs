using ConsoleApp1.Abstract;
using ConsoleApp1.Concrete;
using ConsoleApp1.Entities;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
      
            IPerson person = new Person();
            person.Id = 1;
            person.Name = "Firat";
            person.Surname = "Basci";
            person.BirthYear = 1999;
            person.NationalIdentity = "12345678910";
            person.UserName = "mbasci";
            IPerson person2 = new Person();
            person2.Id = 2;
            person2.Name = "kullanici";
            person2.Surname = "soyad";
            person2.BirthYear = 1999;
            person2.NationalIdentity = "12345678911";
            person2.UserName = "xxxxx";
           

            PersonManager personManager = new Person();
            personManager.Add(person);
            personManager.Add(person2);
            //personManager.Add(person3);
            //personManager.Update(person3,person5);
         

            IGame game1 = new Game() { GameName = "oyun1", GamePrice = 200, DiscountPercent = 20 ,GameId=1  };
            IGame game2 = new Game() { GameName = "oyun2", GamePrice = 200, DiscountPercent = 20,GameId=2 };
            IGame game3 = new Game() { GameName = "oyun3", GamePrice = 160, DiscountPercent = 20, GameId = 3 };
            IGame game4 = new Game() { GameName = "oyun4", GamePrice = 160, DiscountPercent = 0, GameId = 4 };
            
            GameManager game = new Game();
            game.Add(game1);
            game.Add(game2);
            game.Add(game3);
            game.Add(game4);
            
            
            personManager.Login(person);
            game.List();







        }
    }
}
