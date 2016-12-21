﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Win32;
using System.ComponentModel.Composition;
using System.Windows.Input;

namespace spyssembly.ViewModels
{
    [Export]
    public class WelcomeViewModel : ViewModelBase
    {   
        public ICommand OpenCommand { get => new RelayCommand(OnOpen); }

        private void OnOpen()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Assemblies (*.dll, *.exe)|*.dll;*.exe";
            if (openFileDialog.ShowDialog() == true)
            {
                Messenger.Default.Send(openFileDialog.FileName);
            }
        }
    }
}
