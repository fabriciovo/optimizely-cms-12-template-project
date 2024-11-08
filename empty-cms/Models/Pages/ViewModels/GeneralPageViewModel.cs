
using System.ComponentModel.DataAnnotations;

namespace empty_cms.Models.Pages.ViewModels
{
    public class GeneralPageViewModel : PageViewModel<GeneralPage>
    {
        public GeneralPageViewModel(GeneralPage page) : base(page)
        {
        }

        [Display(Name = "Card List Block", GroupName = SystemTabNames.Content, Order = 1)]
        public virtual ContentReference CardListBlockContentReference { get; set; }
    }
}
