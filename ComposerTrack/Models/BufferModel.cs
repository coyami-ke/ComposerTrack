using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerTrack.Models
{
    public partial class BufferModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ObservableCollection<DecoData>> decorations;
        [ObservableProperty]
        private ObservableCollection<ObservableCollection<KeyFrame>> keyFrames;
    }
}
