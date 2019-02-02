using System;
using System.Reactive;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Map features.
    /// </summary>
    public interface IMap
    {
        /// <summary>
        /// Opens the specified location.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <returns>An observable sequence notification.</returns>
        IObservable<Unit> Open(Location location);

        /// <summary>
        /// Opens the specified location.
        /// </summary>
        /// <param name="placemark">The placemark.</param>
        /// <returns> An observable sequence notification.</returns>
        IObservable<Unit> Open(Placemark placemark);

        /// <summary>
        /// Opens the specified lattitude and longitude.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <returns>An observable sequence notification.</returns>
        IObservable<Unit> Open(double latitude, double longitude);

        /// <summary>
        /// Opens the specified location.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="launchOptions">The launch options.</param>
        /// <returns>An observable sequence notification.</returns>
        IObservable<Unit> Open(Location location, MapLaunchOptions launchOptions);

        /// <summary>
        /// Opens the specified lattitude and longitude.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <param name="launchOptions">The launch options.</param>
        /// <returns>An observable sequence notification.</returns>
        IObservable<Unit> Open(double latitude, double longitude, MapLaunchOptions launchOptions);
    }
}