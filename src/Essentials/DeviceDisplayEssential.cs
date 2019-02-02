using System;
using System.Collections.Generic;
using System.Text;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access the the <see cref="DeviceDisplay"/> API.
    /// </summary>
    /// <seealso cref="IDeviceDisplay" />
    public class DeviceDisplayEssential : IDeviceDisplay
    {
        /// <inheritdoc />
        public bool KeepOnScreen
        {
            get => DeviceDisplay.KeepScreenOn;
            set => DeviceDisplay.KeepScreenOn = value;
        }

        /// <inheritdoc />
        public DisplayInfo DisplayInfo => DeviceDisplay.MainDisplayInfo;

        /// <inheritdoc />
        public IObservable<DisplayInfoChangedEventArgs> DisplayInfoChanged =>
            Events.DeviceDisplayMainDisplayInfoChanged();
    }
}
