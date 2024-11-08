using EPiServer.Shell.ObjectEditing;

namespace empty_cms.Utils
{
    public enum BorderTypeEnum
    {
        Yellow,
        SherpaBlue
    }
    public class CardBorderType : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections()
        {
            return new List<ISelectItem>
            {
                new SelectItem() { Value = "#F3B500", Text = "Yellow" },
                new SelectItem() { Value = "#012F3C", Text = "Sherpa Blue" }
            };
        }

        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return new List<ISelectItem>
            {
                new SelectItem() { Value = "#F3B500", Text = "Yellow" },
                new SelectItem() { Value = "#012F3C", Text = "Sherpa Blue" }
            };
        }
    }
}
