using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMobile.ViewModels;
using TestMobile.Views;
using Xamarin.Forms;

namespace TestMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }

        async void StartButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JokePage());
        }
    }
}
