using Flyingdarts.Control.App;
using Speech;
using AVFoundation;
using Foundation;

namespace Flyingdarts.Control.Core;

public partial class SpeechRecognitionService
{
    public partial SpeechRecognizerAuthorizationStatus GetAuthorizationStatus()
    {
        return MapFrom(SFSpeechRecognizer.AuthorizationStatus)
            .ToSpeechRecognizerAuthorizationStatus();
    }

    public partial void RequestAuthorization(Action<byte> completionHandler)
    {
        SFSpeechRecognizer.RequestAuthorization(status =>
        {
            completionHandler(MapFrom(status));
        });
    }

    public partial Task<int> Listen()
    {
        throw new NotImplementedException();
    }

    private byte MapFrom(SFSpeechRecognizerAuthorizationStatus status)
    {
        switch (status)
        {
            case SFSpeechRecognizerAuthorizationStatus.NotDetermined:
                return (byte)SpeechRecognizerAuthorizationStatus.NotDetermined;
            case SFSpeechRecognizerAuthorizationStatus.Denied:
                return (byte)SpeechRecognizerAuthorizationStatus.Denied;
            case SFSpeechRecognizerAuthorizationStatus.Restricted:
                return (byte)SpeechRecognizerAuthorizationStatus.Restricted;
            case SFSpeechRecognizerAuthorizationStatus.Authorized:
                return (byte)SpeechRecognizerAuthorizationStatus.Authorized;
            default:
                throw new ArgumentOutOfRangeException(nameof(status), status, null);
        }
    }
}