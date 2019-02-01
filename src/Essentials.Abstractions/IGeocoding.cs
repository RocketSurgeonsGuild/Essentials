﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Geocode features.
    /// </summary>
    public interface IGeocoding
    {
        /// <summary>
        /// Gets or sets the map key.
        /// </summary>
        string MapKey { get; set; }

        /// <summary>
        /// Gets the placemarks asynchronous.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <returns>The placemarks.</returns>
        Task<IEnumerable<Placemark>> GetPlacemarksAsync(Location location);

        /// <summary>
        /// Gets the placemarks asynchronous.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <returns>The placemarks.</returns>
        Task<IEnumerable<Placemark>> GetPlacemarksAsync(double latitude, double longitude);

        /// <summary>
        /// Gets the locations asynchronous.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <returns>The locations.</returns>
        Task<IEnumerable<Location>> GetLocationsAsync(string address);
    }
}