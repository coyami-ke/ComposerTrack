using ComposerTrack.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using ComposerTrack.Views;

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
                return createProjectCommand ??
                    (createProjectCommand = new RelayCommand(obj =>
                    {
                        CreateProjectWindow window = new();
                        window.Show();
                        HomeWindow homeWindow = obj as HomeWindow;
                        homeWindow.Close();
                    }
                ));
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
#nullable enable
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
