using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer) //override ezme anlamına geliyor, classın içerisine method yazma
        {
            if(_customerCheckService.CheckIfRealPerson(customer)) 
            {
                base.Save(customer);
            }
            else
            {
                Console.WriteLine("Gerçek bir kişi değil");
            }
        }

      
    }
}
