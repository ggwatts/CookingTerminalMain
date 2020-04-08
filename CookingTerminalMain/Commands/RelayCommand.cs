using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CookingTerminalMain.Commands
{
    public class RelayCommand : ICommand
    {
        private Action<object> _action { get; set; }


        public RelayCommand(Action<object> action)
        {
            _action = action;
        }


        public void Execute(object parameter) => _action.Invoke(parameter);

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter) => true;

      

    }
}

