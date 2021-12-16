using Kennel.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kennel.Classes
{
    public class Customer : IPerson
    {

        public string Name { get; set; }
        public IAnimal Dog { get; set; }

    }  
}
