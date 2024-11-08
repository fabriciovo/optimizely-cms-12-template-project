using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace empty_cms.Models.Media
{
    [ContentType(
        DisplayName = "Image",
        GUID = "A70EB17D-D947-41E3-BF6B-1AFCAF952BC2"
    )]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,png")]
    public class ImageFile : ImageData
    {
        [Display(
            Name = "Alt Text"
            )]
        [Required]
        public virtual required string AltText { get; set; }

    }
}
