using System;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access to the <see cref="AppInfo"/> API.
    /// </summary>
    /// <seealso cref="IAppInfo" />
    public class AppInfoEssential : IAppInfo
    {
        /// <inheritdoc />
        public string PackageName => AppInfo.PackageName;

        /// <inheritdoc />
        public string Name => AppInfo.Name;

        /// <inheritdoc />
        public string VersionString => AppInfo.VersionString;

        /// <inheritdoc />
        public Version Version => AppInfo.Version;

        /// <inheritdoc />
        public string BuildString => AppInfo.BuildString;

        /// <inheritdoc />
        public void OpenSettings() => AppInfo.ShowSettingsUI();
    }
}
