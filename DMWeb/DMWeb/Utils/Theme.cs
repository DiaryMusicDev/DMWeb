namespace DMWeb.Utils
{
    public class Theme
    {
        public List<string> Themes = new List<string>() { "light", "dark" };
        public ThemeOption CurrentOption { get; set; }
        public enum ThemeOption { Light, Dark };
    }
}
