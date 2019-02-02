using System.Collections.Generic;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access to the <see cref="VersionTracking"/> API.
    /// </summary>
    /// <seealso cref="IVersionTracking" />
    public class VersionTrackingEssential : IVersionTracking
    {
        /// <inheritdoc />
        public IEnumerable<string> BuildHistory => VersionTracking.BuildHistory;

        /// <inheritdoc />
        public string CurrentBuild => VersionTracking.CurrentBuild;

        /// <inheritdoc />
        public string CurrentVersion => VersionTracking.CurrentVersion;

        /// <inheritdoc />
        public string FirstInstalledBuild => VersionTracking.FirstInstalledBuild;

        /// <inheritdoc />
        public string FirstInstalledVersion => VersionTracking.FirstInstalledVersion;

        /// <inheritdoc />
        public bool IsFirstLaunchEver => VersionTracking.IsFirstLaunchEver;

        /// <inheritdoc />
        public bool IsFirstLaunchForCurrentBuild => VersionTracking.IsFirstLaunchForCurrentBuild;

        /// <inheritdoc />
        public bool IsFirstLaunchForCurrentVersion => VersionTracking.IsFirstLaunchForCurrentVersion;

        /// <inheritdoc />
        public string PreviousBuild => VersionTracking.PreviousBuild;

        /// <inheritdoc />
        public string PreviousVersion => VersionTracking.PreviousVersion;

        /// <inheritdoc />
        public IEnumerable<string> VersionHistory => VersionTracking.VersionHistory;

        /// <inheritdoc />
        public bool IsFirstLaunchForBuild(string build) => VersionTracking.IsFirstLaunchForBuild(build);

        /// <inheritdoc />
        public bool IsFirstLaunchForVersion(string version) => VersionTracking.IsFirstLaunchForVersion(version);

        /// <inheritdoc />
        public void Track() => VersionTracking.Track();
    }
}