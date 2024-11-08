using EPiServer.SpecializedProperties;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace empty_cms.Models.Blocks
{
    [ContentType(
      GUID = "69B1B479-BF5D-4E6E-BAF2-98ACCC123D86",
      DisplayName = "CTA Block")]
    public class CtaBlock : BlockData
    {
        [Display(
            Name = "Title",
            Description = "",
            Order = 100,
            GroupName = SystemTabNames.Content)]
        [CultureSpecific]
        [Required]
        [MaxLength(150)]
        public virtual required string Title { get; set; }


        [Display(
            Name = "Description",
            Description = "",
            Order = 300,
            GroupName = SystemTabNames.Content)]
        [CultureSpecific]
        [UIHint(UIHint.Textarea)]
        [Required]
        [MaxLength(300)]
        public virtual required string Description { get; set; }

        [Display(
            Name = "CTA",
            Description = "",
            Order = 200,
            GroupName = SystemTabNames.Content)]
        [CultureSpecific]
        [Required]
        public virtual required LinkItem PrimaryCta { get; set; }
    }
}