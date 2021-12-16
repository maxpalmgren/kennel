using Kennel.Classes;
using Kennel.Interface;
using System.Collections.Generic;

namespace Kennel.Data
{
    public interface IDbLists
    {
        List<IAnimal> AnimalList { get; set; }
        List<IPerson> PersonList { get; set; }
    }
}