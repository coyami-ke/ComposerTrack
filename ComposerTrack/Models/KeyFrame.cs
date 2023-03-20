using AdofaiMapConverter.Types;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Vector2 = System.Numerics.Vector2;

#nullable disable
namespace ComposerTrack.Models
{
    public partial class KeyFrame : ObservableObject
    {
        [ObservableProperty]
        private Vector2 position;
        [ObservableProperty]
        private float rotation;
        [ObservableProperty]
        private Vector2 scale;
        [ObservableProperty]
        private string iD;
        [ObservableProperty]
        private int beat;
        [ObservableProperty]
        private bool isSelected;
        [ObservableProperty]
        private double duration;
        [ObservableProperty]
        private int opacity;
        [ObservableProperty]
        private Ease ease;
        [ObservableProperty]
        private string tag;
        [ObservableProperty]
        private int startEndTile;
        [ObservableProperty]
        private float offset;
    }
}
