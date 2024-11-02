
using empty_cms.Models.Pages;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace empty_cms.Models.Blocks
{
    [ContentType(
        DisplayName = "Grid Links Block",
        GUID = "24C320B0-ACE9-4EDE-B3A5-EAD3A28CB6D6"
    )]
    public class LinkGridBlock : BlockData
    {
        [Display(
                Name = "links",
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        [AllowedTypes(AllowedTypes = new[] { typeof(AbstractContentPage) })]
        public virtual ContentArea? Links { get; set; }

    }
}
