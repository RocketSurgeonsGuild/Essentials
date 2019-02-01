using System;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Device Display features.
    /// </summary>
    public interface IDeviceDisplay
    {
        /// <summary>
        /// Gets the display information.
        /// </summary>
        DisplayInfo DisplayInfo { get; }

        /// <summary>
        /// Gets the screen metrics changed event handler.
        /// </summary>
        /// <value>
        /// The screen metrics changed event handler.
        /// </value>
        IObservable<DisplayInfoChangedEventArgs> DisplayInfoChanged { get; }
    }
}