using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CoffeHouse.Web.Models.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace CoffeHouse.Web.Controllers
{
    public class StandardPageController : SitePageController<StandardPage>
    {
        public ActionResult Index(StandardPage currentPage)
        {
            var model = BuildViewModel(currentPage);

            return View(model);
        }
    }
}