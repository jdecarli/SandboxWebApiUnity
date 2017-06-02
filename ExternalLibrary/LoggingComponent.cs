using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ExternalLibrary
{
    public class LoggingComponent : ILoggingComponent
    {
        public LoggingComponent()
        {
            Debug.WriteLine("new instance");
        }

        public void LogBeginCall()
        {
            Debug.WriteLine("Begin call logged");
        }

        public void LogEndCall()
        {
            Debug.WriteLine("End call logged");
        }

        public IEnumerable<T> Logger<T>(Func<IEnumerable<T>> method)
        {
            LogBeginCall();

            var result = method();

            LogEndCall();

            return result;
        }
    }
}
