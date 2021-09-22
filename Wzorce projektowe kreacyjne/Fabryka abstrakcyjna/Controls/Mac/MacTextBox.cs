using System;

namespace Fabryka_abstrakcyjna.Controls.Mac
{
    public class MacTextBox : ITextBox
    {
 
        public void Render()
        {
            Console.WriteLine("Mac textbox");
        }
    }
}