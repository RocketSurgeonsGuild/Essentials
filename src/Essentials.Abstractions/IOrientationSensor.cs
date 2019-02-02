using System;
using System.Diagnostics.CodeAnalysis;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Orientation Sensor features.
    /// </summary>
    [SuppressMessage("Naming", "CA1716:Identifiers should not match keywords", Justification = "Decorating API methods")]
    public interface IOrientationSensor
    {
        /// <summary>
        /// Gets a value indicating whether this instance is monitoring.
        /// </summary>
        bool IsMonitoring { get; }

        /// <summary>
        /// Gets the orientation sensor changed.
        /// </summary>
        IObservable<OrientationSensorChangedEventArgs> OrientationSensorChanged { get; }

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