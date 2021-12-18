using Kennel.Data;

namespace Kennel.ExtraService
{
    public interface IExtraServices
    {
        public string Name { get; }
        public double Price { get; }
        public IDbLists Db { get; set; }

        public void AddExtraService();
    }
}