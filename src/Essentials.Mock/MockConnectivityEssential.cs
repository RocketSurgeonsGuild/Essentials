using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using ReactiveUI;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Essentials.Mock
{
    /// <summary>
    /// Mock connectivity essential.
    /// </summary>
    /// <seealso cref="ReactiveObject" />
    /// <seealso cref="IConnectivity" />
    public class MockConnectivityEssential : ReactiveObject, IConnectivity
    {
        private readonly double _seconds;
        private readonly ObservableAsPropertyHelper<NetworkAccess> _networkAccess;

        /// <summary>
        /// Initializes a new instance of the <see cref="MockConnectivityEssential" /> class.
        /// </summary>
        /// <param name="scheduler">The scheduler.</param>
        /// <param name="seconds">The seconds.</param>
        /// <param name="networkAccesses">The network accesses.</param>
        public MockConnectivityEssential(IScheduler scheduler, double seconds = 2, IEnumerable<NetworkAccess> networkAccesses = default)
        {
            _seconds = seconds;
            networkAccesses = networkAccesses ?? new[]
            {
                NetworkAccess.Unknown,
                NetworkAccess.None,
                NetworkAccess.Local,
                NetworkAccess.ConstrainedInternet,
                NetworkAccess.Internet
            };

            _networkAccess = Observable
                .Interval(TimeSpan.FromSeconds(_seconds), scheduler)
                .Select(_ => networkAccesses.Reverse().First(access => access != _networkAccess.Value))
                .ToProperty(this, x => x.NetworkAccess);

            ConnectivityChanged = Observable
                .Interval(TimeSpan.FromSeconds(_seconds), scheduler)
                .Select(x => ChangeConnectivity(_networkAccess.Value));
        }

        /// <inheritdoc />
        public virtual NetworkAccess NetworkAccess => _networkAccess.Value;

        /// <inheritdoc />
        public IEnumerable<ConnectionProfile> Profiles { get; }

        /// <summary>
        /// Gets the connectivity changed.
        /// </summary>
        public IObservable<ConnectivityChangedEventArgs> ConnectivityChanged { get; }

        private static ConnectivityChangedEventArgs ChangeConnectivity(NetworkAccess networkAccess) =>
            new ConnectivityChangedEventArgs(networkAccess, Enumerable.Empty<ConnectionProfile>());
    }
}
