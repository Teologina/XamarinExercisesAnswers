using Xamarin.Forms;

using XamarinFormsExercises.Models;
using System.Reflection;

namespace XamarinFormsExercises.Views.UI
{
    public partial class SelectingValueExercisePage : ContentPage
    {
        public SelectingValueExercisePage()
        {
            InitializeComponent();
        }

        private void checkbox_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var chk = sender as CheckBox;
            lblPropChanged.IsVisible = chk.IsChecked;
           lblPropChanged.Text =  $"Box is checked: {chk.IsChecked}";
        }

        private void slider_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var sld = sender as Slider;
            lblPropChanged.Opacity = sld.Value / 100;
        }
  
        private void stepper_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var step = sender as Stepper;
            lblPropChanged.Text = $"Stepper is now changed and value is {step.Value}";
        }

        private void switch_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var sw = sender as Switch;
            lblPropChanged.IsVisible = sw.IsToggled;
            lblPropChanged.Text = $"switch is {sw.IsToggled}";
        }

        private void DatePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var dt = sender as DatePicker;
            lblPropChanged.Text = $"{dt.Date:F}";
        }

        private void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
        }

        private void picker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            
            
          
        }

        private void picker_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var pic = (Picker)sender;

            if (pic.SelectedIndex == -1) return;

            Person p1 = (Person)pic.SelectedItem;

            string p1asString = pic.Items[pic.SelectedIndex];
            Person p2 = (Person) pic.ItemsSource[pic.SelectedIndex];

            lblPropChanged.Text = $"Picker is now changed and is: {p1asString}";
            bwPropChanged.Color = (Color)p2.FavoriteColor;
            
        }

        private void lblPropChanged_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
       
        }
    }
}
