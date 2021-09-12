using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Shop.Infrastucture.Event.Header;
using Shop.Infrastucture.Model;

namespace HeaderModule.ViewModels
{
    public class ViewHeaderViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
        private string _maxIconFont = "\ue603";
        public string MaxIconFont
        {
            get { return _maxIconFont; }
            set { SetProperty(ref _maxIconFont, value); }
        }

        IEventAggregator _eventAggregator;
        public DelegateCommand ExitCommand { get; }
        public DelegateCommand MinCommand { get; }
        public DelegateCommand MaxCommand { get; }
        public ViewHeaderViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            ExitCommand = new DelegateCommand(() => { _eventAggregator.GetEvent<SystemCommandEvent>().Publish(new SystemCommandModel(SystemCommandEnum.Close)); });
            MinCommand = new DelegateCommand(() => { _eventAggregator.GetEvent<SystemCommandEvent>().Publish(new SystemCommandModel(SystemCommandEnum.Min)); });
            MaxCommand = new DelegateCommand(() => { _eventAggregator.GetEvent<SystemCommandEvent>().Publish(new SystemCommandModel(SystemCommandEnum.Max)); });
        }
    }
}
