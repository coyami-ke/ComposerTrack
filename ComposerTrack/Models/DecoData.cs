using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace ComposerTrack.Models
{
    public partial class DecoData : ObservableObject
    {
        [ObservableProperty]
        private string tag;
        [ObservableProperty]
        private int tile;
        [ObservableProperty]
        private string source;
        [ObservableProperty]
        private Vector2 position;
        [ObservableProperty]
        private float rotation;
        [ObservableProperty]
        private Vector2 scale;
        [ObservableProperty]
        private float opacity;
        [ObservableProperty]
        private string color;
        [ObservableProperty]
        private int beat;
        [ObservableProperty]
        private bool isSelected;
    }
}
