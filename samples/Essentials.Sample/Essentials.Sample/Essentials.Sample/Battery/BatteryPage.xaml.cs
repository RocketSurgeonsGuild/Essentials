using System.Reactive.Disposables;
using ReactiveUI;
using ReactiveUI.XamForms;

namespace Essentials.Sample
{
    public partial class BatteryPage : ReactiveContentPage<BatteryViewModel>
    {
        public BatteryPage ()
        {
            InitializeComponent ();
            
            this.WhenActivated(disposables =>
            {
                ViewModel
                    .ConnectionInteraction
                    .RegisterHandler(async interaction =>
                    {
                        await DisplayAlert("Connection Status", interaction.Input, "Ok");
                        interaction.SetOutput(true);
                    })
                    .DisposeWith(disposables);
            });
        }
    }
}
