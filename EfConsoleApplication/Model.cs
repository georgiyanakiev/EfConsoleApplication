using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EfConsoleApplication
{
    public class Person
    {
        public int PersonId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string City { get; set; }

        public DateTime BirthDate { get; set; }
    }
    public class Car
    {
        public int CarId { get; set; }

        public string Model { get; set; }

        public string Make { get; set; }

        public string Country { get; set; }

        public DateTime Year { get; set; }
    }

}