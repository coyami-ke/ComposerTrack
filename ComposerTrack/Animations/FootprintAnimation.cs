using ComposerTrack.Models;
using ComposerTrack.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ComposerTrack.Animations
{
    public static class FootPrintAnimation
    {
        public static DecoData[] AddDecorations(DecoData decoration, int countCopies, int opacityCopies, int sharpness)
        {
            List<DecoData> result = new();

            for (int i = 0; countCopies > 0; i++)
            {
                DecoData decoData = decoration;
                Vector2 vector = decoData.Scale;
                vector.X = vector.Y -= i * sharpness;
                decoData.Scale = vector;
                decoData.Opacity -= (i * opacityCopies) / countCopies;
                decoration.Tag = $"FootPrintAnimation_{i}";
                result.Add(decoData);
            }

            return result.ToArray();
        }

        public static KeyFrame[] Animate(KeyFrame[] keyFrames, int intensivity)
        {
            List<KeyFrame> result = new();

            foreach (KeyFrame keyFrame in keyFrames)
            {
                keyFrame.Offset += 10 * intensivity;
                result.Add(keyFrame);
            }

            return result.ToArray();
        }
    }
}
