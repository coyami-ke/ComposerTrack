﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace ComposerTrack.Models
{

    public partial class AboutModel : ObservableObject
    {
        [ObservableProperty]
        private string nameProgram;
        [ObservableProperty]
        private Version versionProgram;
        [ObservableProperty]
        private string authorProgram;
        [ObservableProperty]
        private string descriptionProgram;
    }
}
