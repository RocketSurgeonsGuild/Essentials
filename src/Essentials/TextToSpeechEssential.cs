using System;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access to the <see cref="TextToSpeech"/> API.
    /// </summary>
    /// <seealso cref="ITextToSpeech" />
    public class TextToSpeechEssential : ITextToSpeech
    {
        /// <inheritdoc />
        public async Task<IEnumerable<Locale>> GetLocalesAsync() => await TextToSpeech.GetLocalesAsync().ConfigureAwait(false);

        /// <inheritdoc />
        public IObservable<Unit> Speak(string text, CancellationToken cancelToken = default) =>
            Observable.FromAsync(() => TextToSpeech.SpeakAsync(text, cancelToken));

        /// <inheritdoc />
        public IObservable<Unit> Speak(string text, SpeechOptions settings, CancellationToken cancelToken = default) =>
            Observable.FromAsync(() => TextToSpeech.SpeakAsync(text, settings, cancelToken));
    }
}
