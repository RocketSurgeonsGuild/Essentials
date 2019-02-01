using System;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing the Main Thread.
    /// </summary>
    public interface IMainThread
    {
        /// <summary>
        /// Gets a value indicating whether this instance is main thread.
        /// </summary>
        bool IsMainThread { get; }

        /// <summary>
        /// Begins the invoke on main thread.
        /// </summary>
        /// <param name="action">The action.</param>
        void BeginInvokeOnMainThread(Action action);
    }
}