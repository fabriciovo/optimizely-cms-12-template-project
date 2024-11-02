using empty_cms.Models.Pages;
using empty_cms.Models.Pages.ViewModels;
using EPiServer.Core;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace empty_cms.Controllers.Pages
{
    public class BasePageController<T> : PageController<T> where T : AbstractContentPage
    {
        protected IActionResult PageView(T model)
        {
            var viewModel = new PageViewModel<T>(model);
            viewModel.PageTitle ??= string.IsNullOrEmpty(model.PageTitle) ? model.Name : model.PageTitle;

            return View($"~/Views/Pages/{typeof(T).Name}.cshtml", viewModel);
        }
    }
}
