
using empty_cms.Models.Pages;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;
using empty_cms.Utils;
using EPiServer.Shell.ObjectEditing;

namespace empty_cms.Models.Blocks
{
    [ContentType(
        DisplayName = "Other Card Block",
        GUID = "976E25B0-930B-49AD-B624-47F25E2E8E3E"
    )]
    public class OtherCardBlock : BlockData
    {
        [Display(
        Name = "Card Name",
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        [Required]
        public virtual required string CardName { get; set; }

        [Display(
            Name = "Card Image",
            GroupName = SystemTabNames.Content,
            Order = 20
        )]
        [Required]
        [UIHint(UIHint.Image)]
        public virtual required ContentReference Image { get; set; }

        [Display(
        Name = "Card Link",
            GroupName = SystemTabNames.Content,
            Order = 30
        )]

        [AllowedTypes(AllowedTypes = new[] { typeof(AbstractContentPage) })]
        public virtual ContentReference? Link { get; set; }

        [Display(
        Name = "Border Type",
            GroupName = SystemTabNames.Content,
            Order = 40
        )]
        [SelectOne(SelectionFactoryType = typeof(CardBorderType))]
        [Required]
        public virtual required string BorderType { get; set; }
    }
}
