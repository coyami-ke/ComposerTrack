using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;
using ComposerTrack.Easing;

namespace ComposerTrack.Easing
{
    public class Expo : EasingFunctionBase
    {
        protected override Freezable CreateInstanceCore()
        {
            return new Expo();
        }

        protected override double EaseInCore(double normalizedTime)
        {
            return Easing.InExpo((float)normalizedTime);
        }
    }
}
