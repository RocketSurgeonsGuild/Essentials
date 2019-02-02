using System;
using System.Diagnostics.CodeAnalysis;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Magnetometer features.
    /// </summary>
    [SuppressMessage("Naming", "CA1716:Identifiers should not match keywords", Justification = "Decorating API methods")]
    public interface IMagnetometer
    {
        /// <summary>
        /// Gets a value indicating whether this instance is monitoring.
        /// </summary>
        bool IsMonitoring { get; }

        /// <summary>
        /// Gets an observable sequence of magnetometer changed events.
        /// </summary>
        IObservable<MagnetometerChangedEventArgs> MagnetometerChanged { get; }

        /// <summary>
        /// Starts the specified sensor speed.
        /// </summary>
        /// <param name="sensorSpeed">The sensor speed.</param>
        void Start(SensorSpeed sensorSpeed = SensorSpeed.Default);

        /// <summary>
        /// Stops this instance.
        /// </summary>
        void Stop();
    }
}