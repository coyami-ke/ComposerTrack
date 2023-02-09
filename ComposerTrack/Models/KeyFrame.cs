using AdofaiMapConverter.Types;
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
    public class KeyFrame : INotifyPropertyChanged
    {
        private Vector2 position;
        private float rotation;
        private Vector2 scale;
        private string id;
        private int beat;
        private bool isSelected;
        private double duration;
        private int opacity;
        private Ease ease;
        private string tag;
        private int startEndTile;

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
        public string ID
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }
        public int Beat
        {
            get { return beat; }
            set
            {
                beat = value;
                OnPropertyChanged();
            }
        }
        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                OnPropertyChanged();
            }
        }
        public double Duration
        {
            get { return duration; }
            set
            {
                duration = value;
                OnPropertyChanged();
            }
        }
        public int Opacity
        {
            get { return opacity; }
            set
            {
                opacity = value;
                OnPropertyChanged();
            }
        }
        public Ease Ease
        {
            get { return ease; }
            set
            {
                ease = value;
                OnPropertyChanged();
            }
        }
        public string Tag
        {
            get { return tag; }
            set
            {
                tag = value;
                OnPropertyChanged();
            }
        }
        public int StartEndTile
        {
            get { return startEndTile; }
            set
            {
                startEndTile = value;
                OnPropertyChanged();
            }
        }

#nullable enable
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
