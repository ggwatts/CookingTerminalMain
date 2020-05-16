using BackendHandler;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using BagarTestV1._0.ViewModels;



namespace BagarTestV1._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public static IDatabase rep { get; set; }
        //public List<Order> ListOfOrders;
        public MainWindow()
        {

            InitializeComponent();
            //#region Read configfile and populate lists
            //rep = Helpers.GetSelectedBackend();
            //#endregion
            //List<Order> listOfOrders = new List<Order>();
            //listOfOrders = GetOrder().Result;
            //OrderList.Items.Add(listOfOrders);
            //listOfOrders.ForEach(item => OrderList.Items.Add(item));
            DataContext = new MainViewModel();
           


        }
       

        //public async Task GetOrder()
        //{
        //    #region Read configfile and populate lists
        //    rep = Helpers.GetSelectedBackend();
        //    #endregion
        //    List<Order> listOfOrders = new List<Order>();
        //    foreach (Order order in await rep.GetOrderByStatus(0)) //Lägger in alla betalda men ej tillagade ordrar i en lista.   
        //    {
        //        if (order.PizzaList.Count >= 1)
        //        {
        //            listOfOrders.Add(order);
        //        }

        //    }
        //    //OrderList.Items.Add(listOfOrders);
        //    int i;
        //    int index;
           
        //    //for (i = 0; i < 5; i++)
        //    //{

        //    //    if (i < listOfOrders.Count)
        //    //    {
        //    //        Console.Write($"{counter}. \n");
        //    //        for (index = 0; index < listOfOrders[i].PizzaList.Count; index++)
        //    //        {
                       
        //    //        }
                  
        //    //    }
        //    //}
           
        //    for (i = 0; i < 5; i++)
        //    {
        //        if (i < listOfOrders[i].PizzaList.Count)
        //        {
        //            for (index = 0; index < listOfOrders[0].PizzaList.Count; index++)
        //            {
        //                OrdersList0.Items.Add(listOfOrders[0].PizzaList[index].Type);
        //            }
        //            for (index = 0; index < listOfOrders[1].PizzaList.Count; index++)
        //            {
        //                OrdersList1.Items.Add(listOfOrders[1].PizzaList[index].Type);
        //            }
        //            for (index = 0; index < listOfOrders[2].PizzaList.Count; index++)
        //            {
        //                OrdersList2.Items.Add(listOfOrders[2].PizzaList[index].Type);
        //            }
        //            for (index = 0; index < listOfOrders[3].PizzaList.Count; index++)
        //            {
        //                OrdersList3.Items.Add(listOfOrders[3].PizzaList[index].Type);
        //            }
        //            for (index = 0; index < listOfOrders[4].PizzaList.Count; index++)
        //            {
        //                OrdersList4.Items.Add(listOfOrders[4].PizzaList[index].Type);
        //            }


        //        }
                //this.ListOfOrders = listOfOrders;
            
                        
                
                
                //listOfOrders.ForEach(item => OrderList.Items.Add(item));
        //    }
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           /* DataContext = new SelectedOrderViewModel();*//*ListOfOrders[0]*/
            /*DataContext = new SelectedOrderPage();*/ //create your new form.

            //DataContext = new SelectedOrderPage();
            //this.Content = SelectedOrderPage;
            //SelectedOrderPage p = new SelectedOrderPage();
            //SelectedOrderPage.Navigate(p);
        }
    }
}
