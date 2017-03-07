using Microsoft.AspNetCore.Mvc;
using Backend.EF;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;

namespace Backend.Controllers
{
    public class TelerikDataController : Controller
    {
        private readonly EFContext _context;

        public TelerikDataController(EFContext context)
        {
            _context = context;
        }

        public DataSourceResult Read([DataSourceRequest] DataSourceRequest request)
        {
            var results = _context.Persons.ToDataSourceResult(request);
            return results;
        }

    }
}
