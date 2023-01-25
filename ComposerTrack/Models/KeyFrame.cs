using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace ComposerTrack.Models
{
    public class KeyFrame : INotifyPropertyChanged
    {
        private float positionX;
        private float positionY;
        private float rotation;
        private float scaleX;
        private float scaleY;
        private string id;
        private uint bit;
        private bool isSelected;

        public float PositionX
        {
            get { return  positionX; } 
            set
            {
                positionX = value;
                OnPropertyChanged();
            }
        }
        public float PositionY
        {
            get { return positionY;}
            set
            {
                positionY = value;
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
        public float ScaleX
        {
            get { return scaleX; }
            set
            {
                scaleX = value;
                OnPropertyChanged();
            }
        }
        public float ScaleY
        {
            get { return scaleY; }
            set
            {
                scaleY = value;
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
        public uint Bit
        {
            get { return bit; }
            set
            {
                bit = value;
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
        public static KeyFrame operator +(KeyFrame value1, KeyFrame value2)
        {
            KeyFrame keyFrame = new();
            keyFrame.ID = value1.ID;
            keyFrame.Rotation = value1.Rotation + value2.Rotation;
            keyFrame.PositionX = value1.PositionX + value2.PositionX;
            keyFrame.PositionY = value1.PositionY + value2.PositionY;
            keyFrame.ScaleX = value1.ScaleX + value2.ScaleX;
            keyFrame.ScaleY = value1.ScaleY + value2.ScaleY;
            return keyFrame;
        }
        public static KeyFrame operator -(KeyFrame value1, KeyFrame value2)
        {
            KeyFrame keyFrame = new();
            keyFrame.ID = value1.ID;
            keyFrame.Rotation = value1.Rotation - value2.Rotation;
            keyFrame.PositionX = value1.PositionX - value2.PositionX;
            keyFrame.PositionY = value1.PositionY - value2.PositionY;
            keyFrame.ScaleX = value1.ScaleX - value2.ScaleX;
            keyFrame.ScaleY = value1.ScaleY - value2.ScaleY;
            return keyFrame;
        }
        public static KeyFrame operator *(KeyFrame value1, KeyFrame value2)
        {
            KeyFrame keyFrame = new();
            keyFrame.ID = value1.ID;
            keyFrame.Rotation = value1.Rotation * value2.Rotation;
            keyFrame.PositionX = value1.PositionX * value2.PositionX;
            keyFrame.PositionY = value1.PositionY * value2.PositionY;
            keyFrame.ScaleX = value1.ScaleX * value2.ScaleX;
            keyFrame.ScaleY = value1.ScaleY * value2.ScaleY;
            return keyFrame;
        }
        public static KeyFrame operator /(KeyFrame value1, KeyFrame value2)
        {
            KeyFrame keyFrame = new();
            keyFrame.ID = value1.ID;
            keyFrame.Rotation = value1.Rotation / value2.Rotation;
            keyFrame.PositionX = value1.PositionX / value2.PositionX;
            keyFrame.PositionY = value1.PositionY / value2.PositionY;
            keyFrame.ScaleX = value1.ScaleX / value2.ScaleX;
            keyFrame.ScaleY = value1.ScaleY / value2.ScaleY;
            return keyFrame;
        }

#nullable enable
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
