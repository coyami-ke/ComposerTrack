using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

#nullable disable
namespace ComposerTrack.Models
{
    public class AnimatorModel : INotifyPropertyChanged
    {
        private ObservableCollection<MenuItem> contextMenuItems;
        public ObservableCollection<MenuItem> ContextMenuItems
        {
            get { return contextMenuItems; }
            set
            {
                contextMenuItems = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
