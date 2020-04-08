using BackendHandler;
using CookingTerminalMain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CookingTerminalMain.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public IDatabase rep { get; set; } = Helpers.GetSelectedBackend();

        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };


        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public static OrderModel OrderToCook { get; set; }
        public static OrderModel ChosenOrder { get; set; }

        public void OnPropertyChanged<T>(ref T pr, T value, [CallerMemberName] string propertyChanged = "")
        {
            pr = value;

            var handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyChanged));
            }
        }


       
    }
}


