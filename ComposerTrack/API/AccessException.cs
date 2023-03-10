using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace ComposerTrack.API
{
    public class AccessException : Exception
    {
        public AccessException(string limited) : base()
        {
            LimitedMethod = limited;
        }
        public string LimitedMethod { get; private set; }
    }
}
