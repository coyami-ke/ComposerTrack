using ComposerTrack.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace ComposerTrack.ViewModels
{
    public class EditorVM : INotifyPropertyChanged
    {
        private ObservableCollection<KeyFrame> keyFrames;
        private EditorModel editorModel;

        public ObservableCollection<KeyFrame> KeyFrames
        {
            get { return keyFrames; }
            set
            {
                keyFrames = value;
                OnPropertyChanged();
            }
        }
        public EditorModel EditorModel
        {
            get => editorModel;
            set
            {
                editorModel = value;
                OnPropertyChanged("EditorModel");
            }
        }

        public EditorVM()
        {
            EditorModel = new EditorModel();
            KeyFrames = new ObservableCollection<KeyFrame>();
        }


#nullable enable
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
