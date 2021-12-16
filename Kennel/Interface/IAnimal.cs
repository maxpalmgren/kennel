using Kennel.Interface;

namespace Kennel.Classes
{
    public interface IAnimal
    {
        public string Name { get; set; }
        public IPerson Owner { get; set; }
        public bool IsHere { get; set; }
        public double Price { get; set; }
        public bool GotHaircut { get; set; }
        public bool GotClawcut { get; set; }
    }
}