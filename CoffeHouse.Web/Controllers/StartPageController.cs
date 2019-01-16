using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CoffeHouse.Web.Models.Pages;
using CoffeHouse.Web.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;

namespace CoffeHouse.Web.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            var loader = ServiceLocator.Current.GetInstance<IContentLoader>();
            var startPage = loader.Get<StartPage>(ContentReference.StartPage);

            var model = new PageViewModel<StartPage>(currentPage, startPage);

            return View(model);
        }
    }
}