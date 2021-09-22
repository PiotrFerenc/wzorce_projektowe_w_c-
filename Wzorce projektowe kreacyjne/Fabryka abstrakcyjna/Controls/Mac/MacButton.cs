using System;

namespace Fabryka_abstrakcyjna.Controls.Mac
{
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Mac Button");
        }

        public void OnClick()
        {
            Console.WriteLine("Mac Button Clicked");
        }
    }
}