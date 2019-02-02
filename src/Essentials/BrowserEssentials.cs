using System;
using System.Diagnostics.CodeAnalysis;
using System.Reactive;
using System.Reactive.Linq;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access to the <see cref="Browser"/> API.
    /// </summary>
    /// <seealso cref="IBrowser" />
    [SuppressMessage("Usage", "CA2234:Pass system uri objects instead of strings", Justification = "Decorating API methods")]
    public class BrowserEssentials : IBrowser
    {
        /// <inheritdoc />
        public IObservable<Unit> Open(string uri) => Observable.FromAsync(() => Browser.OpenAsync(new Uri(uri)));

        /// <inheritdoc />
        public IObservable<Unit> Open(string uri, BrowserLaunchMode launchType) =>
            Observable.FromAsync(() => Browser.OpenAsync(uri, launchType));

        /// <inheritdoc />
        public IObservable<Unit> Open(Uri uri) => Observable.FromAsync(() => Browser.OpenAsync(uri));

        /// <inheritdoc />
        public IObservable<bool> Open(Uri uri, BrowserLaunchMode launchType) =>
            Observable.FromAsync(() => Browser.OpenAsync(uri, launchType));
    }
}
