using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace empty_cms.Models.Pages {
    [ContentType (
        DisplayName ="Homepage",
        Description = "Homepage",
         GroupName = "Home",
        GUID = "b1b56e8c-5d87-4c7d-9d3f-67f3c15c4e8e")]
    public class Homepage : AbstractContentPage
    {

}
}
