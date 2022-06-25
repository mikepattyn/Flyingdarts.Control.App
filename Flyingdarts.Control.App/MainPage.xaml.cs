using Flyingdarts.Control.Core;

namespace Flyingdarts.Control.App;

public partial class MainPage : ContentPage
{
    private readonly SpeechRecognitionService SpeechRecognitionService;

	public MainPage(SpeechRecognitionService speechRecognitionService)
	{
		InitializeComponent();

        SpeechRecognitionService = speechRecognitionService;
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		SpeechRecognitionService.RequestAuthorization(result =>
        {
            CounterBtn.Text = Enum.GetName(result.ToSpeechRecognizerAuthorizationStatus()).ToString();
        });
	}
}

