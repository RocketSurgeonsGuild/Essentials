using System;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access to the <see cref="Vibration"/> API.
    /// </summary>
    /// <seealso cref="IVibration" />
    public class VibrationEssential : IVibration
    {
        /// <inheritdoc />
        public void Cancel() => Vibration.Cancel();

        /// <inheritdoc />
        public void Vibrate() => Vibration.Vibrate();

        /// <inheritdoc />
        public void Vibrate(double duration) => Vibration.Vibrate(duration);

        /// <inheritdoc />
        public void Vibrate(TimeSpan duration) => Vibration.Vibrate(duration);
    }
}
