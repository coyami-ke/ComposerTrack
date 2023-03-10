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
    public class TimeLineModel : INotifyPropertyChanged
    {
        private int value;
        private int maxValue;
        private int minValue;
        private int fps;

        public int Value
        {
            get { return value; }
            set
            {
                this.value = value;
                OnPropertyChanged();
            }
        }
        public int MaxValue
        {
            get { return maxValue; }
            set
            {
                maxValue = value;
                OnPropertyChanged();
            }
        }
        public int MinValue
        {
            get { return minValue; }
            set
            {
                minValue = value;
                OnPropertyChanged();
            }
        }
        public int FPS
        {
            get { return fps; }
            set
            {
                fps = value;
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
