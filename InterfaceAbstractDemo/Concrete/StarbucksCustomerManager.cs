using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    internal class StarbucksCustomerManager:BaseCustomerManager
    {
        IPersonCheckService _personCheckService;

        public StarbucksCustomerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        public override void save(Customer customer)
        {
            if (_personCheckService.CheckIfRealPerson(customer))
            {
                Console.WriteLine("Saved");
            }
            else
            {
                throw new Exception("Not a valid number");
            }
            base.save(customer);
        }
    }
}
