using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

using WebShopApp.Core.Contracts;
using WebShopApp.Models.Statistic;

namespace WebShopApp.Controllers
{
    public class StatisticController : Controller
    {
        private readonly IStatisticService _statisticService;

        public StatisticController(IStatisticService statisticService)
        {
            this._statisticService = statisticService;
        }
        public IActionResult Index()
        {
            StatisticVM statistics = new StatisticVM();
            statistics.CountClients = _statisticService.CountClients();
            statistics.CountProducts = _statisticService.CountProdcts();
            statistics.CountOrders = _statisticService.CountOrders();
            statistics.SumOrders = _statisticService.SumOrders();
            return View(statistics);
        }
    }
}
