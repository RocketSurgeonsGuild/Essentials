using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Magnetometer features.
    /// </summary>
    public interface IMagnetometer
    {
        /// <summary>
        /// Gets a value indicating whether this instance is monitoring.
        /// </summary>
        bool IsMonitoring { get; }

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