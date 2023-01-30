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
        private ObservableCollection<HomeModel> homeModels;

        
        public RelayCommand CreateProjectCommand
        {
            get
            {
                return createProjectCommand ??= new RelayCommand(obj =>
                {
                    CreateProjectWindow window = new();
                    window.ShowDialog();

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
        public ObservableCollection<HomeModel> HomeModels
        {
            get { return homeModels; }
            set
            {
                homeModels = value;
                OnPropertyChanged();
            }
        }

        public HomeVM()
        {
            if (!File.Exists("projects.json")) return;
            FileStream stream = new("projects.json", FileMode.Append);
            StreamReader reader = new(stream);
            JsonSerializer serializer = new();
            HomeModels = (ObservableCollection<HomeModel>)serializer.Deserialize(reader, typeof(ObservableCollection<HomeModel>));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
