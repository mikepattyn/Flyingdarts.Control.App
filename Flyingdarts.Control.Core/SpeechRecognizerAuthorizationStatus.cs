namespace Flyingdarts.Control.App;

public enum SpeechRecognizerAuthorizationStatus
{
    NotDetermined, Denied, Restricted, Authorized
}

public static class ByteExtensions
{
    public static SpeechRecognizerAuthorizationStatus ToSpeechRecognizerAuthorizationStatus(this byte value)
    {
        switch (value)
        {
            case 0:
                return SpeechRecognizerAuthorizationStatus.NotDetermined;
            case 1:
                return SpeechRecognizerAuthorizationStatus.Denied;
            case 2:
                return SpeechRecognizerAuthorizationStatus.Restricted;
            case 3:
                return SpeechRecognizerAuthorizationStatus.Authorized;
            default:
                throw new ArgumentOutOfRangeException(nameof(value), value, null);
        }
    }
}