using ComposerTrack.Models;
using ComposerTrack.Views.Controls;
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
        public List<KeyFrameControl> Controls { get; set; }
        public TimeLine(KeyFrame[] keyFrames)
        {
            var orderedKeyFrames = from i in keyFrames
                                   orderby i
                                   select i;
            foreach (KeyFrame keyFrame in orderedKeyFrames)
            {
                KeyFrameControl control = new();
            }
        }
    }
}
