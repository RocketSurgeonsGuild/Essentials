using System;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access to the <see cref="Accelerometer"/> API.
    /// </summary>
    /// <seealso cref="IAccelerometer" />
    public class AccelerometerEssential : IAccelerometer
    {
        /// <inheritdoc />
        public bool IsMonitoring => Accelerometer.IsMonitoring;

        /// <inheritdoc />
        public IObservable<AccelerometerChangedEventArgs> ReadChanged => Events.AccelerometerReadingChanged();

        /// <inheritdoc />
        public void Start(SensorSpeed sensorSpeed = SensorSpeed.Default) => Accelerometer.Start(sensorSpeed);

        /// <inheritdoc />
        public void Stop() => Accelerometer.Stop();
    }
}
