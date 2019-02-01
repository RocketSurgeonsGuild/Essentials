using System;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides acces to the <see cref="OrientationSensor"/> API.
    /// </summary>
    /// <seealso cref="IOrientationSensor" />
    public class OrientationSensorEssential : IOrientationSensor
    {
        /// <inheritdoc />
        public bool IsMonitoring => OrientationSensor.IsMonitoring;

        /// <inheritdoc />
        public IObservable<OrientationSensorChangedEventArgs> OrientationSensorChanged =>
            Events.OrientationSensorReadingChanged();

        /// <inheritdoc />
        public void Start(SensorSpeed sensorSpeed = SensorSpeed.Default) => OrientationSensor.Start(sensorSpeed);

        /// <inheritdoc />
        public void Stop() => OrientationSensor.Stop();
    }
}
