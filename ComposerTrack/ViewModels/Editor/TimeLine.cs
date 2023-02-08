using ComposerTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

#nullable disable
namespace ComposerTrack.ViewModels.Editor
{
    public class TimeLine
    {
        public List<KeyFrame> KeyFrames { get; set; }
        public List<Border> Borders { get; set; }
        public TimeLine(KeyFrame[] keyFrames)
        {
            var orderedKeyFrames = from i in keyFrames
                                   orderby i
                                   select i;
            foreach (KeyFrame keyFrame in orderedKeyFrames)
            {
                Border border = new();
                border.Height = 34;
                border.Width = 34;
                border.Margin = new System.Windows.Thickness(16, 0, 0 , 0 );
                border.Background = new SolidColorBrush(Color.FromRgb(179, 129, 55));
                
            }
        }
    }
}
