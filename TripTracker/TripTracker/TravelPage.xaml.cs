using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TripTracker
{
	public partial class TravelPage : ContentPage
	{
		public TravelPage ()
		{
            //InitializeComponent ();
            var stack = new StackLayout
            {
                Spacing = 0,
                HeightRequest = 400,
                WidthRequest = 400
            };

            //stack.Children.Add();
            Content = stack;
        }
	}
}
