using Flyingdarts.Control.App;

namespace Flyingdarts.Control.Core;
public partial class SpeechRecognitionService
{
    public partial SpeechRecognizerAuthorizationStatus GetAuthorizationStatus();

    public partial void RequestAuthorization(Action<byte> completionHandler);

    public partial Task<int> Listen();
}
