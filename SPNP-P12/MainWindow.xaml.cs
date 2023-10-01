﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SPNP_P12

{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ThreadingBtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            try { new ThreadingWindow().ShowDialog(); } catch { }
            Show();
        }

        private void SynchroBtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            try { new SynchroWindow().ShowDialog(); } catch { }
            Show();
        }

        private void TaskBtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new TaskWindow().ShowDialog();
            Show();
        }

        private void CancellingBtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new CancelWindow().ShowDialog();
            Show();
        }

        private void ProcessBtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            try { new ProcessWindow().ShowDialog(); } catch { }
            Show();
        }

        private void ChainingBtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            try { new ChainingWindow().ShowDialog(); } catch { }
            Show();
        }
    }
}
