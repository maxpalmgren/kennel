using Kennel.Classes;
using Kennel.Data;
using Kennel.Factories;
using Kennel.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel.MOCKDATA
{
    public class MockData : IMockData
    {
        public IDbLists Db { get; set; }

        public MockData(IDbLists db)
        {
            Db = db;
        }

        public void CreateMockData()
        {
            IPerson person1 = CustomerFactory.Create();
            person1.Name = "Max";
            Db.PersonList.Add(person1);
            IPerson person2 = CustomerFactory.Create();
            person2.Name = "Janne";
            Db.PersonList.Add(person2);
            IPerson person3 = CustomerFactory.Create();
            person3.Name = "Danne";
            Db.PersonList.Add(person3);
            IPerson person4 = CustomerFactory.Create();
            person4.Name = "Anders";
            Db.PersonList.Add(person4);
            IPerson person5 = CustomerFactory.Create();
            person5.Name = "Leffe";
            Db.PersonList.Add(person5);

            IAnimal animal1 = AnimalFactory.Create();
            animal1.Name = "Lassie";
            animal1.Owner = Db.PersonList[0];
            Db.AnimalList.Add(animal1);
            IAnimal animal2 = AnimalFactory.Create();
            animal2.Name = "Pluto";
            animal2.Owner = Db.PersonList[1];
            Db.AnimalList.Add(animal2);
            IAnimal animal3 = AnimalFactory.Create();
            animal3.Name = "Siri";
            animal3.Owner = Db.PersonList[2];
            Db.AnimalList.Add(animal3);
            IAnimal animal4 = AnimalFactory.Create();
            animal4.Name = "Scooby Doo";
            animal4.Owner = Db.PersonList[3];
            Db.AnimalList.Add(animal4);
            IAnimal animal5 = AnimalFactory.Create();
            animal5.Name = "Ringo";
            animal5.IsHere = true;
            animal5.Owner = Db.PersonList[4];
            Db.AnimalList.Add(animal5);
        }
    }
}
