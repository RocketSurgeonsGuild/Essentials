using System;
using System.Reactive.Linq;
using ReactiveUI;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Splat;
using Xamarin.Essentials;

namespace Essentials.Sample
{
    public class ConnectivityViewModel : ReactiveObject, IRoutableViewModel
    {
        private readonly IConnectivity _connectivity;
        private readonly IScreen _hostScreen;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectivityViewModel"/> class.
        /// </summary>
        public ConnectivityViewModel(IConnectivity connectivity)
        {
            _connectivity = connectivity;
            _hostScreen = Locator.Current.GetService<IScreen>();
            ConnectionInteraction = new Interaction<string, bool>();
           
            Connectivity.Subscribe(_ =>
                ConnectionInteraction
                    .Handle($"Connectivity Changed: {_.NetworkAccess}")
                    .Subscribe());
        }

        public string UrlPathSegment => nameof(ConnectivityViewModel);

        public IScreen HostScreen => _hostScreen;

        public IObservable<ConnectivityChangedEventArgs> Connectivity => _connectivity.ConnectivityChanged;

        public Interaction<string, bool> ConnectionInteraction { get; }
    }
}