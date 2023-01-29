using ComposerTrack.Easing;
using ComposerTrack.Models;
using ComposerTrack.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

#nullable disable
namespace ComposerTrack.ViewModels
{
    public class HomeVM : INotifyPropertyChanged
    {
        private HomeModel selectedModel;
        private RelayCommand createProjectCommand;

        public ObservableCollection<HomeModel> HomeModels { get; set; }
        public RelayCommand CreateProjectCommand
        {
            get
            {
                return createProjectCommand ??= new ComposerTrack.ViewModels.RelayCommand(obj =>
                {
                    CreateProjectWindow window = new();
                    window.Show();
                });
            }
        }

        public HomeModel SelectedModel
        {
            get => selectedModel;
            set
            {
                selectedModel = value;
                OnPropertyChanged("SelectedModel");
            }
        }

        public HomeVM()
        {
            StreamReader stream = new("config.json");
            JsonSerializer serializer = new JsonSerializer();
            HomeModels = (ObservableCollection<HomeModel>)serializer.Deserialize(stream, typeof(HomeModel));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
