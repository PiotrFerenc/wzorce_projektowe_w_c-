using System;

namespace Fabryka_abstrakcyjna.Controls.Mac
{
    public class WindowsButton : IButton
    { 
        public void Render()
        {
            Console.WriteLine("Windows Button");
        }

        public void OnClick()
        {
            Console.WriteLine("Windows Button Clicked");
        }
    }
}