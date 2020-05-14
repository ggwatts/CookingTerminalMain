using BackendHandler;
using CookingTerminalMain.Commands;
using CookingTerminalMain.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;

namespace CookingTerminalMain.ViewModels
{
    public class MainMenuViewModel : BaseViewModel
    {
        #region Public Properties


        /// <summary>
        /// The property used to save the items from database
        /// </summary>
        public IEnumerable DatabaseList { get; set; }

        public static MainMenuViewModel VM { get; set; }

        private ThreadSafeObservableCollection<OrderModel> _ordersOngoing;

        public ThreadSafeObservableCollection<OrderModel> OrdersOngoing
        {
            get { return _ordersOngoing; }
            set { OnPropertyChanged(ref _ordersOngoing, value); }
        }


        private ThreadSafeObservableCollection<OrderModel> _waitingOrders;
        public ThreadSafeObservableCollection<OrderModel> WaitingOrders
        {
            get { return _waitingOrders; }
            set { OnPropertyChanged(ref _waitingOrders, value); }
        }

        #endregion
        //Test Github check
        public string test { get; set; }
        #region Commands
        public ICommand CookOrder { get; set; }

        public ICommand ChangePage { get; set; }

        #endregion

        public MainMenuViewModel()
        {
            VM = this;
            ChangePage = new RelayCommand(ChangePageCommand);
            OrdersOngoing = new ThreadSafeObservableCollection<OrderModel>();
            WaitingOrders = new ThreadSafeObservableCollection<OrderModel>();

            GetOngoingOrders();
            

            CookOrder = new RelayCommand((object order) =>
            {
               
                var ChosenOrderToCook = OrdersOngoing.Where(x => x.OrderID == (int)order).First();

               
                ChosenOrder = ChosenOrderToCook;

                
                MainWindowViewModel.VM.CurrentPage = Navigator.ChosenOrder;
            });

        }

        public async void GetOngoingOrders()
        {
           
            DatabaseList = await rep.GetOrderByStatus(0);

            OrdersOngoing.Clear();
            WaitingOrders.Clear();
            int test = 0;
            foreach (Order item in DatabaseList)
            {
                OrderModel order = new OrderModel();
                OrderModel waitingOrder = new OrderModel();
               
                if (item.PizzaList.Count > 0 && test < 6)
                {
                    order = new OrderModel();
                    order.OrderID = item.OrderID;
                    order.PizzaList = item.PizzaList;
                    OrdersOngoing.Add(order);
                    test++;
                }
                else if (item.PizzaList.Count > 0)
                {
                    waitingOrder.OrderID = item.OrderID;
                    WaitingOrders.Add(waitingOrder);
                    test++;
                }
                
            }
        }

        private Navigator _CurrentPage;
        public Navigator CurrentPage
        {
            get { return _CurrentPage; }
            set { OnPropertyChanged(ref _CurrentPage, value); }
        }


        public void ChangePageCommand(object parameterFromPage)
        {
            if (Enum.TryParse<Navigator>((string)parameterFromPage, out Navigator nav))
            {
                MainWindowViewModel.VM.CurrentPage = nav;
            }
        }
       
    }
}

