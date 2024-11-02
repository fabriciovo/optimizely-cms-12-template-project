
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace empty_cms.Models.Blocks
{
    [ContentType(
        DisplayName = "Example of Section Block",
        GUID = "76F13D3E-E54E-4543-8DBB-0ABC9479DD4E"
    )]
    public class ExampleBlock : BlockData
    {
        [Display(
                Name = "Headline",
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        public virtual string? Headline { get; set; }

        [Display(
            Name = "Body",
            GroupName = SystemTabNames.Content,
            Order = 20
        )]
        public virtual XhtmlString? Body { get; set; }

        [Display(
            Name = "Image",
            GroupName = SystemTabNames.Content,
            Order = 30
        )]
        [UIHint(UIHint.Image)]
        public virtual ContentReference? Image { get; set; }
    }
}
