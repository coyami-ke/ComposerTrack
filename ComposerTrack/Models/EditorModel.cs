using CommunityToolkit.Mvvm.ComponentModel;
using ComposerTrack.Views.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace ComposerTrack.Models
{
    public partial class EditorModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<KeyFrame> keyFrames;
        [ObservableProperty]
        private ObservableCollection<DecoData> decorations;
        [ObservableProperty]
        private ObservableCollection<KeyFrameControl> keyFrameControls;
        [ObservableProperty]
        private int durationAnimtion;
    }
}
