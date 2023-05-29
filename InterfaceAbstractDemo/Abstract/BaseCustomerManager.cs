using InterfaceAbstractDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Abstract
{
    internal abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
