using ComposerTrack.Models;
using ComposerTrack.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
#nullable disable
namespace ComposerTrack.ViewModels
{
    public class CreateProjectVM : INotifyPropertyChanged, IWindowData<CreateProjectModel>
    {
        private CreateProjectModel createProjectModel;
        private RelayCommand createCommand;

        public CreateProjectModel CreateProjectModel
        {
            get => createProjectModel;
            set
            {
                createProjectModel = value;
                OnPropertyChanged("CreateProjectModel");
            }
        }
        public RelayCommand CreateCommand
        {
            get
            {
                return createCommand ??= new RelayCommand(obj =>
                    {
                    });
            }
        }

        public CreateProjectModel Data { get; set; }
        public object Sender { get; set; }

        public CreateProjectVM()
        {
            CreateProjectModel = new();
        }

#nullable enable
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
