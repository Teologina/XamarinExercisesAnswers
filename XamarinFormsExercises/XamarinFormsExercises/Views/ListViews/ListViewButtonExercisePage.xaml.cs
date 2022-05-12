using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;

using XamarinFormsExercises.Models;

namespace XamarinFormsExercises.Views.ListViews
{
    public partial class ListViewButtonExercisePage : ContentPage
    {
        public IEnumerable <City> CityList { get; }
        public ListViewButtonExercisePage()
        {
            
            InitializeComponent();
            //use City.List;
            CityList = City.List;
            ButtonList.ItemsSource = CityList;
            BindingContext = this;
        }

        private async void ButtonList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            City item = (City)e.Item;
            await DisplayAlert("Item Tapped", item.Name, "OK");
            ((ListView)sender).SelectedItem = null;
        }

        private async void MoreButton_Clicked(object sender, EventArgs e)
        {
            var b = (Button)sender;
            var item = (City)b.CommandParameter;
            await DisplayAlert("Button Clicked", $"{item.Name} in {item.Continent} has a population of {item.Population}.", "OK");
        }

        private async void LearnMoreButton_Clicked(object sender, EventArgs e)
        {
            var b = (Button)sender;
            var item = (City)b.CommandParameter;
            await DisplayAlert("Button Clicked", $"{item.Name} in {item.Continent} has a populaton of {item.Population}.", "Fuck Off");
        }

        protected async void HomeButton_Clicked(object sender, EventArgs e)
        {
            Type pageType = ((Button)sender).CommandParameter as Type;
            Page page = (Page)Activator.CreateInstance(pageType);
            await this.Navigation.PushAsync(page);
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

