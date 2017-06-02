using System;
using System.Collections.Generic;

namespace ExternalLibrary
{
    public interface ILoggingComponent
    {
        void LogBeginCall();
        void LogEndCall();
        IEnumerable<T> Logger<T>(Func<IEnumerable<T>> method);
    }
}