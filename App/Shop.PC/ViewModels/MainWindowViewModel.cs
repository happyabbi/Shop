using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using Shop.Infrastucture.Event.Header;
using Shop.Infrastucture.Model;
using Shop.PC.Views;
using System;
using System.Windows;

namespace Shop.PC.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        const int MENUREGIONWIDTH = 210;

        IRegionManager _regionManager;
        IEventAggregator _eventAggregator;

        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private int _menuRegionWidth = MENUREGIONWIDTH;
        public int MenuRegionWidth
        {
            get { return _menuRegionWidth; }
            set { SetProperty(ref _menuRegionWidth, value); }
        }

        public MainWindowViewModel(IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            _regionManager = regionManager;
            _eventAggregator = eventAggregator;

            _eventAggregator.GetEvent<SystemCommandEvent>().Subscribe((model) => {
                if (model is SystemCommandModel m)
                {
                    switch (m.SystemCommand)
                    {
                        case SystemCommandEnum.Close:
                            Environment.Exit(0);
                            break;
                        case SystemCommandEnum.Min:
                            SystemCommands.MinimizeWindow(Application.Current.MainWindow);
                            break;
                        case SystemCommandEnum.Max:
                            SystemCommands.MaximizeWindow(Application.Current.MainWindow);
                            break;
                        case SystemCommandEnum.Restore:
                            SystemCommands.RestoreWindow(Application.Current.MainWindow);
                            break;
                        case SystemCommandEnum.ShrinkMenu:
                            MenuRegionWidth = 0;
                            break;
                        case SystemCommandEnum.SpreadMenu:
                            MenuRegionWidth = MENUREGIONWIDTH;
                            break;
                        default:
                            break;
                    }
                }
            });


        }
    }
}
