using System.Diagnostics;

namespace Tralus.Shell.WindowsService
{
    class EventLogger
    {
        public static string LogEntryName = "TralusWindowsService";
        public static void Log(string message)
        {
            EventLog.WriteEntry(LogEntryName, message);
        }
    }
}