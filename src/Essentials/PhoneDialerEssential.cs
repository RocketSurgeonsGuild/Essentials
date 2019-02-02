using System;
using System.Collections.Generic;
using System.Text;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access to the <see cref="PhoneDialer"/> API.
    /// </summary>
    /// <seealso cref="IPhoneDialer" />
    public class PhoneDialerEssential : IPhoneDialer
    {
        /// <inheritdoc />
        public void Open(string number) => PhoneDialer.Open(number);
    }
}
