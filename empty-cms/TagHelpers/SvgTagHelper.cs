using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace empty_cms.TagHelpers
{
    [HtmlTargetElement("svg-partial", Attributes = "src")]
    public class SvgTagHelper : TagHelper
    {
        private readonly IWebHostEnvironment _environment;

        public SvgTagHelper(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public required string Src { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);

            if (string.IsNullOrWhiteSpace(Src))
            {
                output.SuppressOutput();
                return;
            }

            string svgFilePath = Path.Combine(_environment.WebRootPath, "svgs", Src);

            if (!File.Exists(svgFilePath))
            {
                output.SuppressOutput();
                return;
            }

            var svgContent = File.ReadAllText(svgFilePath);

            output.TagName = null;
            output.Content.SetHtmlContent(svgContent);
        }
    }
}