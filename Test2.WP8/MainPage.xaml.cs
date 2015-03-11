using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Test2.WP8.Resources;
using Xamarin.Forms;

namespace Test2.WP8
{
    public partial class MainPage : global::Xamarin.Forms.Platform.WinPhone.FormsApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            Forms.Init();
            LoadApplication(new Test2.App());
        }

    }
}