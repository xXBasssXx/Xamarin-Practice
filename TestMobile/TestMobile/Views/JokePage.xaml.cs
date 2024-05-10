using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TestMobile.Models;
using TestMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JokePage : ContentPage
    {
        public JokePage()
        {
            InitializeComponent();
            this.BindingContext = new JokePageViewModel(); 

        }

        async void SelectedJoke(object sender, ItemTappedEventArgs e)
        {
            var selectedJoke = (Jokes)e.Item;

            await DisplayAlert("Setup", selectedJoke.setup, "Okay?");

            await DisplayAlert("Punch Line", selectedJoke.delivery, "HAHA!");
        }

    }
}