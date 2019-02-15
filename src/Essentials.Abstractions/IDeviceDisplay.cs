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
        /// Gets or sets a value indicating whether [keep on screen].
        /// </summary>
        bool KeepOnScreen { get; set; }

        /// <summary>
        /// Gets the display information.
        /// </summary>
        DisplayInfo DisplayInfo { get; }

        /// <summary>
        /// Gets the screen metrics changed event observable sequence.
        /// </summary>
        IObservable<DisplayInfoChangedEventArgs> DisplayInfoChanged { get; }
    }
}