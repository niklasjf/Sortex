﻿using SortexApp.ViewModels;
using SortexApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
[assembly: ExportFont("LibreFranklin-VariableFont_wght.ttf", Alias = "standardFont")]
namespace SortexApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
       
        public AppShell()
        {
            InitializeComponent();
            
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));

        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
