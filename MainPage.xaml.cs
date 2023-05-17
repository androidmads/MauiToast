using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace MauiToast;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        await Toast.Make("Howdy, I'm a Toast!",
                  ToastDuration.Long,
                  16)
            .Show(cancellationTokenSource.Token);
    }
}

