using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Data;
using System.Collections.ObjectModel;
using DevExpress.Xpf.Core;

namespace CustomRibbonSLTheme {
    public partial class MainPage : UserControl {
        public MainPage() {
            //ThemeManager.ApplicationTheme = Theme.Office2007Silver;
            Theme theme = new Theme("Office2007SilverExtension") { IsStandard = false };
            ThemeManager.ApplicationTheme = theme;
            InitializeComponent();           
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            DXVisualizer.DXVisualTreeVisualizer.Show();
        }

    }         


}
