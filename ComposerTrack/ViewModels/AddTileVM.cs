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
    public class AddTileVM : INotifyPropertyChanged
    {
        private ObservableCollection<TileData> tiles;
        private RelayCommand addTileCommmand;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(prop, new PropertyChangedEventArgs(prop));
        }
    }
}
