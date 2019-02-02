using System;
using System.Collections.Generic;
using System.Text;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access to the <see cref="Magnetometer"/> API.
    /// </summary>
    /// <seealso cref="IMagnetometer" />
    public class MagnetometerEssential : IMagnetometer
    {
        /// <inheritdoc />
        public bool IsMonitoring => Magnetometer.IsMonitoring;

        /// <inheritdoc />
        public IObservable<MagnetometerChangedEventArgs> MagnetometerChanged => Events.MagnetometerReadingChanged();

        /// <inheritdoc />
        public void Start(SensorSpeed sensorSpeed = SensorSpeed.Default) => Magnetometer.Start(sensorSpeed);

        /// <inheritdoc />
        public void Stop() => Magnetometer.Stop();
    }
}
