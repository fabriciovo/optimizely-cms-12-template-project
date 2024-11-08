using EPiServer.Core;
using empty_cms.Models.Blocks;

namespace empty_cms.ViewModels
{
    public class CardListBlockViewModel
    {
        public required CardListBlock CardListBlock { get; set; }
        public required ContentArea Cards { get; set; }
    }
}
