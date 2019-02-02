using System;
using System.Diagnostics.CodeAnalysis;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Compass features.
    /// </summary>
    [SuppressMessage("Naming", "CA1716:Identifiers should not match keywords", Justification = "Decorating API methods")]
    public interface ICompass
    {
        /// <summary>
        /// Gets a value indicating whether the compass is monitoring.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is monitoring; otherwise, <c>false</c>.
        /// </value>
        bool IsMonitoring { get; }

        /// <summary>
        /// Gets an observablesequence compass changed events.
        /// </summary>
        /// <value>
        /// The compass changed.
        /// </value>
        IObservable<CompassChangedEventArgs> CompassChanged { get; }

        /// <summary>
        /// Starts the compass with the specified sensor speed.
        /// </summary>
        /// <param name="sensorSpeed">The sensor speed.</param>
        void Start(SensorSpeed sensorSpeed = SensorSpeed.Default);

        /// <summary>
        /// Stops the compass.
        /// </summary>
        void Stop();
    }
}