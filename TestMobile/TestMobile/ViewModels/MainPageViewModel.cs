using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace TestMobile.ViewModels
{
    public class MainPageViewModel
    {
        public string WelcomeText { get; set; }
        public MainPageViewModel()
        {
            WelcomeText = "Welcome to Joke Time!";
        }
    }
}
