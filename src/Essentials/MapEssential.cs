using System;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access the the <see cref="Map"/> API.
    /// </summary>
    /// <seealso cref="IMap" />
    public class MapEssential : IMap
    {
        /// <inheritdoc />
        public IObservable<Unit> Open(Location location) => Observable.FromAsync(() => Map.OpenAsync(location));

        /// <inheritdoc />
        public IObservable<Unit> Open(Placemark placemark) => Observable.FromAsync(() => Map.OpenAsync(placemark));

        /// <inheritdoc />
        public IObservable<Unit> Open(double latitude, double longitude) =>
            Observable.FromAsync(() => Map.OpenAsync(latitude, longitude));

        /// <inheritdoc />
        public IObservable<Unit> Open(Location location, MapLaunchOptions launchOptions) =>
            Observable.FromAsync(() => Map.OpenAsync(location, launchOptions));

        /// <inheritdoc />
        public IObservable<Unit> Open(double latitude, double longitude, MapLaunchOptions launchOptions) =>
            Observable.FromAsync(() => Map.OpenAsync(latitude, longitude, launchOptions));
    }
}
