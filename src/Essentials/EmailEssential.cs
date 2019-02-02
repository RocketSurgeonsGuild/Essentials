using System;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access to the <see cref="Email"/> API.
    /// </summary>
    /// <seealso cref="IEmail" />
    public class EmailEssential : IEmail
    {
        /// <inheritdoc />
        public IObservable<Unit> Compose() => Observable.FromAsync(Email.ComposeAsync);

        /// <inheritdoc />
        public IObservable<Unit> Compose(string subject, string body, params string[] to) =>
            Observable.FromAsync(() => Email.ComposeAsync(subject, body, to));

        /// <inheritdoc />
        public IObservable<Unit> Compose(EmailMessage message) =>
            Observable.FromAsync(() => Email.ComposeAsync(message));
    }
}
