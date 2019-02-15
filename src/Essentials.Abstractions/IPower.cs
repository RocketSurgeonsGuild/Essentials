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
        /// Gets the energy saver status changed events observable sequence.
        /// </summary>
        IObservable<EnergySaverStatusChangedEventArgs> EnergySaverStatusChanged { get; }
    }
}