using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SallesWebMvc.Models.Enums
{
    public enum SaleStatus : int
    {
        Pending,
        Billed,
        Canceled
    }
}
