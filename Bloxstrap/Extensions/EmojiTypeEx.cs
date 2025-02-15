﻿namespace Bloxstrap.Extensions
{
    static class EmojiTypeEx
    {
        public static IReadOnlyDictionary<string, EmojiType> Selections => new Dictionary<string, EmojiType>
        {
            { "Default (Twemoji)", EmojiType.Default },
            { "Catmoji", EmojiType.Catmoji },
            { "Windows 11", EmojiType.Windows11 },
            { "Windows 10", EmojiType.Windows10 },
            { "Windows 8", EmojiType.Windows8 },
        };

        public static IReadOnlyDictionary<EmojiType, string> Filenames => new Dictionary<EmojiType, string>
        {
            { EmojiType.Catmoji, "Catmoji.ttf" },
            { EmojiType.Windows11, "Win1122H2SegoeUIEmoji.ttf" },
            { EmojiType.Windows10, "Win10April2018SegoeUIEmoji.ttf" },
            { EmojiType.Windows8, "Win8.1SegoeUIEmoji.ttf" },
        };

        public static IReadOnlyDictionary<EmojiType, string> Hashes => new Dictionary<EmojiType, string>
        {
            { EmojiType.Catmoji, "98138f398a8cde897074dd2b8d53eca0" },
            { EmojiType.Windows11, "d50758427673578ddf6c9edcdbf367f5" },
            { EmojiType.Windows10, "d8a7eecbebf9dfdf622db8ccda63aff5" },
            { EmojiType.Windows8, "2b01c6caabbe95afc92aa63b9bf100f3" },
        };

        public static string GetHash(this EmojiType emojiType) => Hashes[emojiType];

        public static string GetUrl(this EmojiType emojiType)
        {
            if (emojiType == EmojiType.Default)
                return "";

            return $"https://github.com/NikSavchenk0/rbxcustom-fontemojis/raw/8a552f4aaaecfa58d6bd9b0540e1ac16e81faadb/{Filenames[emojiType]}";
        }
    }
}
