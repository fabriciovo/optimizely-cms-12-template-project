using empty_cms.Models.Pages;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace empty_cms.Controllers.Pages
{
    public class HomepageController : BasePageController<Homepage>
{
        public IActionResult Index(Homepage currentContent)
        {
            return PageView(currentContent);
        }
}
}
