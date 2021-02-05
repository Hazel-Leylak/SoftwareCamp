using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesService.Entities
{
    public class Games
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Category { get; set; }
    }
}
