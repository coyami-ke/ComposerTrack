using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using ComposerTrack.Models;
using ComposerTrack.ViewModels.Messangers;
using ComposerTrack.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
#nullable disable
namespace ComposerTrack.ViewModels
{
    public partial class CreateProjectVM : ObservableObject
    {
        [ObservableProperty]
        private Project project;
        [RelayCommand]
        private void CreateProject()
        {
            EditorWindow window = new();
            window.Show();
            WeakReferenceMessenger.Default.Send<CreateProjectMessanger>(new CreateProjectMessanger(this.Project));
        }
    }
}
