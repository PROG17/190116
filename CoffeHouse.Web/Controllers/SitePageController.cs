using CoffeHouse.Web.Models.Pages;
using CoffeHouse.Web.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeHouse.Web.Controllers
{
    public class SitePageController<T>: PageController<T> where T : SitePageBase
    {
        protected PageViewModel<T> BuildViewModel(T currentPage)
        {
            var loader = ServiceLocator.Current.GetInstance<IContentLoader>();
            var startPage = loader.Get<StartPage>(ContentReference.StartPage);

            var ancestors = loader.GetAncestors(currentPage.ContentLink);

            var pages = new List<SitePageBase>();
            pages.Add(startPage);
            pages.AddRange(loader.GetChildren<SitePageBase>(ContentReference.StartPage));

            var FilteredListOfPages = FilterForVisitor.Filter(pages).Cast<SitePageBase>().Where(p => p.VisibleInMenu == true).ToList();

            var model = new PageViewModel<T>(currentPage, startPage);
            model.TopMenu = FilteredListOfPages;

            return model;
        }
    }
}