using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace CoffeHouse.Web.Models.Pages
{
    [ContentType(DisplayName = "Standard Page", 
        GUID = "c23c514e-3dbe-41b0-a230-e59aa6810886", 
        Description = "")]
    public class StandardPage : SitePageBase
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
    }
}