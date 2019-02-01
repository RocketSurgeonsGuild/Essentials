using System;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Power features.
    /// </summary>
    public interface IPower
    {
        /// <summary>
        /// Gets the energy saver status.
        /// </summary>
        EnergySaverStatus EnergySaverStatus { get; }

        /// <summary>
        /// Gets the energy saver status changed.
        /// </summary>
        /// <value>
        /// The energy saver status changed.
        /// </value>
        IObservable<EnergySaverStatusChangedEventArgs> EnergySaverStatusChanged { get; }
    }
}