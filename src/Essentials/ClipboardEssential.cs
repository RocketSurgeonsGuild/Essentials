using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access to the <see cref="Clipboard"/> API.
    /// </summary>
    /// <seealso cref="IClipboard" />
    public class ClipboardEssential : IClipboard
    {
        /// <inheritdoc />
        public bool HasText => Clipboard.HasText;

        /// <inheritdoc />
        public void SetText(string text) => Clipboard.SetTextAsync(text);

        /// <inheritdoc />
        public IObservable<string> GetText() => Observable.FromAsync(Clipboard.GetTextAsync);
    }
}
