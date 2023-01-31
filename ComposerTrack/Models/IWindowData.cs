using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerTrack.Models
{
    public interface IWindowData <T>
    {
        public T Data { get; set; }
        public object Sender { get; set; }
    }
}
