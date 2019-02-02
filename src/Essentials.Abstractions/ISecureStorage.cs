using System;
using System.Diagnostics.CodeAnalysis;
using System.Reactive;
using System.Threading.Tasks;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Secure Storage features.
    /// </summary>
    [SuppressMessage("Naming", "CA1716:Identifiers should not match keywords", Justification = "Decorating API methods")]
    public interface ISecureStorage
    {
        /// <summary>
        /// Gets the asynchronously.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>The value.</returns>
        IObservable<string> Get(string key);

        /// <summary>
        /// Sets the asynchronously.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <returns>An observable sequence notification.</returns>
        IObservable<Unit> Set(string key, string value);

        /// <summary>
        /// Removes the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>Whether this key was removed.</returns>
        bool Remove(string key);

        /// <summary>
        /// Removes all.
        /// </summary>
        void RemoveAll();
    }
}