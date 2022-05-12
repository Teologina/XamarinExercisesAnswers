using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XamarinFormsExercises.Models;

namespace XamarinFormsExercises.Views.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedContentExercisePage : TabbedPage
     {
        public IEnumerable<CityPopulation> CityPopList;
        public TabbedContentExercisePage()
        {
            InitializeComponent();

            CityPopList = CityPopulation.List;
            this.ItemsSource = CityPopList;
        //    CurrentPageChanged += CurrentPageHasChanged;

        }
      //  private void CurrentPageHasChanged(object sender, EventArgs e) => Title = CurrentPage.Title;
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Title = CurrentPage.Title;
        }

    }
}