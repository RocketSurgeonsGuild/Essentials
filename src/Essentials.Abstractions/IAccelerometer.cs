using System;
using System.Diagnostics.CodeAnalysis;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing the Accelerometer features.
    /// </summary>
    [SuppressMessage("Naming", "CA1716:Identifiers should not match keywords", Justification = "Decorating API methods")]
    public interface IAccelerometer
    {
        /// <summary>
        /// Gets a value indicating whether the Accelerometer is monitoring.
        /// </summary>
        bool IsMonitoring { get; }

        /// <summary>
        /// Gets the Accelerometer changed events observable sequence.
        /// </summary>
        IObservable<AccelerometerChangedEventArgs> ReadChanged { get; }

        /// <summary>
        /// Starts the Accelerometer with specified sensor speed.
        /// </summary>
        /// <param name="sensorSpeed">The sensor speed.</param>
        void Start(SensorSpeed sensorSpeed = SensorSpeed.Default);

        /// <summary>
        /// Stops the Accelerometer.
        /// </summary>
        void Stop();
    }
}