using System;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access to the <see cref="DeviceInfo"/> API.
    /// </summary>
    /// <seealso cref="IDeviceInfo" />
    public class DeviceInfoEssential : IDeviceInfo
    {
        /// <inheritdoc />
        public DeviceType DeviceType => DeviceInfo.DeviceType;

        /// <inheritdoc />
        public string Idiom => DeviceInfo.Idiom.ToString();

        /// <inheritdoc />
        public string Manufacturer => DeviceInfo.Manufacturer;

        /// <inheritdoc />
        public string Name => DeviceInfo.Name;

        /// <inheritdoc />
        public string Platform => DeviceInfo.Platform.ToString();

        /// <inheritdoc />
        public Version Version => DeviceInfo.Version;

        /// <inheritdoc />
        public string VersionString => DeviceInfo.VersionString;

        /// <inheritdoc />
        public string Model => DeviceInfo.Model;
    }
}