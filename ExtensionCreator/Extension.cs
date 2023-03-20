using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionCreator
{
    /// <summary>
    /// Base class for extensions
    /// </summary>
    public abstract class Extension
    {
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract string Author { get; }
        public abstract Version Version { get; }
        public abstract Version VersionAPI { get; }

        public Extension()
        {

        }
        public abstract void Init();
    }
}
