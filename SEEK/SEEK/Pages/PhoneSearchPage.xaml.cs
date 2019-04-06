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
using SEEK.Model;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SEEK.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PhoneSearchPage : Page
    {
        public PhoneSearchPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            string[] optionOS = { "Android", "iOS", "Windows Phone"};
            OSAns.ItemsSource = optionOS;

            string[] optionPer = { "Fastest", "Fast", "Meh"};
            PerAns.ItemsSource = optionPer;

            string[] optionRAM = { "4GB", "3GB", "2GB"};
            RAMAns.ItemsSource = optionRAM;

            string[] optionSS = { "6 inches", "5.7 inches", "5.5 inches", "5.2 inches", "5 inches", "4.7 inches", "4.5 inches"};
            SSAns.ItemsSource = optionSS;

            string[] optionSR = { "QHD", "FHD", "HD"};
            SRAns.ItemsSource = optionSR;

            string[] optionDT = { "Super Amoled", "OLED", "IPS", "TFT"};
            DTAns.ItemsSource = optionDT;

            string[] optionCPT = { "Best", "Better", "Good", "Meh"};
            CamTierAns.ItemsSource = optionCPT;

            string[] optionBT = { "Longest", "Long", "Meh"};
            BatTierAns.ItemsSource = optionBT;

            string[] optionFin = { "Yes", "No"};
            FingerAns.ItemsSource = optionFin;
        }

        private void Button_ClickSeek(object sender, RoutedEventArgs e)
        {

            TodoItem item = new TodoItem();

            item.Name = "Transit";
            item.Brand = "Transit";
            item.OS = Convert.ToString(OSAns.SelectedValue);
            item.PerformanceTier = Convert.ToString(PerAns.SelectedValue);
            item.RAM = Convert.ToString(RAMAns.SelectedValue);
            item.ScreenSize = Convert.ToString(SSAns.SelectedValue);
            item.DisplayResolution = Convert.ToString(SRAns.SelectedValue);
            item.DisplayType = Convert.ToString(DTAns.SelectedValue);
            item.CameraPerformanceTier = Convert.ToString(CamTierAns.SelectedValue);
            item.BatteryTier = Convert.ToString(BatTierAns.SelectedValue);
            item.FingerprintScanner = Convert.ToString(FingerAns.SelectedValue);
            

            Windows.Storage.
                ApplicationData.Current
                .LocalSettings.Values["CurrItem"] = item.Name + "ɦ" + item.Brand + "ɦ" +
                                                    item.ScreenSize + "ɦ" + item.DisplayType + "ɦ" +
                                                    item.DisplayResolution + "ɦ" + item.OS + "ɦ" +
                                                    item.RAM + "ɦ" + item.PriceNew + "ɦ" + item.PriceUsed + "ɦ" + item.PerformanceTier + "ɦ" + item.CameraPerformanceTier + "ɦ" + item.BatteryTier + "ɦ" + item.FingerprintScanner + "ɦ" + item.NewRelease + "ɦ" + item.BestPurchase;

            Frame.Navigate(typeof(PhoneResults));
        }
    }
}
