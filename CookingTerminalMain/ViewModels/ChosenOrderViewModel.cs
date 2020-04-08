using BackendHandler;
using CookingTerminalMain.Commands;
using CookingTerminalMain.Models;
using CookingTerminalMain.ViewModels.ModelViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CookingTerminalMain.ViewModels
{
    public class ChosenOrderViewModel : BaseViewModel
    {
        public ICommand ChangePage { get; set; }
        public ICommand CookDish { get; set; }
        public ICommand ServeOrder { get; set; }

        public IEnumerable DatabaseList { get; set; }
        private OrderModel _chosenOrder { get; set; }

        public static ChosenOrderViewModel VM { get; set; }
       

        private ObservableCollection<PizzaViewModel> _pendingDish; 

        public ObservableCollection<PizzaViewModel> PendingDish
        {
            get { return _pendingDish; }
            set { OnPropertyChanged(ref _pendingDish, value); }
        }

        private ObservableCollection<PizzaViewModel> _showPendingDish; 

        public ObservableCollection<PizzaViewModel> ShowPendingDish
        {
            get { return _showPendingDish; }
            set { OnPropertyChanged(ref _showPendingDish, value); }
        }

        private ObservableCollection<PizzaViewModel> _cookedDish;
        public ObservableCollection<PizzaViewModel> CookedDish
        {
            get { return _cookedDish; }
            set { OnPropertyChanged(ref _cookedDish, value); }
        }


        private bool _serveOrderButtonVisibility { get; set; }

        public bool ServeOrderButtonVisibility
        {
            get { return _serveOrderButtonVisibility; }
            set
            {
                _serveOrderButtonVisibility = value;
                OnPropertyChanged("ServeOrderButtonVisibility");
            }
        }

        public ChosenOrderViewModel()
        {
            ChangePage = new RelayCommand(ChangePageCommand);
            CookDish = new RelayCommand(CookDishCommand);
            ServeOrder = new RelayCommand(ServeOrderCommand);
            VM = this;
            

            CookedDish = new ObservableCollection<PizzaViewModel>();
            _chosenOrder = ChosenOrder;
            GetOngoingOrders(_chosenOrder.OrderID);

            ServeOrderButtonVisibility = false;




        }

        public async void GetOngoingOrders(int OrderID)
        {
            DatabaseList = await rep.GetOrderByStatus(0);
            PendingDish = new ObservableCollection<PizzaViewModel>();
            ShowPendingDish = new ObservableCollection<PizzaViewModel>();

            foreach (Order item in DatabaseList)
            {
                var order = new PizzaViewModel();
                var IndexOfList = new List<int>();

                if (item.OrderID == OrderID)
                {

                    for (int i  = 0; i<item.PizzaList.Count; i++)
                    {
                        order = new PizzaViewModel();
                        order.PizzaID = item.PizzaList[i].PizzaID;
                        order.Type = item.PizzaList[i].Type;
                        order.Pizzabase = item.PizzaList[i].Pizzabase;
                        order.PizzaIngredients = item.PizzaList[i].PizzaIngredients;
                        order.IsDishCooked = false;
                        order.PizzaIndex = i;
                        IndexOfList.Add(i);
                        order.IndexDishList = IndexOfList;
                        PendingDish.Add(order);
                        ShowPendingDish.Add(order);
                    }
                }
            }
           
        }
       
        public void CookDishCommand(object index)
        {

            int i = Convert.ToInt32(index);

            CookedDish.Add(PendingDish[i]);

            ShowPendingDish.Remove(PendingDish[i]);

            if (ShowPendingDish.Count == 0)
            {
                ServeOrderButtonVisibility = true;
            }




        }
        /// <summary>
        /// Sends in Order object to database that the order is served. It changes the orders status to 2.
        /// </summary>
        /// <param name="parameterFromPage"></param>
        public async void ServeOrderCommand(object parameterFromPage)
        {
            Order sendOrder = new Order()
            {
                OrderID = _chosenOrder.OrderID,
                ExtraList = _chosenOrder.ExtraList,
                PizzaList = _chosenOrder.PizzaList,
                Price = _chosenOrder.Price,
                Status = _chosenOrder.Status
            };

            if (ShowPendingDish.Count <=0)
            {
                if (Enum.TryParse<Navigator>((string)parameterFromPage, out Navigator nav))
                {

                    await rep.UpdateOrderStatusWhenOrderIsCooked(sendOrder);

                    if (ProgramState.Server.ConnectionState == ConnectionStates.Connected)
                        ProgramState.Server.SendMessage("[ORDERBAKED]");

                    PendingDish.Clear();
                    MainWindowViewModel.VM.CurrentPage = nav;
                }
            }
            
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
