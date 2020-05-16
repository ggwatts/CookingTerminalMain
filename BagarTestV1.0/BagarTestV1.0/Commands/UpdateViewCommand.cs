using BagarTestV1._0.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BagarTestV1._0.Commands
{
     class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;


        public UpdateViewCommand(MainViewModel viewmModel)
        {
            this.viewModel = viewmModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
          if(parameter.ToString() == "ChosenOrder")
            {
                viewModel.SelectedViewModel = new SelectedOrderViewModel();
            }

           else if (parameter.ToString() == "Orders")
            {
                viewModel.SelectedViewModel = new OrdersViewModel();//Ändra till MainMenu viewmodel
            }
        } 

    }
}
