using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterDetail0202Detail.Data;

namespace MasterDetail0202Detail
{
    internal class MainWindowViewModel : BaseVM
    {

        public ObservableCollection<MenuItem> MenuItems { get; set; }

        public TestDataContext dataContext;

        public MainWindowViewModel()
        {
            dataContext = new TestDataContext();

            LoadMenuItems();
        }


        private BaseVM currentContent;
        public BaseVM CurrentContent
        {
            get => currentContent;
            set
            {
                currentContent = value;
                RaisePropertyChanged();
            }
        }



        private MenuItem selectedMenuItem;

        public MenuItem SelectedMenuItem
        {
            get { return selectedMenuItem; }
            set
            {
                selectedMenuItem = value;
                RaisePropertyChanged();
                Debug.WriteLine("MainWindowViewModel--Prop--SelectedMenuItem");
            }
        }

        /// <summary>
        /// Загрузка списка меню
        /// </summary>
        private async void LoadMenuItems()
        {
            //Загрузка списка меню
            var menuItems = await dataContext.GetMenuItemsAsync();
            this.MenuItems = new ObservableCollection<MenuItem>(menuItems);

        }


    }
}
