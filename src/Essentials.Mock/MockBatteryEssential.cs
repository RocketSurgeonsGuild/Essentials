using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Text;
using ReactiveUI;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials.Mock
{
    /// <summary>
    /// Mock battery essential.
    /// </summary>
    /// <seealso cref="Rocket.Surgery.Xamarin.Essentials.Abstractions.IBattery" />
    public class MockBatteryEssential : ReactiveObject, IBattery
    {
        private readonly IScheduler _scheduler;
        private readonly double _seconds;
        private readonly ObservableAsPropertyHelper<BatteryState> _batteryState;
        private readonly ObservableAsPropertyHelper<BatteryPowerSource> _batterPowerSource;
        private readonly ObservableAsPropertyHelper<double> _chargeLevel;

        /// <summary>
        /// Initializes a new instance of the <see cref="MockBatteryEssential" /> class.
        /// </summary>
        /// <param name="scheduler">The scheduler.</param>
        /// <param name="seconds">The seconds.</param>
        /// <param name="batteryStates">The battery states.</param>
        /// <param name="batteryPowerSources">The battery power sources.</param>
        public MockBatteryEssential(
            IScheduler scheduler = null,
            double seconds = 2,
            IEnumerable<BatteryState> batteryStates = null,
            IEnumerable<BatteryPowerSource> batteryPowerSources = null)
        {
            _scheduler = scheduler ?? RxApp.MainThreadScheduler;
            batteryStates = batteryStates ?? new[] { BatteryState.Charging, BatteryState.Full };
            batteryPowerSources = batteryPowerSources ?? new[] { BatteryPowerSource.Battery, BatteryPowerSource.AC };

            BatteryChanged = Observable.Interval(TimeSpan.FromSeconds(seconds), _scheduler).Select(_ =>
                new BatteryInfoChangedEventArgs(_chargeLevel.Value, _batteryState.Value, _batterPowerSource.Value));

            _chargeLevel = Observable
                .Interval(TimeSpan.FromSeconds(seconds), _scheduler)
                .Scan(99, (previous, next) => previous - 1).Select(Convert.ToDouble)
                .ToProperty(this, x => x.ChargeLevel);

            _batteryState =
                Observable
                    .Interval(TimeSpan.FromSeconds(seconds))
                    .Select(x => batteryStates.First())
                    .ToProperty(this, x => x.State);

            _batterPowerSource = BatteryChanged.Select(x => x.PowerSource).ToProperty(this, x => x.PowerSource);
        }

        /// <inheritdoc />
        public double ChargeLevel => _chargeLevel.Value;

        /// <inheritdoc />
        public BatteryState State => _batteryState.Value;

        /// <inheritdoc />
        public BatteryPowerSource PowerSource => _batterPowerSource.Value;

        /// <inheritdoc />
        public IObservable<BatteryInfoChangedEventArgs> BatteryChanged { get; }

        /// <summary>
        /// Gets the factory.
        /// </summary>
        public virtual Func<BatteryInfoChangedEventArgs> Factory { get; } = () =>
            new BatteryInfoChangedEventArgs(99, BatteryState.Discharging, BatteryPowerSource.Battery);

        /// <summary>
        /// A factory method that will provide the change observable new <see cref="BatteryInfoChangedEventArgs"/>.
        /// </summary>
        /// <returns>The event args.</returns>
        public BatteryInfoChangedEventArgs ChangeBattery() => Factory();
    }
}
