using System;
using System.Collections.Generic;
using System.Reactive;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Text to Speach features.
    /// </summary>
    public interface ITextToSpeech
    {
        /// <summary>
        /// Gets the locales asynchronous.
        /// </summary>
        /// <returns>The locales.</returns>
        Task<IEnumerable<Locale>> GetLocalesAsync();

        /// <summary>
        /// Speaks the asynchronous.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="cancelToken">The cancel token.</param>
        /// <returns>An observable sequence notification.</returns>
        IObservable<Unit> Speak(string text, CancellationToken cancelToken = default);

        /// <summary>
        /// Speaks the asynchronous.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="settings">The settings.</param>
        /// <param name="cancelToken">The cancel token.</param>
        /// <returns>An observable sequence notification.</returns>
        IObservable<Unit> Speak(string text, SpeechOptions settings, CancellationToken cancelToken = default);
    }
}