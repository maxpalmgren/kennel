using Kennel.Data;

namespace Kennel.Classes
{
    public interface IExtraServices
    {
        double Price { get; set; }

        void AddHaircut(int animal);
        void AddClawcut(int animal);
    }
}