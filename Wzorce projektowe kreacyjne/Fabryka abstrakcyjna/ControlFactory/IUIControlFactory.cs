using Fabryka_abstrakcyjna.Controls;

namespace Fabryka_abstrakcyjna.ControlFactory
{
    public interface IUIControlFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
        IDropdownList CreateDropdownList();
    }
}