using System;
using System.ComponentModel.DataAnnotations;
using CoffeHouse.Web.Business;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace CoffeHouse.Web.Models.Pages
{
    [ContentType(DisplayName = "Start Page",
        GUID = "0ec44684-a165-414e-af2f-b4fb27ac781a",
        Description = "")]
    public class StartPage : SitePageBase
    {

        /*
[CultureSpecific]
[Display(
Name = "Main body",
Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
GroupName = SystemTabNames.Content,
Order = 1)]
public virtual XhtmlString MainBody { get; set; }
*/

        #region Site Settings


        [Display(GroupName = GroupNames.SiteSettings, Order = 100)]
        public virtual string SiteBrand { get; set; }

        [Display(GroupName = GroupNames.SiteSettings, Order = 200)]
        public virtual string SiteAddress { get; set; }

        [Display(GroupName = GroupNames.SiteSettings, Order = 300)]
        public virtual string SitePhone { get; set; }

        [Display(GroupName = GroupNames.SiteSettings, Order = 1400)]
        public virtual string SiteFooter { get; set; }

        #endregion
    }
}