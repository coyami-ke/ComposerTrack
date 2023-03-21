using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ComposerTrack.Models
{
    class KeyFrameControlModel : DependencyObject
    {
        public static readonly DependencyProperty IDProperty;
        public static readonly DependencyProperty DurationProperty;
        public static readonly DependencyProperty IsSelectedProperty;
        static KeyFrameControlModel()
        {
            IDProperty = DependencyProperty.Register("ID", typeof(string), typeof(KeyFrameControlModel));
        }

        public string ID
        {
            get { return (string)this.GetValue(IDProperty); }
            set { SetValue(IDProperty, value); }
        }
        public int Duration
        {
            get { return (int)this.GetValue(DurationProperty); }
            set { SetValue (DurationProperty, value); }
        }
        public bool IsSelected
        {
            get { return (bool)this.GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }
    }
}
