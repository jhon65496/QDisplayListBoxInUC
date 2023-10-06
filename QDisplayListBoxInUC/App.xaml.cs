using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MasterDetail0202Detail
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        

        public App()
        {
            MainWindowViewModel mainViewModel = new MainWindowViewModel();

            var mainWin = new MainWindow();
            mainWin.DataContext = mainViewModel;
            mainWin.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            mainWin.Show();
        }

    }
}
