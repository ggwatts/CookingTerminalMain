using CookingTerminalMain.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace CookingTerminalMain.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
     
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
        public ICommand TestCommand { get; set; }

        private Navigator currentPage;

       
        public Navigator CurrentPage
        {
            get { return currentPage; }
            set
            {
                currentPage = value;

                PropertyChanged(this, new PropertyChangedEventArgs(nameof(CurrentPage)));
            }
        }

       
        public static MainWindowViewModel VM { get; set; }

       
        public MainWindowViewModel()
        {
           
            VM = this;

            Init();

            // Sets the starting page
            CurrentPage = Navigator.Login;
        }

        private async void Init()
        {
            ConfigFileHelpers.ReadServerConfigFile();
            if (!await ProgramState.Server.ConnectAsync())
                MessageBox.Show("Kunde inte etablera anslutning till servern.\nProgrammet körs i offline-läge.");
        }

    }
}
