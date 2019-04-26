using System;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Geolocation features.
    /// </summary>
    public interface IGeolocation
    {
        /// <summary>
        /// Gets the last known location asynchronous.
        /// </summary>
        /// <returns>An observable sequence of locations.</returns>
        [Obsolete("Use the task based implementations instead.")]
        IObservable<Location> GetLastKnownLocation();

        /// <summary>
        /// Gets the location asynchronous.
        /// </summary>
        /// <returns>An observable sequence of locations.</returns>
        [Obsolete("Use the task based implementations instead.")]
        IObservable<Location> GetLocation();

        /// <summary>
        /// Gets the location asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>An observable sequence of locations.</returns>
        [Obsolete("Use the task based implementations instead.")]
        IObservable<Location> GetLocation(GeolocationRequest request);

        /// <summary>
        /// Gets the last known location asynchronous.
        /// </summary>
        /// <returns>An observable sequence of locations.</returns>
        Task<Location> GetLastKnownLocationAsync();

        /// <summary>
        /// Gets the location asynchronous.
        /// </summary>
        /// <returns>An observable sequence of locations.</returns>
        Task<Location> GetLocationAsync();

        /// <summary>
        /// Gets the location asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>An observable sequence of locations.</returns>
        Task<Location> GetLocationAsync(GeolocationRequest request);
    }
}