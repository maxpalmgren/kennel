using Kennel.Data;

namespace Kennel.Manager
{
    public interface ICustomerManager
    {
        IDbLists Db { get; set; }

        void CreatePerson();
        void ListPersons();
    }
}