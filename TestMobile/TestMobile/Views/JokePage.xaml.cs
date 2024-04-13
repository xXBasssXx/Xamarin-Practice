using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}