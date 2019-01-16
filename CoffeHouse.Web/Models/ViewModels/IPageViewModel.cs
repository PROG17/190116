using CoffeHouse.Web.Models.Pages;
using System.Collections.Generic;

namespace CoffeHouse.Web.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : SitePageBase
    {
        T CurrentPage { get; }
        StartPage StartPage { get; }

        IList<SitePageBase> TopMenu { get; }
    }
}