using empty_cms.Models.Blocks;
using empty_cms.Models.Pages;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;

namespace empty_cms.Business.Rendering
{
    [ServiceConfiguration]
    public class TemplateCoordinator : IViewTemplateModelRegistrator
    {
        public void Register(TemplateModelCollection viewTemplateModelRegistrator)
        {
            //Register Blocks
            RegisterBlock<ExampleBlock>(viewTemplateModelRegistrator);
            RegisterBlock<CardListBlock>(viewTemplateModelRegistrator);
            RegisterBlock<OtherCardBlock>(viewTemplateModelRegistrator);
            RegisterBlock<CardBlock>(viewTemplateModelRegistrator);
            RegisterBlock<OtherCardListBlock>(viewTemplateModelRegistrator);



            //Register Components
            RegisterPartial<AbstractContentPage>(viewTemplateModelRegistrator, "ExampleContentGeneric");


        }

        private void RegisterPartial<T>(TemplateModelCollection viewTemplateModelRegistrator, string tagName) where T : AbstractContentPage
        {
            viewTemplateModelRegistrator.Add(typeof(T), new TemplateModel
            {
                Name = $"Components-{tagName}",
                AvailableWithoutTag = false,
                Tags = new[] { tagName },
                Inherit = true,
                TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
                Path = $"~/Views/Components/{tagName}.cshtml"
            });

        }

        private void RegisterBlock<T>(TemplateModelCollection viewTemplateModelRegistrator) where T : BlockData
        {
            viewTemplateModelRegistrator.Add(typeof(T), new TemplateModel
            {
                Name = $"{typeof(T).Name}-Default",
                AvailableWithoutTag = true,
                TemplateTypeCategory = EPiServer.Framework.Web.TemplateTypeCategories.MvcPartialView,
                Path = $"~/Views/Blocks/{typeof(T).Name}.cshtml"
            });
        }
    }
}
