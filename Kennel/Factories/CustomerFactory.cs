using Kennel.Classes;
using Kennel.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel.Factories
{
    public static class CustomerFactory
    {
        public static IPerson Create()
        {
            return new Customer();
        }
    }
}
