using GameSalesService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesService.Abstract
{
    interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
