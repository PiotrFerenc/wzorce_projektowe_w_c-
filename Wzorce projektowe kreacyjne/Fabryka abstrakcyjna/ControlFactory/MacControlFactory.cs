using Fabryka_abstrakcyjna.Controls;
using Fabryka_abstrakcyjna.Controls.Mac;

namespace Fabryka_abstrakcyjna.ControlFactory
{
    public class MacControlFactory : IUIControlFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ITextBox CreateTextBox()
        {
            return new MacTextBox();
        }

        public IDropdownList CreateDropdownList()
        {
            return new MacDropdowList();
        }
    }
}