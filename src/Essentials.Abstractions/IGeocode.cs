using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Geocode features.
    /// </summary>
    public interface IGeocode
    {
        /// <summary>
        /// Gets or sets the map key.
        /// </summary>
        string MapKey { get; set; }

        /// <summary>
        /// Gets the placemarks asynchronously.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <returns>The placemarks.</returns>
        Task<IEnumerable<Placemark>> GetPlacemarksAsync(Location location);

        /// <summary>
        /// Gets the placemarks asynchronously.
        /// </summary>
        /// <param name="latitude">The latitude.</param>
        /// <param name="longitude">The longitude.</param>
        /// <returns>The placemarks.</returns>
        Task<IEnumerable<Placemark>> GetPlacemarksAsync(double latitude, double longitude);

        /// <summary>
        /// Gets the locations asynchronously.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <returns>The locations.</returns>
        Task<IEnumerable<Location>> GetLocationsAsync(string address);
    }
}