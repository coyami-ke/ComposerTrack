using CommunityToolkit.Mvvm.Messaging.Messages;
using ComposerTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerTrack.ViewModels.Messangers
{
    public class AddDecorationMessanger : ValueChangedMessage<DecoData>
    {
        public AddDecorationMessanger(DecoData value) : base(value)
        {
        }
    }
}
