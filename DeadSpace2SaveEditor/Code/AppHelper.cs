namespace DeadSpace2SaveEditor.Code
{
    public static class AppHelper
    {
        public static string GetVersionStr()
        {
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            return $"{version.Major}.{version.Minor}";
        }

        public static string GetApplicationName()
        {
            return $"Dead Space 2 PC Save Editor [ver. {GetVersionStr()}]";
        }
    }
}
