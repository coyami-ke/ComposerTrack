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
    public class TileData : INotifyPropertyChanged
    {
        private int number;
        private Vector2 position;
        private float rotation;
        private Vector2 scale;
        public float opacity;

        public int Number
        {
            get { return number; }
            set
            {
                number = value;
                OnPropertyChanged();
            }
        }
        public Vector2 Position
        {
            get { return position; }
            set
            {
                position = value;
                OnPropertyChanged();
            }
        }
        public float Rotation
        {
            get { return rotation; }
            set
            {
                rotation = value;
                OnPropertyChanged();
            }
        }
        public Vector2 Scale
        {
            get { return scale; }
            set
            {
                scale = value;
                OnPropertyChanged();
            }
        }
        public float Opacity
        {
            get { return opacity; }
            set
            {
                opacity = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(PropertyChanged, new PropertyChangedEventArgs(prop));
        }
    }
}
