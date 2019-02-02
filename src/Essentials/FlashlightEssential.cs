using System;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access to the <see cref="Flashlight"/> API.
    /// </summary>
    /// <seealso cref="IFlashlight" />
    public class FlashlightEssential : IFlashlight
    {
        /// <inheritdoc />
        public IObservable<Unit> TurnOn() => Observable.FromAsync(Flashlight.TurnOnAsync);

        /// <inheritdoc />
        public IObservable<Unit> TurnOff() => Observable.FromAsync(Flashlight.TurnOffAsync);
    }
}
