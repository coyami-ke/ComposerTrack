using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using ComposerTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposerTrack.ViewModels.Messangers
{
    public class CreateProjectMessanger : ValueChangedMessage<Project>
    {
        public CreateProjectMessanger(Project value) : base(value)
        {

        }
    }
}
