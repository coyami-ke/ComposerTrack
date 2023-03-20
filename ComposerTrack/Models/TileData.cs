using CommunityToolkit.Mvvm.ComponentModel;
using ComposerTrack.Easing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
#nullable disable
namespace ComposerTrack.Models
{
    /// <summary>
    /// Data for keeping of tiles
    /// </summary>
    public partial class TileData : ObservableObject
    {
        [ObservableProperty]
        private float angle;
        [ObservableProperty]
        private int number;
        [ObservableProperty]
        private Vector2 position;
        [ObservableProperty]
        private float rotation;
        [ObservableProperty]
        private Vector2 scale;
        [ObservableProperty]
        private int opacity;
        [ObservableProperty]
        private bool isSelected;
    }
}
