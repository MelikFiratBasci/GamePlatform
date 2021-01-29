using ConsoleApp1.Abstract;
using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Concrete
{
    public abstract class PersonManager
    {
        PersonDatabase personDatabaseManager = new PersonDatabase();
        bool personCheck = true;
        
        public void Add(IPerson person)
        {
            if (personCheck == true)
            {
                personDatabaseManager.Add(person);
            }
            else
            {
                Console.WriteLine("============== lutfen kimlik bilgilerinizi dogru giriniz ==============");
            }

        }


        public void Delete(IPerson person)
        {
            personDatabaseManager.Delete(person);
        }

        public void Update(IPerson person,IPerson person1)
        {
            personDatabaseManager.Update(person,person1);
            
        }
        public void List()
        {
            personDatabaseManager.List();
        }
    }
}
