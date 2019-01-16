using CoffeHouse.Web.Models.Pages;

namespace CoffeHouse.Web.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : SitePageBase
    {
        T CurrentPage { get; }
        StartPage StartPage { get; }
    }
}