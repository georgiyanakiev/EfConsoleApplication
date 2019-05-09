using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            PerformDatabaseOperations();
            Console.Write("Object saved !");
            Console.ReadLine();
        }

        /// <summary>
        ///     The perform database operations.
        /// </summary>
        public static void PerformDatabaseOperations()
        {
            using (var db = new PersonDbContext())
            {
                Console.WriteLine();
                Console.WriteLine("All objects in database:");

                foreach (var cars in db.Cars)

                {
                    Console.WriteLine(" -{0}", cars.Make);
                    Console.WriteLine(" -{0}", cars.Model);
                    Console.WriteLine(" -{0}", cars.Country);
                    Console.WriteLine(" -{0}", cars.CarId);


                }

                var car = new Car
                {
                    CarId = 1112,
                    Model = "Mercedes",
                    Make = "E-class",
                    Country = "Germany",
                    Year = DateTime.Now
                };
                db.Cars.Add(car);

                var count = db.SaveChanges();
                Console.WriteLine("{0} car saved to database", count);
            

                foreach (var persons in db.Persons)

                {
                    Console.WriteLine(" -{0}", persons.FirstName);
                    Console.WriteLine(" -{0}", persons.LastName);
                    Console.WriteLine(" -{0}", persons.City);
                    Console.WriteLine(" -{0}", persons.PersonId);
                    


                }

                var person = new Person
                {
                    PersonId = 1111,
                    FirstName = "Britney",
                    LastName = "Spears",
                    City = "Chikago",
                    BirthDate = DateTime.Now
                };

                db.Persons.Add(person);
                var count1 = db.SaveChanges();
                Console.WriteLine("{0} person saved to database", count1);

                
            }

        }
    }
}
