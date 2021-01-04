using System.Collections.Generic;

namespace PocketApp
{
    public class Item
    {
        public string Title { get; }

        public string Source { get; }

        public int Duration { get; }

        public string ImageSource { get; }

        public IEnumerable<string> Tags { get; }

        public Item(string title, string source, int duration, string imageSource, IEnumerable<string> tags)
        {
            Title = title;
            Source = source;
            Duration = duration;
            ImageSource = imageSource;
            Tags = tags;
        }
    }
}
