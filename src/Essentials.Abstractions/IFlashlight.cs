using System;
using System.Reactive;
using System.Threading.Tasks;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Flashlight features.
    /// </summary>
    public interface IFlashlight
    {
        /// <summary>
        /// Turns the on asynchronous.
        /// </summary>
        /// <returns>An obseervable sequence notification.</returns>
        IObservable<Unit> TurnOn();

        /// <summary>
        /// Turns the off asynchronous.
        /// </summary>
        /// <returns>An obseervable sequence notification.</returns>
        IObservable<Unit> TurnOff();
    }
}