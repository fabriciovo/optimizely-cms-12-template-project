using empty_cms.Models.Blocks;
using empty_cms.Models.Pages;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;

namespace empty_cms.Utils.Rendering
{
    [ServiceConfiguration]
    public class TemplateCoordinator : IViewTemplateModelRegistrator
    {
        public void Register(TemplateModelCollection viewTemplateModelRegistrator)
        {
            RegisterBlock<ExampleBlock>(viewTemplateModelRegistrator);
            RegisterBlock<LinkGridBlock>(viewTemplateModelRegistrator);

 

            viewTemplateModelRegistrator.Add(typeof(AbstractContentPage), new EPiServer.DataAbstraction.TemplateModel
            {
                Name = "AbstractContentPage-LinkGridBlock",
                AvailableWithoutTag = false,
                Tags = new[] { "LinkGrid" },
                Inherit = true,
                TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
                Path = "~/Views/AbstractContentPage/LinkGrid.cshtml"
            });
        }
        private void RegisterBlock<T>(TemplateModelCollection viewTemplateModelRegistrator) where T : BlockData
        {
            viewTemplateModelRegistrator.Add(typeof(T), new EPiServer.DataAbstraction.TemplateModel
            {
                Name = $"{typeof(T).Name}-Default",
                AvailableWithoutTag = true,
                TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
                Path = $"~/Views/Blocks/{typeof(T).Name}.cshtml"
            });
        }
    }
}
