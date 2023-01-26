using ComposerTrack.Views;
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
    public class Cubic : EasingFunctionBase
    {
        protected override Freezable CreateInstanceCore()
        {
            return new Cubic();
        }

        protected override double EaseInCore(double normalizedTime) => Easing.InCubic((float)normalizedTime);
    }
}
