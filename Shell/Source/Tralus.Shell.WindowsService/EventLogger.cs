using System.Diagnostics;

namespace Tralus.Shell.WindowsService
{
    class EventLogger
    {
        public static string LogEntryName = "TralusWindowService";
        public static void Log(string message)
        {
            EventLog.WriteEntry(LogEntryName, message);
        }
    }
}