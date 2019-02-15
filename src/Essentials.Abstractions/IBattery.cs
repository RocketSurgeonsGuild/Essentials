using System;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Battery features.
    /// </summary>
    public interface IBattery
    {
        /// <summary>
        /// Gets the charge level.
        /// </summary>
        double ChargeLevel { get; }

        /// <summary>
        /// Gets the state.
        /// </summary>
        BatteryState State { get; }

        /// <summary>
        /// Gets the power source.
        /// </summary>
        BatteryPowerSource PowerSource { get; }

        /// <summary>
        /// Gets the battery changed events observable sequence.
        /// </summary>
        IObservable<BatteryInfoChangedEventArgs> BatteryChanged { get; }
    }
}