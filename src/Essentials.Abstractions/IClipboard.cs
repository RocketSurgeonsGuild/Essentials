﻿using System;
using System.Threading.Tasks;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Clipboard features.
    /// </summary>
    public interface IClipboard
    {
        /// <summary>
        /// Gets a value indicating whether this instance has text.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has text; otherwise, <c>false</c>.
        /// </value>
        bool HasText { get; }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        void SetText(string text);

        /// <summary>
        /// Gets the text asynchronous.
        /// </summary>
        /// <returns>The text.</returns>
        IObservable<string> GetTextAsync();
    }
}