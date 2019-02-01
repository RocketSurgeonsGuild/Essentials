using System;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Vibration features.
    /// </summary>
    public interface IVibration
    {
        /// <summary>
        /// Cancels this instance.
        /// </summary>
        void Cancel();

        /// <summary>
        /// Vibrates this instance.
        /// </summary>
        void Vibrate();

        /// <summary>
        /// Vibrates the specified duration.
        /// </summary>
        /// <param name="duration">The duration.</param>
        void Vibrate(double duration);

        /// <summary>
        /// Vibrates the specified duration.
        /// </summary>
        /// <param name="duration">The duration.</param>
        void Vibrate(TimeSpan duration);
    }
}