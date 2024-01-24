namespace DMWeb.Utils
{
    public class Theme
    {
        public static List<string> Themes = new List<string>() { "Light", "Dark" };
        public static int Themeoption { get; set; }
        public enum ThemeOption { Light=0, Dark=1 };
    }
}
