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
using SeekAdmin.Model;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SeekAdmin
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EditProduct : Page
    {
        public EditProduct()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// This button relays the edited question to the database, where it is updated. 
        /// </summary>
        private static TodoItem CurrItem = new TodoItem();
    
        /// <summary>
        /// The selected product from the previous page is presented here, and it is editable. 
        /// </summary>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            String[] QuesStr =
                Windows.Storage.ApplicationData.Current.LocalSettings.Values["CurrQues"].ToString().Split('ɦ');
            CurrItem.Name = QuesStr[0];
            CurrItem.Brand = QuesStr[1];
            CurrItem.ScreenSize = QuesStr[2];
            CurrItem.DisplayType = QuesStr[3];
            CurrItem.DisplayResolution = QuesStr[4];
            CurrItem.OS = QuesStr[5];
            CurrItem.RAM = QuesStr[6];
            CurrItem.PriceNew = QuesStr[7];
            CurrItem.PriceUsed = QuesStr[8];
            CurrItem.PerformanceTier = QuesStr[9];
            CurrItem.CameraPerformanceTier = QuesStr[10];
            CurrItem.BatteryTier = QuesStr[11];
            CurrItem.FingerprintScanner = QuesStr[12];
            CurrItem.NewRelease = QuesStr[13];
            CurrItem.BestPurchase = QuesStr[14];


            NameInput.Text = CurrItem.Name;
            BrandInput.Text = CurrItem.Brand;
            ScreenSizeInput.Text = CurrItem.ScreenSize;
            DisplayTypeInput.Text = CurrItem.DisplayType;
            DisplayResolutionInput.Text = CurrItem.DisplayResolution;
            OSInput.Text = CurrItem.OS;
            RAMInput.Text = CurrItem.RAM;
            PriceNewInput.Text = CurrItem.PriceNew;
            PriceUsedInput.Text = CurrItem.PriceUsed;
            PerformanceTierInput.Text = CurrItem.PerformanceTier;
            CameraPerformanceTierInput.Text = CurrItem.CameraPerformanceTier;
            FingerprintScannerInput.Text = CurrItem.FingerprintScanner;
            BatteryTierInput.Text = CurrItem.BatteryTier;
            BestPurchaseInput.Text = CurrItem.BestPurchase;

        }

        /// <summary>
        /// Self explanatory. 
        /// </summary>
        public async void showMsg(string msg)
        {
            var dialog = new MessageDialog(msg);
            await dialog.ShowAsync();
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof (ProductList));
        }
    }
}
