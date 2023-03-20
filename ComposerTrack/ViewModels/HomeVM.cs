using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ComposerTrack.Easing;
using ComposerTrack.Models;
using ComposerTrack.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

#nullable disable
namespace ComposerTrack.ViewModels
{
    /// <summary>
    /// HomeVM.
    /// </summary>
    public partial class HomeVM : ObservableObject
    {
        [ObservableProperty]
        private HomeModel projects;
        [RelayCommand]
        private void CreateProjectCommand()
        {
            CreateProjectWindow window = new();
            window.ShowDialog();
        }
    }
}
