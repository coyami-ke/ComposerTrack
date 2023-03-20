using ComposerTrack.Easing;
using ComposerTrack.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ComposerTrack.Converters
{
    public static class FrameConverter
    {
        public const int FPS = 30;
        public static KeyFrame[] Full(KeyFrame[] keyFrames)
        {
            foreach (KeyFrame keyFrame in keyFrames)
            {
                List<KeyFrame> result = new()
                {
                    Capacity = FPS * (int)keyFrame.Duration
                };


                for (int i = 0; result.Capacity > 0; i++)
                {
                    KeyFrame frame = keyFrame;
                    frame.Position = keyFrame.Position / result.Capacity * i;
                    frame.Rotation = keyFrame.Rotation / result.Capacity * i;
                    frame.Scale = keyFrame.Scale / result.Capacity * i;
                    result.Add(frame);
                }
                return result.ToArray();
            }
            return null;
        }
    }
}
