using ComposerTrack.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace ComposerTrack.ViewModels
{
    public class AboutVM : INotifyPropertyChanged
    {
        private AboutModel aboutModel;
        public AboutModel AboutModel
        {
            get => aboutModel;
            set
            {
                aboutModel = value;
                OnPropertyChanged("AboutModel");
            }
        }

        public AboutVM()
        {
            aboutModel = new();
            Assembly assembly = Assembly.GetExecutingAssembly();
            aboutModel.NameProgram = assembly.FullName;
            aboutModel.VersionProgram = assembly.GetName().Version;
            aboutModel.AuthorProgram = "dropsy";
        }
#nullable enable
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
