using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using SEEK.Model;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SEEK.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PhonePage : Page
    {
        public PhonePage()
        {
            this.InitializeComponent();
        }

        private static TodoItem CurrItem = new TodoItem();

        /// <summary>
        /// The selected question from the previous page is presented here, and it is editable. 
        /// </summary>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            String[] QuesStr2 =
                Windows.Storage.ApplicationData.Current.LocalSettings.Values["CurrItem2"].ToString().Split('ɦ');

            CurrItem.Name = QuesStr2[0];
            CurrItem.Brand = QuesStr2[1];
            CurrItem.ScreenSize = QuesStr2[2];
            CurrItem.DisplayType = QuesStr2[3];
            CurrItem.DisplayResolution = QuesStr2[4];
            CurrItem.OS = QuesStr2[5];
            CurrItem.RAM = QuesStr2[6];
            CurrItem.PriceNew = QuesStr2[7];
            CurrItem.PriceUsed = QuesStr2[8];
            CurrItem.PerformanceTier = QuesStr2[9];
            CurrItem.CameraPerformanceTier = QuesStr2[10];
            CurrItem.BatteryTier = QuesStr2[11];
            CurrItem.FingerprintScanner = QuesStr2[12];
            CurrItem.NewRelease = QuesStr2[13];
            CurrItem.BestPurchase = QuesStr2[14];


            txtItem.Text = CurrItem.Name;
            txtOp1.Text = CurrItem.PriceNew;
            txtOp2.Text = CurrItem.PriceUsed;
            txtOp3.Text = CurrItem.BestPurchase;
            
        }

        private void Button_ClickBookmark(object sender, RoutedEventArgs e)
        {
            showMsg("Bookmark Saved!");
        }

        private void txtOp3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Windows.System.Launcher.LaunchUriAsync(new Uri(txtOp3.Text));
        }

        public async void showMsg(string msg)
        {
            var dialog = new MessageDialog(msg);
            await dialog.ShowAsync();
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PhoneResults));
        }
    }
}
