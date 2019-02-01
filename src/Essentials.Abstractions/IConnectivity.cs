using System;
using System.Collections.Generic;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing the Network Connectivity features.
    /// </summary>
    public interface IConnectivity
    {
        /// <summary>
        /// Gets the network access.
        /// </summary>
        NetworkAccess NetworkAccess { get; }

        /// <summary>
        /// Gets the connection profiles.
        /// </summary>
        IEnumerable<ConnectionProfile> Profiles { get; }

        /// <summary>
        /// Gets the connectivity changed.
        /// </summary>
        IObservable<ConnectivityChangedEventArgs> ConnectivityChanged { get; }
    }
}