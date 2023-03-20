using AdofaiMapConverter;
using ComposerTrack.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ComposerTrack.Views;
using CommunityToolkit.Mvvm.Messaging;
using System.Windows.Shapes;
using System.Windows.Controls;
using ComposerTrack.ViewModels;
using System.Windows.Media.Animation;
using System.Collections.Generic;
using System.Linq;
using System;
using ComposerTrack.ViewModels.Messangers;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using Wpf.Ui.Mvvm.Interfaces;

#nullable disable
namespace ComposerTrack.ViewModels
{
    public partial class EditorVM : ObservableRecipient
    {
        [ObservableProperty]
        private EditorModel editorModel;

        [ObservableProperty]
        private Project informationProject;

        protected override void OnActivated()
        {
            // Using a method group...
            Messenger.Register<EditorVM, CreateProjectMessanger>(this, (r, m) => r.Receive(m));
        }

        private void Receive(CreateProjectMessanger message)
        {
             InformationProject = message.Value;
        }
    }
}