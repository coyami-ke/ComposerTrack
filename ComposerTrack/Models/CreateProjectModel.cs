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
    public class CreateProjectModel : INotifyPropertyChanged
    {
        private string name;
        private string id;
        private string author;
        
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string ID
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged("ID");
            }
        }
        public string Author
        {
            get => author;
            set
            {
                author = value;
                OnPropertyChanged("Author");
            }
        }
#nullable enable
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
