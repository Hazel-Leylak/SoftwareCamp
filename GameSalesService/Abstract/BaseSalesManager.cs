using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSalesService.Entities;

namespace GameSalesService.Abstract
{
    public abstract class BaseSalesManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }

        public virtual void Buy(Customer customer,Games game)
        {
            Console.WriteLine("Purchased " + game.Name + " by " + customer.FirstName + " " + customer.LastName+" $"+game.Price);
        }

       
    }
}
