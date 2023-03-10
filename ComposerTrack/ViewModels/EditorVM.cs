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

#nullable disable
namespace ComposerTrack.ViewModels
{
    public class EditorVM : INotifyPropertyChanged
    {
        private EditorModel editorModel;

        private RelayCommand addDecoCommand;
        private RelayCommand removeDecoCommand;
        private RelayCommand addKeyFrame;
        private RelayCommand removeKeyFrame;
        private RelayCommand selectDeco;
        private RelayCommand selectAllDecoCommand;

        public RelayCommand AddDecoCommand;

        public EditorModel EditorModel
        {
            get { return editorModel; }
            set
            {
                editorModel = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand SelectDecoCommand
        {
            get
            {
                return selectDeco ??= new RelayCommand(obj =>
                {
                    string tag = obj as string;
                    for (int i = 0; EditorModel.Decorations.Count > 0; i++)
                    {
                        EditorModel.Decorations[i].IsSelected = false;
                        if (EditorModel.Decorations[i].Tag == tag) EditorModel.Decorations[i].IsSelected = true;
                    }
                });
            }
        }

        public RelayCommand SelectAllDecoCommand
        {
            get
            {
                return selectAllDecoCommand ??= new RelayCommand(obj =>
                {
                    for (int i = 0; EditorModel.Decorations.Count > 0; i++)
                    {
                        EditorModel.Decorations[i].IsSelected = true;
                    }
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
