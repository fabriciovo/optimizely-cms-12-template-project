using empty_cms.Models.Pages;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;
using empty_cms.Utils;
using EPiServer.Shell.ObjectEditing;

namespace empty_cms.Models.Blocks
{
    [ContentType(
        DisplayName = "Other Card List Block",
        GUID = "D4E24103-1CF5-494A-8D9B-F8139F1A3C22"
    )]
    public class OtherCardListBlock : BlockData
    {
        [Display(
                Name = "Heading",
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        [Required] 
        [CultureSpecific]
        public virtual required string Heading { get; set; }

        [Display(
                Name = "Card LisFt Block",
            GroupName = SystemTabNames.Content,
            Order = 20
        )]
        [AllowedTypes(new[] { typeof(OtherCardBlock) })]
        [CultureSpecific]
        public virtual ContentArea? Cards { get; set; }

    }
}
