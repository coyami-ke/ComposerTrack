using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace ComposerTrack.API
{
    public abstract class Extension
    {
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract string Author { get; }
        public abstract Version Version { get; }
        public abstract Version VersionAPI { get; }
        public abstract bool IsOfficial { get; }
        /// <summary>
        /// Pre-Initialization. Declaring variables. API access is limited. Throw an AccessException if you try to use the API functionality.
        /// </summary>
        public abstract void PreInit();
        /// <summary>
        /// Initialization. This is where the main work of extensions begins.
        /// </summary>
        public abstract void Init();
    }
}
