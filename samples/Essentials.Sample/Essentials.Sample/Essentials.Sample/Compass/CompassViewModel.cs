using ReactiveUI;
using Rocket.Surgery.Xamarin.Essentials.Abstractions;
using Splat;

namespace Essentials.Sample
{
    public class CompassViewModel : ReactiveObject, IRoutableViewModel
    {
        private readonly ICompass _compass;

        public CompassViewModel(ICompass compass)
        {
            _compass = compass;
            HostScreen = Locator.Current.GetService<IScreen>();
        }

        public string UrlPathSegment => nameof(CompassViewModel);

        public IScreen HostScreen { get; }
    }
}