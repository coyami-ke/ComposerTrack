﻿using ComposerTrack.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Wpf.Ui.Controls;

namespace ComposerTrack.Views
{
    /// <summary>
    /// Логика взаимодействия для AboutWindow.xaml
    /// </summary>
    public partial class AboutWindow : UiWindow
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        private void closeWindow_MouseDown(object sender, MouseButtonEventArgs e) => this.Close();
    }
}
