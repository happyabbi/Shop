using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using Shop.PC.Views;
using System.Windows;

namespace Shop.PC
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        public App()
        {
            App.Current.DispatcherUnhandledException += Current_DispatcherUnhandledException;
        }

        private void Current_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
            e.Handled = true;
        }
        protected override Window CreateShell()
        {
            MainWindow mainWindow = Container.Resolve<MainWindow>();
            Application.Current.MainWindow = mainWindow;
            return mainWindow;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<HeaderModule.Header>();
            moduleCatalog.AddModule<MenuModule.Menu>();
            moduleCatalog.AddModule<ContentModule.Content>();
            moduleCatalog.AddModule<FooterModule.Footer>();
        }
    }
}
