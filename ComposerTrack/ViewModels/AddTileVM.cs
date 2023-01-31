using ComposerTrack.Models;
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
    public class AddTileVM : INotifyPropertyChanged, IWindowData<List<TileData>>
    {
        public List<TileData> Data { get; set; }
        public object Sender { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(prop, new PropertyChangedEventArgs(prop));
        }
    }
}
