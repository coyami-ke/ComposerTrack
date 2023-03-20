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
        public static readonly DependencyProperty TextProperty;
        //public static readonly DependencyProperty DurationProperty;
        //public static readonly DependencyProperty IsSelectedProperty;
        static KeyFrameControlModel()
        {
            TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(KeyFrameControlModel));
        }

        public string Text
        {
            get { return (string)this.GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
    }
}
