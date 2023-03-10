using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerTrack.ViewModels
{
    public static class StaticViewModels
    {
        internal static HomeVM Home { get; set; }
        internal static CreateProjectVM CreateProject { get; set; }
        internal static EditorVM Editor { get; set; }
    }
}
