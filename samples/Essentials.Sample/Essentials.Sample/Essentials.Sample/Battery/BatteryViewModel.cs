using System;
using ReactiveUI;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Splat;
using Xamarin.Essentials;

namespace Essentials.Sample
{
    public class BatteryViewModel : ReactiveObject, IRoutableViewModel
    {
        private readonly IBattery _battery;
        private readonly IScreen _hostScreen;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectivityViewModel"/> class.
        /// </summary>
        public BatteryViewModel(IBattery battery)
        {
            _battery = battery;
            _hostScreen = Locator.Current.GetService<IScreen>();

            ConnectionInteraction = new Interaction<string, bool>();

            Battery.Subscribe(_ =>
                ConnectionInteraction
                    .Handle($"Connectivity Changed: {_.State}")
                    .Subscribe());
        }

        public string UrlPathSegment => nameof(BatteryViewModel);

        public IScreen HostScreen => _hostScreen;

        public IObservable<BatteryInfoChangedEventArgs> Battery => _battery.BatteryChanged;

        public Interaction<string, bool> ConnectionInteraction { get; }
    }
}