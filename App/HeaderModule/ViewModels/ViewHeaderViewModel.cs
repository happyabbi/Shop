using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Shop.Infrastucture.Event.Header;
using Shop.Infrastucture.Model;

namespace HeaderModule.ViewModels
{
    public class ViewHeaderViewModel : BindableBase
    {

        const string MAXICONFONT = "\ue603";
        const string RESTOREICONFONT = "\ue632";
        const string SHRINKMENUICONFONT = "\ue60f";
        const string SPREADMENUICONFONT = "\ue60d";

        IEventAggregator _eventAggregator;

        #region 属性
        private string _maxIconFont;
        public string MaxIconFont
        {
            get { return _maxIconFont; }
            set { SetProperty(ref _maxIconFont, value); }
        }
        private string _shrinkMenuIconFont;
        public string ShrinkMenuIconFont
        {
            get { return _shrinkMenuIconFont; }
            set { SetProperty(ref _shrinkMenuIconFont, value); }
        }
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value); }
        }

        #endregion

        #region 委托
        public DelegateCommand ExitCommand { get; }
        public DelegateCommand MinCommand { get; }
        public DelegateCommand MaxCommand { get; }
        public DelegateCommand ShrinkMenuCommand { get; }
        #endregion

        public ViewHeaderViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            MaxIconFont = MAXICONFONT;
            ShrinkMenuIconFont = SHRINKMENUICONFONT;
            UserName = "weick";

            ExitCommand = new DelegateCommand(() => { _eventAggregator.GetEvent<SystemCommandEvent>().Publish(new SystemCommandModel(SystemCommandEnum.Close)); });
            MinCommand = new DelegateCommand(() => { _eventAggregator.GetEvent<SystemCommandEvent>().Publish(new SystemCommandModel(SystemCommandEnum.Min)); });
            MaxCommand = new DelegateCommand(() => {
                if (MaxIconFont.Equals(MAXICONFONT))
                {
                    _eventAggregator.GetEvent<SystemCommandEvent>().Publish(new SystemCommandModel(SystemCommandEnum.Max));
                    MaxIconFont = RESTOREICONFONT;
                }
                else
                {
                    _eventAggregator.GetEvent<SystemCommandEvent>().Publish(new SystemCommandModel(SystemCommandEnum.Restore));
                    MaxIconFont = MAXICONFONT;
                }
            });
            ShrinkMenuCommand = new DelegateCommand(() => {
                if (ShrinkMenuIconFont.Equals(SHRINKMENUICONFONT))
                {
                    _eventAggregator.GetEvent<SystemCommandEvent>().Publish(new SystemCommandModel(SystemCommandEnum.ShrinkMenu));
                    ShrinkMenuIconFont = SPREADMENUICONFONT;
                }
                else
                {
                    _eventAggregator.GetEvent<SystemCommandEvent>().Publish(new SystemCommandModel(SystemCommandEnum.SpreadMenu));
                    ShrinkMenuIconFont = SHRINKMENUICONFONT;
                }
            });
        }
    }
}
