using Kennel.Data;

namespace Kennel.Manager
{
    public interface IAnimalManager
    {
        IDbLists Db { get; set; }

        void CreateAnimal();
        void ListAnimal();
        public void ListCheckedInAnimalsAndOwners();
    }
}