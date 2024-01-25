using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace DMWeb.Utils
{
    public class Theme
    {
        public List<string> Themes = new List<string>() { "light", "dark" };
        public ThemeOption CurrentOption { get; set; }
        public enum ThemeOption { Light, Dark };
    }
    public class ThemeService
    {
        private const string ThemeStorageKey = "CTheme";
        private readonly ProtectedLocalStorage _localStorage;

        public ThemeService(ProtectedLocalStorage localStorage)
        {
            _localStorage = localStorage;
        }

        public async Task<string> GetCurrentTheme()
        {
            var result = await _localStorage.GetAsync<string>(ThemeStorageKey);
            return result.Success ? result.Value : null;
        }

        public async Task SetCurrentTheme(string theme)
        {
            await _localStorage.SetAsync(ThemeStorageKey, theme);
        }
    }
}
