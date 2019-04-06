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
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using SeekAdmin.Model;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SeekAdmin
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void ButtonSave_Click(object sender, RoutedEventArgs e) 
        {
            var todoItem = new TodoItem
            {
                Name = NameInput.Text, Brand = BrandInput.Text, OS = OSInput.Text, ScreenSize = ScreenSizeInput.Text,
                DisplayType = DisplayTypeInput.Text, DisplayResolution = DisplayResolutionInput.Text, RAM = RAMInput.Text,
                PriceNew = PriceNewInput.Text, PriceUsed = PriceUsedInput.Text, CameraPerformanceTier = CameraPerformanceTierInput.Text,
                PerformanceTier = PerformanceTierInput.Text, BatteryTier = BatteryTierInput.Text, FingerprintScanner = FingerprintScannerInput.Text, BestPurchase = BestPurchaseInput.Text, NewRelease = NewReleaseInput.Text
            };
            await App.MobileService.GetTable<TodoItem>().InsertAsync(todoItem);

            showMsg("Product added!");
        }

        public async void showMsg(string msg)
        {
            var dialog = new MessageDialog(msg);
            await dialog.ShowAsync();
        }
    }
}
