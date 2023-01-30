using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace ComposerTrack.Easing
{
    public class Quad : EasingFunctionBase
    {
        protected override Freezable CreateInstanceCore()
        {
            return new Quad();
        }

        protected override double EaseInCore(double normalizedTime) => Easing.InQuad((float)normalizedTime);
    }
}
