using Kennel.Data;
using Kennel.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kennel.Factories;

namespace Kennel.Manager
{
    class CustomerManager : ICustomerManager
    {
        public IDbLists Db { get; set; }

        public CustomerManager(IDbLists db)
        {
            Db = db;
        }

        public void CreatePerson()
        {
            IPerson person = CustomerFactory.Create();
            Console.WriteLine("Write your name:");
            string personName = Console.ReadLine();
            person.Name = personName;
            Db.PersonList.Add(person);
            Console.WriteLine("Press enter to go back to Main Menu");
            Console.ReadLine();
            Console.Clear();
        }

        public void ListPersons()
        {
            foreach (var customer in Db.PersonList)
            {
                Console.WriteLine(customer.Name);
            }
            Console.WriteLine("Press enter to go back to the main menu");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
