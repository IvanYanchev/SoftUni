using CompanyHierarchy.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Interfaces
{
    interface ISalesEmployee
    {
        List<Sale> Sales { get; set; }
        void AddSale(Sale sale);
    }
}
