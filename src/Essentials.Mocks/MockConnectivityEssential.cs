using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using ReactiveUI;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Essentials.Mocks
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
        private readonly ObservableAsPropertyHelper<IEnumerable<ConnectionProfile>> _connectionProfile;
        private IScheduler _scheduler;
        private IEnumerable<NetworkAccess> _networkAccesses;
        private IEnumerable<ConnectionProfile> _connectionProfiles;

        /// <summary>
        /// Initializes a new instance of the <see cref="MockConnectivityEssential" /> class.
        /// </summary>
        /// <param name="scheduler">The scheduler.</param>
        /// <param name="seconds">The seconds.</param>
        /// <param name="networkAccesses">The network accesses.</param>
        public MockConnectivityEssential(IScheduler scheduler = null, double seconds = 2, IEnumerable<NetworkAccess> networkAccesses = default)
        {
            _scheduler = scheduler ?? RxApp.MainThreadScheduler;
            _seconds = seconds;
            _networkAccesses = networkAccesses ?? new[]
            {
                NetworkAccess.Unknown,
                NetworkAccess.None,
                NetworkAccess.Local,
                NetworkAccess.ConstrainedInternet,
                NetworkAccess.Internet
            };
            _connectionProfiles = new[] { ConnectionProfile.Unknown };
            _networkAccess = Observable
                .Interval(TimeSpan.FromSeconds(_seconds), _scheduler)
                .Select(_ => _networkAccesses.Reverse().First(access => access != _networkAccess.Value))
                .ToProperty(this, x => x.NetworkAccess);

            ConnectivityChanged = Observable
                .Interval(TimeSpan.FromSeconds(_seconds), _scheduler)
                .Select(x => ChangeConnectivity(_networkAccess.Value, _connectionProfiles));

            _connectionProfile =
                ConnectivityChanged.Select(_ => _.ConnectionProfiles).ToProperty(this, x => x.Profiles);
        }

        /// <inheritdoc />
        public virtual NetworkAccess NetworkAccess => _networkAccess?.Value ?? NetworkAccess.Unknown;

        /// <inheritdoc />
        public virtual IEnumerable<ConnectionProfile> Profiles => _connectionProfile?.Value ?? _connectionProfiles;

        /// <inheritdoc />
        public IObservable<ConnectivityChangedEventArgs> ConnectivityChanged { get; }

        private static ConnectivityChangedEventArgs ChangeConnectivity(NetworkAccess networkAccess, IEnumerable<ConnectionProfile> connectionProfiles) =>
            new ConnectivityChangedEventArgs(networkAccess, connectionProfiles);
    }
}
