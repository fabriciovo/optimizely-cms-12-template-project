using empty_cms.Models.Pages;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace empty_cms.Controllers.Pages
{
    public class GeneralPageController : BasePageController<GeneralPage>
    {
        public IActionResult Index(GeneralPage currentContent)
        {
            return PageView(currentContent);
        }
    }
}
