using System;
using System.Reactive;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Browser features.
    /// </summary>
    public interface IBrowser
    {
        /// <summary>
        /// Opens the browser asynchronously.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <returns>An observable notification.</returns>
        IObservable<Unit> Open(string uri);

        /// <summary>
        /// Opens the browser asynchronously.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <param name="launchType">Type of the launch.</param>
        /// <returns>An observable notification.</returns>
        IObservable<Unit> Open(string uri, BrowserLaunchMode launchType);

        /// <summary>
        /// Opens the browser asynchronously.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <returns>An observable notification.</returns>
        IObservable<Unit> Open(Uri uri);

        /// <summary>
        /// Opens the browser asynchronously.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <param name="launchType">Type of the launch.</param>
        /// <returns>An observable notification.</returns>
        IObservable<Unit> Open(Uri uri, BrowserLaunchMode launchType);

        /// <summary>
        /// Opens the specified URI.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <param name="launchOptions">The launch options.</param>
        /// <returns>An observable notification.</returns>
        IObservable<bool> Open(Uri uri, BrowserLaunchOptions launchOptions);
    }
}