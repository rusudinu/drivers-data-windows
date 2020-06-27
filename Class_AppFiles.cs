using System;
using System.IO;

namespace DriversData_PC
{
    public static class Class_AppFiles
    {
        
        public static string newAppVersionLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Updates\newVesion.exe");
        public static string cacheFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Cache\");
        public static string savedCredentialsHiddenFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"hidden\credentials");
        public static string savedCredentialsHiddenFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"hidden\");
    }
}
