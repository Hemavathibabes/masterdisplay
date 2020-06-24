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
using adaptive.Models;
using Gremlin.Net.Process.Traversal;
using System.Collections.ObjectModel;
using System.ServiceModel.Channels;
using Windows.UI.Popups;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace adaptive
{
    public sealed partial class listview : UserControl
    {

        public Models.employee emp { get { return this.DataContext as Models.employee; } }
        public listview()
        { 
            this.InitializeComponent();
            this.DataContextChanged += (s, e) => Bindings.Update();
        }
        string eid;

      
         



    

    }
}
