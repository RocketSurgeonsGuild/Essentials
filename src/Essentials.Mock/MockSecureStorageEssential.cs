using System;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using ReactiveUI;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;

namespace Essentials.Mock
{
    /// <summary>
    /// Mock secure storage essential.
    /// </summary>
    /// <seealso cref="ISecureStorage" />
    public class MockSecureStorageEssential : ISecureStorage
    {
        private IDictionary<string, string> _storage;

        /// <summary>
        /// Initializes a new instance of the <see cref="MockSecureStorageEssential"/> class.
        /// </summary>
        public MockSecureStorageEssential()
            : this(new Dictionary<string, string>())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MockSecureStorageEssential"/> class.
        /// </summary>
        /// <param name="storage">The storage.</param>
        public MockSecureStorageEssential(IDictionary<string, string> storage = null)
        {
            _storage = storage ?? new Dictionary<string, string>();
        }

        /// <inheritdoc />
        public IObservable<string> Get(string key) => Observable.Return(_storage[key]);

        /// <inheritdoc />
        public IObservable<Unit> Set(string key, string value)
        {
            _storage[key] = value;
            return Observable.Return(Unit.Default);
        }

        /// <inheritdoc />
        public bool Remove(string key)
        {
            var returnValue = _storage.TryGetValue(key, out string value);
            _storage.Remove(key);
            return returnValue;
        }

        /// <inheritdoc />
        public void RemoveAll()
        {
            _storage = new Dictionary<string, string>();
        }
    }
}
