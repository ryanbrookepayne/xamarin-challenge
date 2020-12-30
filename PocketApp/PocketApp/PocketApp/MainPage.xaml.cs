using System.Collections.Generic;

namespace PocketApp
{
    public partial class MainPage
    {
        public IList<Item> Items { get; }

        public MainPage()
        {
            InitializeComponent();

            Items = new List<Item>
            {
                new Item(
                    "Create a kickass banking app using a BasePage in Xamarin",
                    "thewissen.io",
                    4,
                    "https://picsum.photos/180/120",
                    new[] {"software engineering"}
                ),
                new Item(
                    "The rise of few-maintainer projects",
                    "increment.com",
                    7,
                    "https://picsum.photos/180/120",
                    new[] {"Best Of", "software engineering"}
                ),
                new Item(
                    "'Toxic Individualism': Pandemic Politics Driving Health Care Workers From Small Towns",
                    "NPR",
                    4,
                    "https://picsum.photos/180/120",
                    new[] {"Trending"}
                )
            };

            BindingContext = this;
        }
    }
}
