using Essentials.Mock;
using ReactiveUI;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Splat;

namespace Essentials.Sample
{
    public class AppBootstrapper
    {
        public AppBootstrapper()
        {
            RegisterViews(Locator.CurrentMutable);
            RegisterViewModels(Locator.CurrentMutable);
            RegisterServices(Locator.CurrentMutable);
        }

        public MainViewModel CreateMainViewModel()
        {
            // In a typical routing example the IScreen implementation would be this bootstrapper class.
            // However, a MasterDetailPage is designed to at the root. So, we assign the master-detail
            // view model to play the part of IScreen, instead.
            return new MainViewModel();
        }

        private void RegisterServices(IMutableDependencyResolver registrar)
        {
            registrar.Register(() => new MockConnectivityEssential(RxApp.MainThreadScheduler, 5), typeof(IConnectivity));
            registrar.Register(() => new MockCompassEssential(RxApp.MainThreadScheduler), typeof(ICompass));
        }

        private void RegisterViews(IMutableDependencyResolver registrar)
        {
            registrar.Register(() => new DetailPage(), typeof(IViewFor<DetailViewModel>));
            registrar.Register(() => new MasterCell(), typeof(IViewFor<MasterCellViewModel>));

            // Detail pages
            Locator.CurrentMutable.Register(() => new BatteryPage(), typeof(IViewFor<BatteryViewModel>));
            Locator.CurrentMutable.Register(() => new CompassPage(), typeof(IViewFor<CompassViewModel>));
            Locator.CurrentMutable.Register(() => new ConnectivityPage(), typeof(IViewFor<ConnectivityViewModel>));
        }

        private void RegisterViewModels(IMutableDependencyResolver registrar)
        {
            // Here, we use contracts to distinguish which routable view model we want to instantiate.
            // This helps us avoid a manual cast to IRoutableViewModel when calling Router.Navigate.Execute(...)
            registrar.Register(() => new BatteryViewModel(Locator.Current.GetService<IBattery>()), typeof(IRoutableViewModel), typeof(BatteryViewModel).FullName);
            registrar.Register(() => new ConnectivityViewModel(Locator.Current.GetService<IConnectivity>()), typeof(IRoutableViewModel), typeof(ConnectivityViewModel).FullName);
            registrar.Register(() => new CompassViewModel(Locator.Current.GetService<ICompass>()), typeof(IRoutableViewModel), typeof(CompassViewModel).FullName);
        }
    }
}