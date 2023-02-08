using ComposerTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

#nullable disable
namespace ComposerTrack.Animations
{
    public class PlayAnimation
    {
        public List<KeyFrame> KeyFrames { get; set; }
        public List<TileData> Tiles { get; set; }
        public List<DecoData> Decorations { get; set; }
        public Storyboard Animation { get; set; }

        public void Play()
        {
            Animation = new Storyboard();
            foreach (var keyFrame in KeyFrames)
            {
                if (keyFrame.Tag is null)
                {
                    var target = keyFrame;
                    if (target != null)
                    {
                        Animation.Children.Add(new DoubleAnimation())
                    }
                }
            }
        }
    }
}
