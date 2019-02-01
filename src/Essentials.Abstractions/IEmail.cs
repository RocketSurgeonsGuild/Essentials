using System;
using System.Reactive;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Email features.
    /// </summary>
    public interface IEmail
    {
        /// <summary>
        /// Composes the asynchronous.
        /// </summary>
        /// <returns>An observable sequence notification.</returns>
        IObservable<Unit> ComposeAsync();

        /// <summary>
        /// Composes the asynchronous.
        /// </summary>
        /// <param name="subject">The subject.</param>
        /// <param name="body">The body.</param>
        /// <param name="to">To.</param>
        /// <returns>An observable sequence notification.</returns>
        IObservable<Unit> ComposeAsync(string subject, string body, params string[] to);

        /// <summary>
        /// Composes the asynchronous.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>An observable sequence notification.</returns>
        IObservable<Unit> ComposeAsync(EmailMessage message);
    }
}