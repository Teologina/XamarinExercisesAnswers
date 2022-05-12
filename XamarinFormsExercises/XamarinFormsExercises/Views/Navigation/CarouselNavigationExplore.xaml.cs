﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsExercises.Views.Navigation
{
	public partial class CarouselNavigationExplore : CarouselPage
	{
		public CarouselNavigationExplore ()
		{
			InitializeComponent ();
			this.Children.Add(new WebViewExplorePage("https://www.svd.se"));
			this.Children.Add(new WebViewExplorePage("https://www.dn.se"));
			this.Children.Add(new WebViewExplorePage("https://www.cnn.com"));
		}
	}
}

