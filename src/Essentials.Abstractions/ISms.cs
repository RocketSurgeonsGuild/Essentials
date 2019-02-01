using System;
using System.Reactive;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing SMS features.
    /// </summary>
    public interface ISms
    {
        /// <summary>
        /// Composes the sms asynchronously.
        /// </summary>
        /// <returns>An observable sequence notification.</returns>
        IObservable<Unit> Compose();

        /// <summary>
        /// Composes the asynchronous.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>An observable sequence notification.</returns>
        IObservable<Unit> Compose(SmsMessage message);
    }
}