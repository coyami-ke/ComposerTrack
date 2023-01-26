using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable
namespace ComposerTrack.API
{
    public class ExtensionException : Exception
    {
        public ExtensionException(Extension source, string recommendation)
        {
            Recommendation = recommendation;
        }
        /// <summary>
        /// Recommendations for fixing the error
        /// </summary>
        public string Recommendation { get; private set; }
    }
}
