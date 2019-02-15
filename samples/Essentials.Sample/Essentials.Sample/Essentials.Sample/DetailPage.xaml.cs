using System.Reactive.Disposables;
using ReactiveUI;
using ReactiveUI.XamForms;

namespace Essentials.Sample
{
    public partial class DetailPage : ReactiveContentPage<DetailViewModel>
    {
        public DetailPage()
        {
            InitializeComponent();

            this.WhenActivated(
                disposables =>
                {
                    this.BindCommand(ViewModel, vm => vm.NavigateToDetailPage, v => v.NavigateButton)
                        .DisposeWith(disposables);
                    this.BindCommand(ViewModel, vm => vm.NavigateBack, v => v.BackButton)
                        .DisposeWith(disposables);
                });
        }
    }
}
