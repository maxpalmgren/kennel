using Kennel.ExtraService;
using Kennel.Interface;
using System.Collections.Generic;

namespace Kennel.Classes
{
    public interface IAnimal
    {
        public string Name { get; set; }
        public IPerson Owner { get; set; }
        public bool IsHere { get; set; }
        public double Price { get; set; }
        public List<IExtraServices> ExtraServices { get; set; }
    }
}