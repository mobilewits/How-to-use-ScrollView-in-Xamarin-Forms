using System;

using Xamarin.Forms;

namespace ScrollViewXamarinForms
{
	public class ScrollViewPage : ContentPage
	{
		public ScrollViewPage ()
		{
			StackLayout stack = new StackLayout ();
			for (var i=0; i<100; i++)
				stack.Children.Add (new Button { Text = "Button "+i});
			ScrollView scroll = new ScrollView {
				Content=stack
			};
			Content = scroll;
			Title="ScrollView";
		}
	}
}


