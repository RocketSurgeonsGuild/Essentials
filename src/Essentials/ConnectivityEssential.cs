using System;
using System.Collections.Generic;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access to the <see cref="Connectivity"/> API.
    /// </summary>
    /// <seealso cref="IConnectivity" />
    public class ConnectivityEssential : IConnectivity
    {
        /// <inheritdoc />
        public NetworkAccess NetworkAccess => Connectivity.NetworkAccess;

        /// <inheritdoc />
        public IEnumerable<ConnectionProfile> Profiles => Connectivity.ConnectionProfiles;

        /// <inheritdoc />
        public IObservable<ConnectivityChangedEventArgs> ConnectivityChanged =>
            Events.ConnectivityConnectivityChanged;
    }
}
