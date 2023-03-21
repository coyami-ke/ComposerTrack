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
using ComposerTrack.Views.Controls;

#nullable disable
namespace ComposerTrack.ViewModels
{
    public partial class EditorVM : ObservableRecipient
    {
        [ObservableProperty]
        private EditorModel editorModel;
        [ObservableProperty]
        private Project informationProject;
        [ObservableProperty]
        private BufferModel buffer;


        // Commands //
        [RelayCommand]
        private void SelectAllDecorations()
        {
            for (int i = 0;  i < EditorModel.Decorations.Count; i++)
            {
                EditorModel.Decorations[i].IsSelected = true;
            }
        }
        [RelayCommand]
        private void SelectDecorations(string[] tags)
        {
            foreach (string tag in tags)
            {
                for (int i = 0; i < EditorModel.Decorations.Count; i++)
                {
                    if (EditorModel.Decorations[i].IsSelected) EditorModel.Decorations[i].IsSelected = false;
                    if (EditorModel.Decorations[i].Tag == tag) EditorModel.Decorations[i].IsSelected = true;
                }
            }
        }
        [RelayCommand]
        private void AddDecoration()
        {
            AddDecorationWindow window = new();
            window.ShowDialog();
        }

        [RelayCommand]
        private void AddKeyFrame(string tagDecoration)
        {
            for (int i = 0; i < EditorModel.Decorations.Count; i++)
            {
                if (EditorModel.Decorations[i].IsSelected)
                {
                    KeyFrame keyFrame = new();
                    keyFrame.Tag = tagDecoration;
                    keyFrame.Beat = EditorModel.SelectedTime;

                    KeyFrameControl control = new();
                    control.Tag = tagDecoration;
                }
            }
            if (Buffer.KeyFrames.Count =< 20)
            {

            }
            Buffer.KeyFrames.Add(EditorModel.KeyFrames);
        }
        [RelayCommand]
        private void DeleteKeyFrame(string id)
        {
            for (int i = 0; i < EditorModel.KeyFrames.Count; i++)
            {
                if (EditorModel.KeyFrames[i].ID == id)
                {
                    EditorModel.KeyFrames.RemoveAt(i);
                    for (int s = 0; i < EditorModel.KeyFrameControls.Count; s++)
                    {
                        if (EditorModel.KeyFrames[i].ID == EditorModel.KeyFrameControls[s].ID) EditorModel.KeyFrameControls.RemoveAt(s);
                    }
                }
            }
        }
        
        // Methods //
        protected override void OnActivated()
        {
            Messenger.Register<EditorVM, CreateProjectMessanger>(this, (r, m) => r.Receive(m));
            Messenger.Register<EditorVM, AddDecorationMessanger>(this, (r, m) => r.Receive(m));
        }

        private void Receive(AddDecorationMessanger m)
        {
            EditorModel.Decorations.Add(m.Value);
        }

        private void Receive(CreateProjectMessanger message)
        {
             InformationProject = message.Value;
        }
        public void AddKeyFrames(KeyFrame[] keyFrames)
        {
            foreach (KeyFrame keyFrame in keyFrames)
            {
                EditorModel.KeyFrames.Add(keyFrame);
            }
        }
    }
}