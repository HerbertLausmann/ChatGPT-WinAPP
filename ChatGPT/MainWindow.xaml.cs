using CefSharp.Wpf;
using CefSharp;
using System;
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
using System.Globalization;

namespace ChatGPT
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            CefSettings settings = new CefSettings();
            // path to directory 
            string path = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "chatgpt-winapp");

            // Set the path 
            settings.CachePath = path;
            settings.UserAgent = "Mozilla/5.0 (platform; rv:geckoversion) Gecko/geckotrail Firefox/firefoxversion";
            settings.Locale = CultureInfo.CurrentUICulture.Name;

            // set the options 
            Cef.Initialize(settings);
            InitializeComponent();
            Cef.UIThreadTaskFactory.StartNew(() =>
            {
                browser.RequestContext.SetPreference("browser.enable_spellchecking", false, out _);
            });
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await browser.LoadUrlAsync("https://chat.openai.com/");
            //do something else
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F5)
            {
                browser.Reload(false);
            }
        }
    }
}
