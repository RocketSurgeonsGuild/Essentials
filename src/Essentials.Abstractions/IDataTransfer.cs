using System;
using System.Reactive;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Rocket.Surgery.Xamarin.Essentials.Abstractions
{
    /// <summary>
    /// Interface representing Data Transfer features.
    /// </summary>
    public interface IDataTransfer
    {
        /// <summary>
        /// Requests the asynchronous.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>An observable sequence notification.</returns>
        IObservable<Unit> Request(string text);

        /// <summary>
        /// Requests the asynchronous.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="title">The title.</param>
        /// <returns>An observable sequence notification.</returns>
        IObservable<Unit> Request(string text, string title);

        /// <summary>
        /// Requests the asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>An observable sequence notification.</returns>
        IObservable<Unit> Request(ShareTextRequest request);
    }
}