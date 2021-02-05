using GameSalesService.Abstract;
using GameSalesService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesService.Concrete
{
    class SummerSalesManager:BaseSalesManager
    {
        
        ICustomerCheckService _customerCheckService;
        public SummerSalesManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Buy(Customer customer,Games game)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                game.Price = game.Price * 0.5f; //this should be fixed after payment system is implemented. It's a demo.
                base.Buy(customer, game);
            }
            else
            {
                throw new Exception("Not a valid person.");
            }
        }
    }
}
