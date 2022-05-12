using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XamarinFormsExercises.Models;

namespace XamarinFormsExercises.Views.ListViews
{
    public partial class ListViewGroupedExercisePage : ContentPage
    {
        //3. Order City.List by Continent, and Population and finally group by Continent.
        public ListViewGroupedExercisePage()
        {
            InitializeComponent();

            IEnumerable<City> items = City.List;
            var groupedList = items.OrderBy(x => x.Continent).ThenBy(y => y.Population).GroupBy(x => x.Continent);
            CustomGroupedList.ItemsSource = groupedList;
            
            // var groupedList = use OrderBy() and ThenBy() and finally GroupBy() to create the grouped list
        }

        private async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            City item = (City)e.Item;
            await DisplayAlert("Item Tapped", item.Name, "OK");
            ((ListView)sender).SelectedItem = null;
        }

        private async void LearnMoreButton_Clicked(object sender, EventArgs e)
        {
            var b = (Button)sender;
            var item = (City)b.CommandParameter;
            await DisplayAlert("Button Clicked", $"{item.Name} in {item.Continent} has a population of {item.Population}.", "OK");
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
    }
}