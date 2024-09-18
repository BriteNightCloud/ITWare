﻿using Microsoft.AspNetCore.Components;
using System.Windows;

namespace WPF_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
	{
		public MainWindow(IServiceProvider serviceProvider)
		{
            InitializeComponent();
            Resources.Add("services", serviceProvider);
        }
    }
}