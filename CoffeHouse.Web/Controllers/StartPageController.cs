using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CoffeHouse.Web.Models.Pages;
using CoffeHouse.Web.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Data.Dynamic;
using EPiServer.Framework.DataAnnotations;
using EPiServer.ServiceLocation;
using EPiServer.Shell.Composition;
using EPiServer.Web.Mvc;

namespace CoffeHouse.Web.Controllers
{
    public class PageVisit
    {
        public DateTime VisitTime { get; set; }

        public Guid PageGuid { get; set; }
    }


    public class StartPageController : SitePageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            var model = BuildViewModel(currentPage);

            var store = DynamicDataStoreFactory.Instance.GetOrCreateStore(typeof(PageVisit));
            var visit = new PageVisit
            {
                VisitTime = DateTime.Now,
                PageGuid = currentPage.ContentGuid
            };
            store.Save(visit);

            var count = store.Items<PageVisit>().Where(p => p.PageGuid == currentPage.ContentGuid).Count();

            return View(model);
        }
    }
}