using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestMobile.Models;
using TestMobile.Services;
using Xamarin.Forms;

namespace TestMobile.ViewModels
{
    public class JokePageViewModel: INotifyPropertyChanged
    {
        private readonly HttpClient _client = new HttpClient();

        public List<Jokes> _jokesResult;
        public List<Jokes> JokesResult
        {
            get
            {
                return _jokesResult;
            }
            set
            {
                _jokesResult = value;
                OnPropertChanged(nameof(JokesResult));
            }
        }

        public string _jokeContent;
        public string JokeContent
        {
            get
            {
                return _jokeContent;
            }
            set
            {
                _jokeContent = value;
                OnPropertChanged(nameof(JokeContent));
            }
        }

        private void OnPropertChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }

        public ICommand JokeCommand { get; set; }

        public JokePageViewModel()
        {
            JokeCommand = new Command(async () =>
            {
                await GetJoke();
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public async Task GetJoke()
        {
            //JokeContent = await JokeService.GetJoke(url);
            var jokeResult = new Joke();
            var test = JokeContent;
            var url = $"{ApiUrlConstants.JokeUrl}?contains={JokeContent}&amount=5";

            var response = await _client.GetAsync(url);

            if(!response.IsSuccessStatusCode)
            {
                JokesResult = null;
            }
            var content = await response.Content.ReadAsStringAsync();
            jokeResult = JsonConvert.DeserializeObject<Joke>(content);
            JokesResult = jokeResult.jokes;

            return;
        }
    }
}
