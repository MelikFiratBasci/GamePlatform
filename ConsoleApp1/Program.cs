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
            person.Name = "Melik Firat";
            person.Surname = "Basci";
            person.BirthYear = 1999;
            person.NationalIdentity = "12345678910";
            IPerson person2 = new Person();
            person2.Id = 2;
            person2.Name = "Melik Firat";
            person2.Surname = "Basci";
            person2.BirthYear = 1999;
            person2.NationalIdentity = "12345678910";
            IPerson person3 = new Person();
            person3.Id = 3;
            person3.Name = "Melik Firat";
            person3.Surname = "Basci";
            person3.BirthYear = 1999;
            person3.NationalIdentity = "12345678910";
            IPerson person5 = new Person();
            person5.Id = 5;
            person5.Name = "Melik Firat";
            person5.Surname = "Basci";
            person5.BirthYear = 1999;
            person5.NationalIdentity = "12345678910";
            
            PersonManager personManager = new Person();
            personManager.Add(person);
            personManager.Add(person2);
            personManager.Add(person3);
            personManager.Update(person3,person5);
            
          

            
            personManager.List();


            
            
            

        }
    }
}
