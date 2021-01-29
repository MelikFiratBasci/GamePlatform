using ConsoleApp1.Abstract;
using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Concrete
{
    public abstract class PersonDatabaseManager
    {
        public List<IPerson> personsinDb = new List<IPerson>();
        GameManager gameManager = new Game();


        public void Add(IPerson person)
        {
            personsinDb.Add(person);
        }
        public void Delete(IPerson person)
        {

            if (personsinDb.Contains(person))
            {
                personsinDb.Remove(person);
            }
            else
            {
                Console.WriteLine("hatali islem   ");
            }
        }


        public void Update(IPerson person, IPerson person1)
        {

            if (personsinDb.Contains(person))
            {
                personsinDb.Remove(person);
                personsinDb.Add(person1);
            }
            else
            {
                Console.WriteLine("hatali islem");
            }
        }
        public void Login(IPerson person)
        {
            
            if (personsinDb.Contains(person))
            {
                Console.WriteLine("============================" + "     " + person.Id + "   " + person.Name + "   " + person.UserName + "   " + "========================================");
                
            }
            else
            {
                Console.WriteLine("hatali giris ");
            }
        }

    }
}
