using System;
using System.Collections.Generic;
using System.Text;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access to the <see cref="Compass"/> API.
    /// </summary>
    /// <seealso cref="ICompass" />
    public class CompasEssential : ICompass
    {
        /// <inheritdoc />
        public bool IsMonitoring { get; }

        /// <inheritdoc />
        public IObservable<CompassChangedEventArgs> CompassChanged => Events.CompassReadingChanged();

        /// <inheritdoc />
        public void Start(SensorSpeed sensorSpeed = SensorSpeed.Default) => Compass.Start(sensorSpeed);

        /// <inheritdoc />
        public void Stop() => Compass.Stop();
    }
}
