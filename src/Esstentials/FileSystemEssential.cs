using System;
using System.IO;
using System.Reactive.Linq;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials
{
    /// <summary>
    /// Provides access to the <see cref="FileSystem"/> API.
    /// </summary>
    /// <seealso cref="IFileSystem" />
    public class FileSystemEssential : IFileSystem
    {
        /// <inheritdoc />
        public string AppDataDirectory => FileSystem.AppDataDirectory;

        /// <inheritdoc />
        public string CacheDirectory => FileSystem.CacheDirectory;

        /// <inheritdoc />
        public IObservable<Stream> OpenAppPackageFile(string filename) =>
            Observable.FromAsync(() => FileSystem.OpenAppPackageFileAsync(filename));
    }
}