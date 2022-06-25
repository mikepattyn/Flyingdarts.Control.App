using Flyingdarts.Control.App;
using System;

namespace Flyingdarts.Control.Core;
public partial class SpeechRecognitionService
{
    public partial SpeechRecognizerAuthorizationStatus GetAuthorizationStatus()
    {
        throw new NotImplementedException();
    }

    public partial void RequestAuthorization(Action<byte> completionHandler)
    {
        throw new NotImplementedException();
    }

    public partial Task<int> Listen()
    {
        throw new NotImplementedException();
    }
}