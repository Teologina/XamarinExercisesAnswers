using System;
using System.Collections.Generic;

using Xamarin.Forms;

using XamarinFormsExercises.Models;

namespace XamarinFormsExercises.Views.ListViews
{
    public partial class ListViewImageExercisePage : ContentPage
    {
        public IEnumerable<CityPicture> CityList { get;}
        public ListViewImageExercisePage()
        {
            InitializeComponent();
            //use CityPicture.List;

            CityList = CityPicture.List;
            ImageList.ItemsSource = CityList;
            BindingContext = this;

        }

        private async void ImageList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            CityPicture item = (CityPicture)e.Item;

            await DisplayAlert("Tapped", item.ToString(), "OK");

            ((ListView)sender).SelectedItem = null;
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            Type page = ((Button)sender).CommandParameter as Type;
            Page pageType = (Page)Activator.CreateInstance(page);
            await this.Navigation.PushAsync(pageType);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            Type page = ((Button)sender).CommandParameter as Type;
            Page pageType = (Page)Activator.CreateInstance(page);
            await this.Navigation.PushAsync(pageType);
        }
    }
}

