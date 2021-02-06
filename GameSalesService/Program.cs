using GameSalesService.Abstract;
using GameSalesService.Adapters;
using GameSalesService.Concrete;
using GameSalesService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesService
{
    class Program
    {
        static void Main(string[] args)
        {
            Games game = new Games()
            {
                Id = 1,
                Name = "Age Of Empires II",
                Price = 30.0f,
                Category = "Strategy"
            };
            Customer customer = new Customer()
            {
                FirstName = "Hazel",
                LastName = "L",
                Id = 1,
                NationalityId = "11111111",
                DateOfBirth= new DateTime(1999,2,23)
            };
            BaseSalesManager salesManager = new SummerSalesManager(new CheckServiceAdapter());
            salesManager.Buy(customer, game);
            Console.ReadKey();
        }
    }
}
