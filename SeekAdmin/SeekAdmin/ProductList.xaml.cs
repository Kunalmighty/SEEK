using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.WindowsAzure.MobileServices;
using SeekAdmin.Model;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SeekAdmin
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProductList : Page
    {
        public ProductList()
        {
            this.InitializeComponent();
        }

        private MobileServiceCollection<TodoItem, TodoItem> items;
        private IMobileServiceTable<TodoItem> oQuesion = App.MobileService.GetTable<TodoItem>();
        List<TodoItem> quesLst = new List<TodoItem>();

        /// <summary>
        /// View the list. 
        /// </summary>
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            quesLst = await oQuesion.ToListAsync();
            lstViewQues.ItemsSource = quesLst;
        }

        /// <summary>
        ///  This is what happens when a list item is clicked. THe user is taken to the page where the selected question can be edited, or deleted. 
        /// </summary>
        public void lstViewQues_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Create new question identical to the question selected
            //Use this new question's text in the textboxes in the next page
            //Have the textboxes be editable, whatever is edited is then saved exactly as done before, but only after deleting the corresponding id first
            //Use the deletion algorithm for the pure delete button too
            TodoItem item2 = e.ClickedItem as TodoItem;

            Windows.Storage.
                ApplicationData.Current
                .LocalSettings.Values["CurrQues"] = item2.Name + "ɦ" + item2.Brand + "ɦ" +
                                                    item2.ScreenSize + "ɦ" + item2.DisplayType + "ɦ" +
                                                    item2.DisplayResolution + "ɦ" + item2.OS + "ɦ" +
                                                    item2.RAM + "ɦ" + item2.PriceNew + "ɦ" + item2.PriceUsed + "ɦ" + item2.PerformanceTier + "ɦ" + item2.CameraPerformanceTier + "ɦ" + item2.BatteryTier + "ɦ" + item2.FingerprintScanner + "ɦ" + item2.NewRelease + "ɦ" + item2.BestPurchase;

            Frame.Navigate(typeof(EditProduct));
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(FirstPage));
        }
    }
}
