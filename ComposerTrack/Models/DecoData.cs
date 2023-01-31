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
    public class DecoData : INotifyPropertyChanged
    {
        private string id;
        private int tile;
        private string source;
        private Vector2 position;
        private float rotation;
        private Vector2 scale;
        private float opacity;

        public string ID
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }
        public int Tile
        {
            get { return tile; }
            set
            {
                tile = value;
                OnPropertyChanged();
            }
        }
        public string Source
        {
            get { return source; }
            set
            {
                source = value;
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
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
