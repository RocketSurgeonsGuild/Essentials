using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access to the <see cref="Location"/> API.
    /// </summary>
    /// <seealso cref="IGeolocation" />
    public class GeolocationEssential : IGeolocation
    {
        /// <inheritdoc />
        public IObservable<Location> GetLastKnownLocation() =>
            Observable.FromAsync(Geolocation.GetLastKnownLocationAsync);

        /// <inheritdoc />
        public IObservable<Location> GetLocation() => Observable.FromAsync(Geolocation.GetLocationAsync);

        /// <inheritdoc />
        public IObservable<Location> GetLocation(GeolocationRequest request) =>
            Observable.FromAsync(() => Geolocation.GetLocationAsync(request));
    }
}
