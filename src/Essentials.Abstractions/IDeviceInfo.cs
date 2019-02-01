using System;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Device Information features.
    /// </summary>
    public interface IDeviceInfo
    {
        /// <summary>
        /// Gets the model.
        /// </summary>
        string Model { get; }

        /// <summary>
        /// Gets the manufacturer.
        /// </summary>
        string Manufacturer { get; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the version string.
        /// </summary>
        string VersionString { get; }

        /// <summary>
        /// Gets the version.
        /// </summary>
        Version Version { get; }

        /// <summary>
        /// Gets the platform.
        /// </summary>
        string Platform { get; }

        /// <summary>
        /// Gets the idiom.
        /// </summary>
        string Idiom { get; }

        /// <summary>
        /// Gets the type of the device.
        /// </summary>
        DeviceType DeviceType { get; }
    }
}