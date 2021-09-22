using System;

namespace Fabryka_abstrakcyjna.Controls.Mac
{
    public class WindowsTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Windows textbox");
        }
    }
}