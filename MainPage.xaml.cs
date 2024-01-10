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

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace App1
{
    public class MyDataModel
    {
        public string Title { get; set; }
        public string Image { get; set; }
    }

    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var items = new List<MyDataModel>
        {
            new MyDataModel { Title = "Item 1"},
            new MyDataModel { Title = "Item 2"},
            new MyDataModel { Title = "Item 3"},
            new MyDataModel { Title = "Item 4"},
            // Add more items here
        };

            MyListView.ItemsSource = items;
        }

        private void PreviousPage_Click(object sender, RoutedEventArgs e)
        {
            double newOffset = OuterScrollViewer.HorizontalOffset - OuterScrollViewer.ViewportWidth;
            OuterScrollViewer.ChangeView(newOffset, null, null);
        }

        private void NextPage_Click(object sender, RoutedEventArgs e)
        {
            double newOffset = OuterScrollViewer.HorizontalOffset + OuterScrollViewer.ViewportWidth;
            OuterScrollViewer.ChangeView(newOffset, null, null);
        }

    }
}
