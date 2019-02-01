namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Screen Lock features.
    /// </summary>
    public interface IScreenLock
    {
        /// <summary>
        /// Gets a value indicating whether this instance is active.
        /// </summary>
        bool IsActive { get; }

        /// <summary>
        /// Request active.
        /// </summary>
        void RequestActive();

        /// <summary>
        /// Request release.
        /// </summary>
        void RequestRelease();
    }
}