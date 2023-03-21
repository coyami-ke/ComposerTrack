using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using ComposerTrack.Models;
using ComposerTrack.ViewModels.Messangers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Wpf.Ui.Mvvm.Interfaces;

#nullable disable
namespace ComposerTrack.ViewModels
{
    public partial class AddDecorationVM : ObservableObject
    {
        [ObservableProperty]
        private string tag;

        [RelayCommand]
        private void Add()
        {
            DecoData deco = new();
            deco.Tag = Tag;
            WeakReferenceMessenger.Default.Send<AddDecorationMessanger>(new AddDecorationMessanger(deco));
        }
    }
}
