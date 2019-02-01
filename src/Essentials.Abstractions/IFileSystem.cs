using System;
using System.IO;
using System.Threading.Tasks;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing File System features.
    /// </summary>
    public interface IFileSystem
    {
        /// <summary>
        /// Gets the cache directory.
        /// </summary>
        string CacheDirectory { get; }

        /// <summary>
        /// Gets the application data directory.
        /// </summary>
        string AppDataDirectory { get; }

        /// <summary>
        /// Opens the application package file asynchronous.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <returns>An observable sequence returning a stream.</returns>
        IObservable<Stream> OpenAppPackageFile(string filename);
    }
}