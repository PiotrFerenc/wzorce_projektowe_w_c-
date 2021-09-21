using System;
using Fabryka.Pictograms;

namespace Fabryka
{
    public class EmojiFactory
    {
        public Emoji CreateEmoji(EmojiType emojiType)
        {
            return emojiType switch
            {
                EmojiType.Happy => new HappyEmoji(),
                EmojiType.Sad => new SadEmoji(),
                _ => throw new ArgumentOutOfRangeException(nameof(emojiType), emojiType, null)
            };
        }
    }
}