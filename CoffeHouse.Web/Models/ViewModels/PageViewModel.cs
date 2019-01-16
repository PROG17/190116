using CoffeHouse.Web.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeHouse.Web.Models.ViewModels
{
    public class PageViewModel<T> : IPageViewModel<T> where T : SitePageBase
    {
        public T CurrentPage { get; }

        public StartPage StartPage { get; }

        public IList<SitePageBase> TopMenu { get; set; }

        public PageViewModel(T currentPage, StartPage startPage)
        {
            CurrentPage = currentPage;
            StartPage = startPage;

            
        }
    }
}