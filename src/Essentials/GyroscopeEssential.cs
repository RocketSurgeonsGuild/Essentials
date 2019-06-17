using System;
using System.Collections.Generic;
using System.Text;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access to the <see cref="Gyroscope"/> API.
    /// </summary>
    /// <seealso cref="IGyroscope" />
    public class GyroscopeEssential : IGyroscope
    {
        /// <inheritdoc />
        public bool IsMonitoring => Gyroscope.IsMonitoring;

        /// <inheritdoc />
        public IObservable<GyroscopeChangedEventArgs> GyroscopeChanged => Events.GyroscopeReadingChanged;

        /// <inheritdoc />
        public void Start(SensorSpeed sensorSpeed = SensorSpeed.Default) => Gyroscope.Start(sensorSpeed);

        /// <inheritdoc />
        public void Stop() => Gyroscope.Stop();
    }
}
