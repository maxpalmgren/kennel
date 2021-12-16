using Kennel.Data;

namespace Kennel.Manager
{
    public interface IKennelManager
    {
        IDbLists Db { get; set; }

        void DropOffAnimal();
        void PickUpAnimal();
        void AddHaircut();
        void AddClawcut();
    }
}