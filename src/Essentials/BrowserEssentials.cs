using System;
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
    public class BrowserEssentials : IBrowser
    {
        /// <inheritdoc />
        public IObservable<Unit> Open(string uri) => Observable.FromAsync(() => Browser.OpenAsync(uri));

        /// <inheritdoc />
        public IObservable<Unit> Open(string uri, BrowserLaunchMode launchType) => Observable.FromAsync(() => Browser.OpenAsync(uri, launchType));

        /// <inheritdoc />
        public IObservable<Unit> Open(Uri uri) => Observable.FromAsync(() => Browser.OpenAsync(uri));

        /// <inheritdoc />
        public IObservable<bool> Open(Uri uri, BrowserLaunchMode launchType) => Observable.FromAsync(() => Browser.OpenAsync(uri, launchType));
    }
}
