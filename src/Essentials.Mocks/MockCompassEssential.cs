using System;
using System.Collections.Generic;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using ReactiveUI;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Essentials.Mocks
{
    /// <summary>
    /// Mock compass essential.
    /// </summary>
    /// <seealso cref="Rocket.Surgery.Xamarin.Essentials.Abstractions.ICompass" />
    public class MockCompassEssential : ReactiveObject, ICompass
    {
        private readonly Subject<bool> _monitor = new Subject<bool>();
        private readonly ObservableAsPropertyHelper<bool> _isMonitoring;
        private IObservable<CompassChangedEventArgs> _compassChanged;

        /// <summary>
        /// Initializes a new instance of the <see cref="MockCompassEssential" /> class.
        /// </summary>
        /// <param name="scheduler">The scheduler.</param>
        /// <param name="seconds">The seconds.</param>
        /// <param name="heading">The heading.</param>
        public MockCompassEssential(IScheduler scheduler, double seconds = 1, double heading = 10)
        {
            _isMonitoring = this.WhenAnyObservable(x => x._monitor).ToProperty(this, x => x.IsMonitoring);

            CompassChanged =
                Observable
                    .Interval(TimeSpan.FromSeconds(seconds), scheduler)
                    .Select(_ => ChangeCompass(_, heading));
        }

        /// <inheritdoc />
        public bool IsMonitoring => _isMonitoring.Value;

        /// <inheritdoc />
        public IObservable<CompassChangedEventArgs> CompassChanged { get; }

        /// <inheritdoc />
        public void Start(SensorSpeed sensorSpeed = SensorSpeed.Default)
        {
            _monitor.OnNext(true);
        }

        /// <inheritdoc />
        public void Stop()
        {
            _monitor.OnNext(false);
        }

        private static CompassChangedEventArgs ChangeCompass(long interval, double heading) =>
            new CompassChangedEventArgs(CompassData(interval, heading));

        private static CompassData CompassData(long interval, double heading) => new CompassData(interval * heading);
    }
}
