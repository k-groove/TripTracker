using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace TripTracker
{
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            //InitializeComponent ();
            var map = new Map(
            MapSpan.FromCenterAndRadius(
                    new Position(37, -122), Distance.FromMiles(0.3)))
            {
                MapType = MapType.Street,
                IsShowingUser = true,
                HeightRequest = 400,
                WidthRequest = 400,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            var nameEntry = new Entry
            {
                Text = "What is the name of this location?",
                Placeholder = "Enter Name"
            };

            StackLayout stack = new StackLayout {
                Spacing = 0,
                HeightRequest = 400,
                WidthRequest = 400
            };

            stack.Children.Add(map);
            stack.Children.Add(nameEntry);
            Content = stack;
        }
    }
}
