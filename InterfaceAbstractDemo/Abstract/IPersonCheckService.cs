using InterfaceAbstractDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Abstract
{
    internal interface IPersonCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
