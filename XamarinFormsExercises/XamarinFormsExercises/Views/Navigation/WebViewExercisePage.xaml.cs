using System.Web;
using Xamarin.Forms;

namespace XamarinFormsExercises.Views.Navigation
{
    public partial class WebViewExercisePage : ContentPage
    {
        public WebViewExercisePage()
        {
            InitializeComponent();
         }
        public WebViewExercisePage(string Url, string title)
        {
            InitializeComponent();
            myWebView.Source = new UrlWebViewSource
            {
                Url = HttpUtility.UrlDecode(Url)
            };
            this.Name = title;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Title = this.Title;
            
        }
        public string Name { get; set; }
    }
}
