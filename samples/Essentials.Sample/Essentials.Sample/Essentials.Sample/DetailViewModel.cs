using System.Reactive;
using System.Reactive.Linq;
using ReactiveUI;
using Splat;

namespace Essentials.Sample
{
    public class DetailViewModel : ReactiveObject, IRoutableViewModel
    {
        public DetailViewModel(IScreen hostScreen = null)
        {
            HostScreen = hostScreen ?? Locator.Current.GetService<IScreen>();

            NavigateToDetailPage = ReactiveCommand.CreateFromObservable(
                () => HostScreen.Router.Navigate.Execute(new DetailViewModel()).Select(_ => Unit.Default));
        }

        public ReactiveCommand<Unit, Unit> NavigateToDetailPage { get; }

        public ReactiveCommand<Unit, Unit> NavigateBack => HostScreen.Router.NavigateBack;

        public string UrlPathSegment => "Dummy Page";

        public IScreen HostScreen { get; }
    }
}