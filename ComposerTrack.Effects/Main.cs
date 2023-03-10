using ComposerTrack.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ComposerTrack.Effects
{
    public class Main : Extension
    {
        public override string Name { get; }
        public override string Description { get; }
        public override string Author { get; }
        public override Version Version { get; }
        public override Version VersionAPI { get; }
        public override bool IsOfficial { get; }

        public Main()
        {
            Name = "ComposerTrack Effects";
            Description = "Component of ComposerTrack. This component is working with effects.";
            Author = "dropsy";
            Version = new Version(1,0,0,0);
            VersionAPI = new Version(1, 0, 0, 0);
            IsOfficial = true;
        }

        public override void Init()
        {
            MenuItem effectsMenuItem = new();
            MenuItem footPrintEffectMenuItem = new();

            App.EditorWindow.AnimatorContextMenu.Items.Add(effectsMenuItem);
        }

        public override void PreInit()
        {
            
        }
    }
}
