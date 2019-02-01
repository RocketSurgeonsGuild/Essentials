using System.Collections.Generic;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Version Tracking features.
    /// </summary>
    public interface IVersionTracking
    {
        /// <summary>
        /// Gets the build history.
        /// </summary>
        IEnumerable<string> BuildHistory { get; }

        /// <summary>
        /// Gets the current build.
        /// </summary>
        string CurrentBuild { get; }

        /// <summary>
        /// Gets the current version.
        /// </summary>
        string CurrentVersion { get; }

        /// <summary>
        /// Gets the first installed build.
        /// </summary>
        string FirstInstalledBuild { get; }

        /// <summary>
        /// Gets the first installed version.
        /// </summary>
        string FirstInstalledVersion { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is first launch ever.
        /// </summary>
        bool IsFirstLaunchEver { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is first launch for current build.
        /// </summary>
        bool IsFirstLaunchForCurrentBuild { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is first launch for current version.
        /// </summary>
        bool IsFirstLaunchForCurrentVersion { get; }

        /// <summary>
        /// Gets the previous build.
        /// </summary>
        string PreviousBuild { get; }

        /// <summary>
        /// Gets the previous version.
        /// </summary>
        string PreviousVersion { get; }

        /// <summary>
        /// Gets the version history.
        /// </summary>
        IEnumerable<string> VersionHistory { get; }

        /// <summary>
        /// Determines whether [is first launch for build] [the specified build].
        /// </summary>
        /// <param name="build">The build.</param>
        /// <returns>
        ///   <c>true</c> if [is first launch for build] [the specified build]; otherwise, <c>false</c>.
        /// </returns>
        bool IsFirstLaunchForBuild(string build);

        /// <summary>
        /// Determines whether [is first launch for version] [the specified version].
        /// </summary>
        /// <param name="version">The version.</param>
        /// <returns>
        ///   <c>true</c> if [is first launch for version] [the specified version]; otherwise, <c>false</c>.
        /// </returns>
        bool IsFirstLaunchForVersion(string version);

        /// <summary>
        /// Tracks this instance.
        /// </summary>
        void Track();
    }
}