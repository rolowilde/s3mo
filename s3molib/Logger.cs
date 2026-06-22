using System;
using System.Collections.Generic;
using System.Text;

namespace s3molib
{
    public static class Logger
    {
        public static event Action<string> InfoLoggedEvent;
        public static event Action<string> DebugLoggedEvent;
        public static event Action<string> WarningLoggedEvent;
        public static event Action<string> ErrorLoggedEvent;

        public static void Log(string s)
        {
            InfoLoggedEvent?.Invoke(s);
        }

        public static void LogDebug(string s)
        {
            DebugLoggedEvent?.Invoke(s);
        }

        public static void LogWarning(string s)
        {
            WarningLoggedEvent?.Invoke(s);
        }

        public static void LogError(string s)
        {
            ErrorLoggedEvent?.Invoke(s);
        }
    }
}
