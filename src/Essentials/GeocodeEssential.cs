using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access to the <see cref="Geocoding"/> API.
    /// </summary>
    /// <seealso cref="IGeocode" />
    public class GeocodeEssential : IGeocode
    {
        /// <inheritdoc />
        public string MapKey { get; set; }

        /// <inheritdoc />
        public async Task<IEnumerable<Placemark>> GetPlacemarksAsync(Location location) =>
            await Geocoding.GetPlacemarksAsync(location).ContinueOnAnyContext();

        /// <inheritdoc />
        public async Task<IEnumerable<Placemark>> GetPlacemarksAsync(double latitude, double longitude) =>
            await Geocoding.GetPlacemarksAsync(latitude, longitude).ContinueOnAnyContext();

        /// <inheritdoc />
        public async Task<IEnumerable<Location>> GetLocationsAsync(string address) =>
            await Geocoding.GetLocationsAsync(address).ContinueOnAnyContext();
    }
}
