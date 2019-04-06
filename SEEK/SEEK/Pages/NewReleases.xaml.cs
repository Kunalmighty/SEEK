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
using SEEK.Model;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SEEK.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NewReleases : Page
    {
        public NewReleases()
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
         
            quesLst = await oQuesion.Where(todoItem => todoItem.NewRelease == "Yes")
            .ToListAsync();


            listPhones.ItemsSource = quesLst;
        }

        private void listPhones_ItemClick(object sender, ItemClickEventArgs e)
        {
            TodoItem item2 = e.ClickedItem as TodoItem;

            Windows.Storage.
                ApplicationData.Current
                .LocalSettings.Values["CurrItem3"] = item2.Name + "ɦ" + item2.Brand + "ɦ" +
                                                    item2.ScreenSize + "ɦ" + item2.DisplayType + "ɦ" +
                                                    item2.DisplayResolution + "ɦ" + item2.OS + "ɦ" +
                                                    item2.RAM + "ɦ" + item2.PriceNew + "ɦ" + item2.PriceUsed + "ɦ" + item2.PerformanceTier + "ɦ" + item2.CameraPerformanceTier + "ɦ" + item2.BatteryTier + "ɦ" + item2.FingerprintScanner + "ɦ" + item2.NewRelease + "ɦ" + item2.BestPurchase;

            Frame.Navigate(typeof(NewReleasePhone));
        }
    }
}
