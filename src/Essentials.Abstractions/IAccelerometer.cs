using System;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing the Accelerometer features.
    /// </summary>
    public interface IAccelerometer
    {
        /// <summary>
        /// Gets a value indicating whether the Accelerometer is monitoring.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is monitoring; otherwise, <c>false</c>.
        /// </value>
        bool IsMonitoring { get; }

        /// <summary>
        /// Gets the Accelerometer changed events.
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