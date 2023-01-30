using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace ComposerTrack.Models
{
    public class HomeModel : INotifyPropertyChanged
    {
        private string nameProject;
        private string pathToProject;

        public string NameProject
        {
            get => nameProject;
            set
            {
                nameProject = value;
                OnPropertyChanged("NameProject");
            }
        }
        public string PathToProject
        {
            get => pathToProject;
            set
            {
                pathToProject = value;
                OnPropertyChanged("PathToProject");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
