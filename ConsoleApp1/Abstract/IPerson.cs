using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Abstract
{
    public interface IPerson
    {
        public string UserName { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NationalIdentity { get; set; }
        public int BirthYear { get; set; }


    }
}
