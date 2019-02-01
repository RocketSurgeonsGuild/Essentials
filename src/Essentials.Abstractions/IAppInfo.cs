using System;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Application Info.
    /// </summary>
    public interface IAppInfo
    {
        /// <summary>
        /// Gets the name of the package.
        /// </summary>
        string PackageName { get; }

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
        /// Gets the build string.
        /// </summary>
        string BuildString { get; }

        /// <summary>
        /// Opens the settings.
        /// </summary>
        void OpenSettings();
    }
}