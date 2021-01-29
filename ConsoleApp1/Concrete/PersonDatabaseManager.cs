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
                Console.WriteLine( "hatali islem   ");
            }
        }


        public void Update(IPerson person,IPerson person1)
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
        public void List()
        {

            Console.WriteLine(personsinDb.Count);


            foreach (var item in personsinDb)
            {
                Console.WriteLine("===========" + item.Id + "===========");

            }

        }
        
    }
}
