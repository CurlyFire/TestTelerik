using Kendo.Mvc;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using FrontEnd.EF;

namespace FrontEnd.Controllers
{
    public class TestController : Controller
    {
        private readonly EFContext _context;

        public TestController(EFContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public DataSourceResult Read([DataSourceRequest] DataSourceRequest request)
        {
            var results = _context.Persons.ToDataSourceResult(request);
            var total = results.Total;
            return results;
        }

    }
}
