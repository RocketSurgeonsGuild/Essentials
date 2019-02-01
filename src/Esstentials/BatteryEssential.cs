using System;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access to <see cref="Battery"/> API.
    /// </summary>
    /// <seealso cref="IBattery" />
    public class BatteryEssential : IBattery
    {
        /// <inheritdoc />
        public double ChargeLevel => Battery.ChargeLevel;

        /// <inheritdoc />
        public BatteryState State => Battery.State;

        /// <inheritdoc />
        public BatteryPowerSource PowerSource => Battery.PowerSource;

        /// <inheritdoc />
        public IObservable<BatteryInfoChangedEventArgs> BatteryChanged => Events.BatteryBatteryInfoChanged();
    }
}