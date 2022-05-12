using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsExercises.Views.Navigation
{
	public partial class CarouselNavigationExercise : CarouselPage
	{
		public CarouselNavigationExercise()
		{
			InitializeComponent ();
			this.Children.Add(new WebViewExercisePage("https://www.svd.se", "SvD"));
			this.Children.Add(new WebViewExercisePage("https://www.dn.se", "DN"));
			this.Children.Add(new WebViewExercisePage("https://www.cnn.com", "CNN"));
		}
	}
}

