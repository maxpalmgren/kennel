using Kennel.Data;

namespace Kennel.MOCKDATA
{
    public interface IMockData
    {
        IDbLists Db { get; set; }

        public void CreateMockData();
    }
}