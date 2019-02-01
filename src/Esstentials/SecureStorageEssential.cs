using System;
using System.Reactive;
using System.Reactive.Linq;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access to the <see cref="SecureStorage"/> API.
    /// </summary>
    /// <seealso cref="Rocket.Surgery.Xamarin.Essentials.Abstractions.ISecureStorage" />
    public class SecureStorageEssential : ISecureStorage
    {
        /// <inheritdoc />
        public IObservable<string> Get(string key) => Observable.FromAsync(() => SecureStorage.GetAsync(key));

        /// <inheritdoc/>
        public IObservable<Unit> Set(string key, string value) =>
            Observable.FromAsync(() => SecureStorage.SetAsync(key, value));

        /// <inheritdoc />
        public bool Remove(string key) => SecureStorage.Remove(key);

        /// <inheritdoc />
        public void RemoveAll() => SecureStorage.RemoveAll();
    }
}
