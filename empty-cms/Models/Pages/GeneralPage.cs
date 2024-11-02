using empty_cms.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace empty_cms.Models.Pages
{
    [ContentType(
        DisplayName = "Genreal Page",
        GroupName = "General Pages",
        GUID = "92059C83-1B92-42C5-BA61-9E02D0B180C4")]
    public class GeneralPage : AbstractContentPage
    {
        [Display(
            Name = "Headline",
            GroupName = SystemTabNames.Content,
            Order = 10
            )]
        public virtual string? Headline { get; set; }

        [Display(
    Name = "Headline Slug",
    GroupName = SystemTabNames.Content,
    Order = 20
    )]
        public virtual string? HeadlineSlug { get; set; }

    

    [Display(
        Name = "Body",
        GroupName = SystemTabNames.Content,
        Order = 30
        )]
    public virtual XhtmlString? Body { get; set; }

        [Display(
    Name = "Content Area",
    GroupName = SystemTabNames.Content,
    Order = 40
    )]
        [AllowedTypes(AllowedTypes = new[] {typeof(ExampleBlock), typeof(LinkGridBlock)})]
        public virtual ContentArea? ContentArea { get; set; }

    }

}

