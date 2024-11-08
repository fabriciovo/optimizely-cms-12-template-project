using empty_cms.Models.Pages;
using empty_cms.Models.Pages.ViewModels;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace empty_cms.Controllers.Pages
{
    public class HomepageController : BasePageController<Homepage>
{
        private readonly IContentLoader _contentLoader;
        public HomepageController(IContentLoader contentLoader)
        {
            this._contentLoader = contentLoader;
        }
        public IActionResult Index(Homepage currentContent)
        {
            var viewModel = new HomepageViewModel(currentContent);

            viewModel.RelatedContent = this._contentLoader.GetChildren<AbstractContentPage>(currentContent.ContentLink);

            return PageView(viewModel);
        }
}
}
