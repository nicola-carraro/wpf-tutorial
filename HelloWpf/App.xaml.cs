using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace HelloWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
      private void Application_Startup(object sender, StartupEventArgs e)
        {
            GoodbyeWindow window = new GoodbyeWindow();
            window.Title = "Trullallero";
            if(e.Args.Length > 0)
            {
                string argument = e.Args[0];
                Debug.WriteLine(argument);

                GoodbyeWindow wnd = new GoodbyeWindow();
            }
            window.Show();
        }

        private void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Merde ! " + e);
            e.Handled = true;
        }
    }
}
