﻿using SortexApp.Services;
using SortexApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SortexApp.ViewModels;
using System.Linq;

namespace SortexApp
{
    public partial class App : Application
    {
        static public OrderViewModel Order { get; set; } = new OrderViewModel();
        static public FractionViewModel Fraction { get; set; } = new FractionViewModel();
        static public TrendViewModel Trend { get; set; } = new TrendViewModel();
        static public BrandViewModel Brand { get; set; } = new BrandViewModel();
        static public MoodboardViewModel Moodboard { get; set; } = new MoodboardViewModel();
        static public AssignmentViewModel Assignment { get; set; } = new AssignmentViewModel();

        static public bool isLogedIn = false;

        public App()
        {
            InitializeComponent();
            
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();

        }

        protected override async void OnStart()
        {
           
            await Order.LoadOrderAsync();
            await Fraction.LoadFractionAsync();
            await Trend.LoadTrendAsync();
            await Brand.LoadBrandAsync();
            await Moodboard.LoadMoodboardAsync();
            await Assignment.LoardAssignmentAsync();
         }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

    }
}
