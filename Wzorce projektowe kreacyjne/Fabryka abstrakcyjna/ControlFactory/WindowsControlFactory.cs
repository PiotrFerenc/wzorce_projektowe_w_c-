using Fabryka_abstrakcyjna.Controls;
using Fabryka_abstrakcyjna.Controls.Mac;

namespace Fabryka_abstrakcyjna.ControlFactory
{
    public class WindowsControlFactory : IUIControlFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ITextBox CreateTextBox()
        {
            return new WindowsTextBox();
        }

        public IDropdownList CreateDropdownList()
        {
            return new WindowsDropdowList();
        }
    }
}