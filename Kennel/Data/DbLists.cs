using Kennel.Classes;
using Kennel.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel.Data
{
    public class DbLists : IDbLists
    {
        public List<IAnimal> AnimalList { get; set; }
        public List<IPerson> PersonList { get; set; }

        public DbLists()
        {
            AnimalList = new();
            PersonList = new();
        }
    }
}
