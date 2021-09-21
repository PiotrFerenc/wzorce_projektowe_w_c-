using System;

namespace Fabryka.Pictograms
{
    public class HappyEmoji : Emoji
    {
        public override void Render()
        {
            var text = new WenceyWang.FIGlet.AsciiArt(":)");
            text.ToString();  
            var result = text.Result;  

            foreach (var line in result)
            {
                Console.WriteLine(line);
            }
        }
    }
}