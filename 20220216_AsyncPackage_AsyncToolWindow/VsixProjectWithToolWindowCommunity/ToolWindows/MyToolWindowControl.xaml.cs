﻿using System.Windows;
using System.Windows.Controls;

namespace VsixProjectWithToolWindowCommunity
{
    public partial class MyToolWindowControl : UserControl
    {
        public MyToolWindowControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            VS.MessageBox.Show("VsixProjectWithToolWindowCommunity", "Button clicked");
        }
    }
}