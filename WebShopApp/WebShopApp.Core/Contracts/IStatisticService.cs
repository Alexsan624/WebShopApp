using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopApp.Core.Contracts
{
    public interface IStatisticService
    {
        int CountProdcts();
        int CountClients();
        int CountOrders();
        decimal SumOrders();
    }
}
