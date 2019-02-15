using ReactiveUI;
using Splat;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;

namespace Essentials.Sample
{
    public class MainViewModel : ReactiveObject, IScreen
    {
        private MasterCellViewModel _selected;

        public IEnumerable<MasterCellViewModel> MenuItems { get; set; }

        public ReactiveCommand<IRoutableViewModel, Unit> NavigateToMenuItem { get; }

        public RoutingState Router { get; }

        public MasterCellViewModel Selected

        {
            get => _selected;

            set => this.RaiseAndSetIfChanged(ref _selected, value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        public MainViewModel()
        {
            Router = new RoutingState();
            Locator.CurrentMutable.RegisterConstant(this, typeof(IScreen));

            MenuItems = new[]
            {
                new MasterCellViewModel
                {
                    Title = "Compass Page",
                    IconSource = "reminders.png",
                    TargetType = typeof(CompassViewModel)
                },
                new MasterCellViewModel
                {
                    Title = "Connectivity Page",
                    IconSource = "contacts.png",
                    TargetType = typeof(ConnectivityViewModel)
                }
            };

            NavigateToMenuItem = ReactiveCommand.CreateFromObservable<IRoutableViewModel, Unit>(routableVm =>
                Router.NavigateAndReset.Execute(routableVm).Select(_ => Unit.Default));

            this.WhenAnyValue(x => x.Selected)
                .Where(x => x != null)
                .StartWith(MenuItems.First())
                .Select(x => Locator.Current.GetService<IRoutableViewModel>(x.TargetType.FullName))
                .InvokeCommand(NavigateToMenuItem);
        }
    }
}