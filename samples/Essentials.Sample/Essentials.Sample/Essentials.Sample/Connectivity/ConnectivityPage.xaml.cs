using System.Reactive.Disposables;
using ReactiveUI;
using ReactiveUI.XamForms;
using Xamarin.Forms.Xaml;

namespace Essentials.Sample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConnectivityPage : ReactiveContentPage<ConnectivityViewModel>
	{
		public ConnectivityPage ()
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