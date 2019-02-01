namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Phone Dialing features.
    /// </summary>
    public interface IPhoneDialer
    {
        /// <summary>
        /// Opens the specified number.
        /// </summary>
        /// <param name="number">The number.</param>
        void Open(string number);
    }
}