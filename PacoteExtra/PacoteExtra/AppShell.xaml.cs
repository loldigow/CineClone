using PacoteExtra.ViewModels;
using PacoteExtra.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PacoteExtra
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
