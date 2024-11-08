using empty_cms.Models.Pages;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;
using empty_cms.Utils;
using EPiServer.Shell.ObjectEditing;

namespace empty_cms.Models.Blocks
{
    [ContentType(
        DisplayName = "Card List Block",
        GUID = "DED3045A-297A-432C-9D6D-E31E1C101FBB"
    )]
    public class CardListBlock : BlockData
    {
        [Display(
                Name = "Card List Block",
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        [AllowedTypes(new[] { typeof(CardBlock) })]
        [CultureSpecific]
        public virtual ContentArea? Cards { get; set; }

    }
}
