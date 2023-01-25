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

    public class AboutModel : INotifyPropertyChanged
    {
        private string nameProgram;
        private Version versionProgram;
        private string authorProgram;
        private string descriptionProgram;


        public string NameProgram
        {
            get => nameProgram;
            set
            {
                nameProgram = value;
                OnPropertyChanged("NameProgram");
            }
        }
        public Version VersionProgram
        {
            get => versionProgram;
            set
            {
                versionProgram = value;
                OnPropertyChanged("VersionProgram");
            }
        }
        public string AuthorProgram
        {
            get => authorProgram;
            set
            {
                authorProgram = value;
                OnPropertyChanged("Author");
            }
        }
        public string DescriptionProgram
        {
            get => descriptionProgram;
            set
            {
                descriptionProgram = value;
                OnPropertyChanged("Description");
            }
        }
#nullable enable
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
