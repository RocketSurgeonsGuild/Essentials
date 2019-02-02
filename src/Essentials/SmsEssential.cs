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
    /// Provides access to the <see cref="Sms"/> API.
    /// </summary>
    /// <seealso cref="ISms" />
    public class SmsEssential : ISms
    {
        /// <inheritdoc />
        public IObservable<Unit> Compose() => Observable.FromAsync(Sms.ComposeAsync);

        /// <inheritdoc />
        public IObservable<Unit> Compose(SmsMessage message) => Observable.FromAsync(() => Sms.ComposeAsync(message));
    }
}
