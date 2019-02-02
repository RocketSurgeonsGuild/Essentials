using System;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access to the <see cref="Battery"/> API.
    /// </summary>
    /// <seealso cref="Rocket.Surgery.Xamarin.Essentials.Abstractions.IPower" />
    public class PowerEssential : IPower
    {
        /// <inheritdoc />
        public EnergySaverStatus EnergySaverStatus => Battery.EnergySaverStatus;

        /// <inheritdoc />
        public IObservable<EnergySaverStatusChangedEventArgs> EnergySaverStatusChanged =>
            Events.BatteryEnergySaverStatusChanged();
    }
}
