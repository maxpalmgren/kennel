using Kennel.Classes;
using Kennel.ExtraService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel.Factories
{
    public static class AnimalFactory
    {
        public static IAnimal Create()
        {
            return new Dog();
        }
    }
}
