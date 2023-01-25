using ComposerTrack.Models;
using ComposerTrack.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace ComposerTrack.ViewModels
{
    public class CreateProjectVM : INotifyPropertyChanged
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
                        EditorWindow window = new(CreateProjectModel.Name, CreateProjectModel.ID, CreateProjectModel.Author);
                        window.Show();                    });
            }
        }

#nullable enable
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
