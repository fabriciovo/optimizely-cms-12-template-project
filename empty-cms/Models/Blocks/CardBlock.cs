
using empty_cms.Models.Pages;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;
using empty_cms.Utils;
using EPiServer.Shell.ObjectEditing;
using EPiServer.SpecializedProperties;

namespace empty_cms.Models.Blocks
{
    [ContentType(
        DisplayName = "Card Block",
        GUID = "C5D83E22-3FE5-471A-801D-8583E0D6CB28"
    )]
    public class CardBlock : BlockData
    {
        [Display(
            Name = "Card Image",
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        [Required]
        [UIHint(UIHint.Image)]
        public virtual required ContentReference Image { get; set; }

        [Display(
        Name = "Title",
            GroupName = SystemTabNames.Content,
            Order = 20
        )]
        [Required]
        public virtual required string Title { get; set; }

        [Display(
            Name = "Description",
                GroupName = SystemTabNames.Content,
                Order = 30
            )]
        [Required]
        public virtual required string Description { get; set; }


        [Display(
        Name = "Read More",
            GroupName = SystemTabNames.Content,
            Order = 40
        )]
        [Required]
        public virtual required LinkItem ReadMore {get; set; }


    }
}
