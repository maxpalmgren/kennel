using Kennel.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kennel.Classes
{
    class Dog : IAnimal
    {
        public string Name { get; set; }
        public IPerson Owner { get; set; }
        public bool IsHere { get; set; }
        public double Price { get; set; }
        public bool GotHaircut { get; set; }
        public bool GotClawcut { get; set; }

        public Dog()
        {
            GotHaircut = false;
            GotClawcut = false;
            IsHere = false;
            Price = 100.00;
        }
    }
}
