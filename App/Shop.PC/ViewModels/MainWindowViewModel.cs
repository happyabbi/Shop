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
        private string _title = "Prism Application";
        public string Title
        {   
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        IRegionManager _regionManager;
        IEventAggregator _eventAggregator;
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
                        default:
                            break;
                    }
                }
            });


        }
    }
}
