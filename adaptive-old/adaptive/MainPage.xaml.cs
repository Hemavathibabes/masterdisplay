﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using adaptive.Models;
using Windows.ApplicationModel.Activation;
using Windows.UI.ViewManagement;
using Microsoft.Azure.Amqp.Framing;
using System.Runtime.InteropServices;
using Windows.UI.Popups;
using DocumentFormat.OpenXml.Wordprocessing;
using Gremlin.Net.Process.Traversal;
using System.Collections.Immutable;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace adaptive
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<employee> employee;
       
        public MainPage()
        {
            this.InitializeComponent();
            employee = employeemanager.getemployeedetails();
            ApplicationView.PreferredLaunchViewSize = new Size { Height = 720, Width = 1280 };
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size { Width = 100, Height = 400 });
            // Ensure the current window is active
            Window.Current.Activate();
        }

       

       

        private void listview_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            var send = sender as listview;
            var view = send.DataContext as employee;
            popuptext.Text = "Hi "+ view.firstname+" " + view.lastname+"!";
            onhoverpopup.IsOpen = true;
        }

        private void listview_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            popuptext.Text = " ";
        }


        public employee click;
        
        private async void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
           
            var clickedItem = e.ClickedItem;
            click = (employee)clickedItem;
            string message = click.firstname + click.lastname + click.id;
            MessageDialog msg = new MessageDialog(message);
            await msg.ShowAsync();
            viewemplist.Visibility = Visibility.Visible;
            
             
            
           // viewemplist.List = click.id;
        }
       

    }
}
