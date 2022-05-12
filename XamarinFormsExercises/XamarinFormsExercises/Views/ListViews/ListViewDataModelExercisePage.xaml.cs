using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;

using XamarinFormsExercises.Models;

namespace XamarinFormsExercises.Views.ListViews
{
    public partial class ListViewDataModelExercisePage : ContentPage
    {
        public string Greetings { get; } = "Hello";
        public IEnumerable<CityPopulation> CityList { get; }
        public ListViewDataModelExercisePage()
        {
            InitializeComponent();




            CityList = CityPopulation.List;

            DataModelList.ItemsSource = CityPopulation.List;
            BindingContext = this;
        }

        async void ListViewItemTapped (object sender, ItemTappedEventArgs e)
        {
            CityPopulation item = (CityPopulation)e.Item;
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



        /*
              public ListViewDataModelExercisePage()
        {
            InitializeComponent();
            DataModelList.ItemsSource = CityPopulation.List;
        }

        async void ListViewItemTapped (object sender, ItemTappedEventArgs e)
        {
            CityPopulation item = (CityPopulation)e.Item;
            await DisplayAlert("Tapped", item.ToString(), "OK");
            ((ListView)sender).SelectedItem = null;
        }
        */
    }
}

