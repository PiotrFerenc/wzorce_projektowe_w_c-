using Fabryka_abstrakcyjna.ControlFactory;

namespace Fabryka_abstrakcyjna
{
    public class TextEditor
    {
        private readonly IUIControlFactory _controlFactory;

        public TextEditor(IUIControlFactory controlFactory)
        {
            _controlFactory = controlFactory;
        }

        public void Render()
        {
            _controlFactory.CreateButton().Render();
            _controlFactory.CreateTextBox().Render();
            _controlFactory.CreateDropdownList().Render();
        }

        public void ClickButton()
        {
            _controlFactory.CreateButton().OnClick();
        }
    }
}